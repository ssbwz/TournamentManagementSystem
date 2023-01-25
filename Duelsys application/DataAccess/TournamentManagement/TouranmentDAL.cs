using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Interfaces.DAL;
using MySql.Data.MySqlClient;
using DuelSysLogic.Models;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;
using System.Diagnostics;
using DataAccess.ExceptionModels;

namespace DataAccess.TournamentManagement
{
    public class TouranmentDAL : ITournamentRepository
    {
        private TeamsDAL teamsDAL;
        private TeamDAL teamDAL;

        private int tournamentId;

        private Dictionary<string, Sport> sportypes;
        public TouranmentDAL(int tournamentId)
        {
            this.tournamentId = tournamentId;

            sportypes = new Dictionary<string, Sport>();
            sportypes.Add("Badminton", new Badminton());
            sportypes.Add("Ping Pong", new PingPong());
        }

        private MySqlConnection conn
        {
            get
            {
                return Connection.Connect;
            }
        }

        public List<Match> GetTwelveMatchesPerPage(int pageNumber)
        {
            try
            {
                --pageNumber;
                int groupNum = pageNumber * 12;

                string sql = String.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "SELECT `TournamentId`, m.Id, `TeamAwayId`, tA.Name TeamAwayName, `TeamHomeId`, tH.Name TeamHomeName, `TeamAwayScore`, `TeamHomeScore`, `WinnerTeamId`, t.SportType " +
                    "FROM matches m LEFT JOIN teams tA " +
                    "ON TeamAwayId = tA.Id " +
                    "LEFT JOIN teams tH" +
                    " ON TeamHomeId = th.Id " +
                    "INNER JOIN tournaments t " +
                    "ON TournamentId = t.Id" +
                    " WHERE TournamentId = @TOURNAMENTID " +
                     $"LIMIT {groupNum}, 12";

                cmd.Parameters.AddWithValue("TOURNAMENTID", tournamentId);

                List<Match> matches = new List<Match>();

                cmd.CommandText = sql;

                return getMatchesFromMySqlCommand(cmd);

            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't load matches list", ex);
            }
        }

        public List<Match> GetMatches()
        {
            try
            {
                string sql = String.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "SELECT `TournamentId`, m.Id, `TeamAwayId`, tA.Name TeamAwayName, `TeamHomeId`, tH.Name TeamHomeName, `TeamAwayScore`, `TeamHomeScore`, `WinnerTeamId`, t.SportType " +
                    "FROM matches m LEFT JOIN teams tA " +
                    "ON TeamAwayId = tA.Id " +
                    "LEFT JOIN teams tH" +
                    " ON TeamHomeId = th.Id " +
                    "INNER JOIN tournaments t " +
                    "ON TournamentId = t.Id" +
                    " WHERE TournamentId = @TOURNAMENTID ";

                cmd.Parameters.AddWithValue("TOURNAMENTID", tournamentId);

                List<Match> matches = new List<Match>();

                cmd.CommandText = sql;

                return getMatchesFromMySqlCommand(cmd);
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't load matches list", ex);
            }
        }

        private List<Match> getMatchesFromMySqlCommand(MySqlCommand cmd)
        {

            List<Match> matches = new List<Match>();

            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    Team teamAway = null;
                    Team teamHome = null;
                    int? teamAwayScore = null;
                    int? teamHomeScore = null;

                    if (reader["TeamAwayId"] != DBNull.Value)
                    {
                        int teamId = reader.GetInt32("TeamAwayId");
                        string teamName = reader.GetString("TeamAwayName");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        teamAway = new Team(teamId, teamName, teamRepository);

                    }


                    if (reader["TeamHomeId"] != DBNull.Value)
                    {
                        int teamId = reader.GetInt32("TeamHomeId");
                        string teamName = reader.GetString("TeamHomeName");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        teamHome = new Team(teamId, teamName, teamRepository);

                    }

                    teamAwayScore = reader["TeamAwayScore"] != DBNull.Value ? reader.GetInt32("TeamAwayScore") : null;
                    teamHomeScore = reader["TeamHomeScore"] != DBNull.Value ? reader.GetInt32("TeamHomeScore") : null;
                    matches.Add(new Match(reader.GetInt32("Id"), teamAway, teamAwayScore, teamHome, teamHomeScore, sportypes[reader.GetString("SportType")]));
                }
            }
            return matches;
        }

        public void InsertMatches(List<Match> matches)
        {
            try
            {
                string sql = "INSERT INTO `matches`(`TournamentId`, `TeamAwayId`, `TeamHomeId`) VALUES";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                for (int i = 0; i < matches.Count; i++)
                {

                    if (i == 0)
                    {
                        sql += $"(@TOURNAMNETID{i},@TEAMAWAYID{i},@TEAMHOMEID{i})";
                    }
                    else
                    {
                        sql += $",(@TOURNAMNETID{i},@TEAMAWAYID{i},@TEAMHOMEID{i})";
                    }

                    cmd.Parameters.AddWithValue($"TOURNAMNETID{i}", tournamentId);
                    cmd.Parameters.AddWithValue($"TEAMAWAYID{i}", matches[i].TeamAway == null ? null : matches[i].TeamAway.Id);
                    cmd.Parameters.AddWithValue($"TEAMHOMEID{i}", matches[i].TeamHome == null ? null : matches[i].TeamHome.Id);
                }

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't create tournament schedule", ex);
            }
        }

        public void RegisterResults(Match updatedMatch)
        {
            try
            {
                string sql = String.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "UPDATE `matches` SET `TeamAwayScore`=@TEAMAWAYSCORE,`TeamHomeScore`=@TEAMHOMESCORE,`WinnerTeamId`=@WINNNERID" +
                    " WHERE Id = @ID";

                cmd.Parameters.AddWithValue("TEAMAWAYSCORE", updatedMatch.ScoreTeamAway.ToString());
                cmd.Parameters.AddWithValue("TEAMHOMESCORE", updatedMatch.ScoreTeamHome.ToString());
                cmd.Parameters.AddWithValue("WINNNERID", updatedMatch.Winner == null ? null : updatedMatch.Winner.Id);

                cmd.Parameters.AddWithValue("ID", updatedMatch.Id);

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't register results", ex);
            }
        }

        public Match GetMatchById(int matchId)
        {
            throw new NotImplementedException();
        }

        public void AddTeam(Team addedTeam)
        {
            try
            {
                teamsDAL = new TeamsDAL(1);


                int teamId = teamsDAL.GetTeamIdByMemeberId(addedTeam.Name);

                if (teamId == 0)
                {
                    this.teamsDAL.CreateTeam(new Team(addedTeam.Name));
                    teamId = teamsDAL.GetTeamIdByMemeberId(addedTeam.Name);
                    this.teamDAL = new TeamDAL(teamId);
                    this.teamDAL.AddMember(addedTeam.Id);
                }


                MySqlCommand cmd = new MySqlCommand("INSERT INTO `participants`(`TournamentId`, `TeamId`) VALUES (@TOURNAMENTID,@TEAMID)", conn);

                cmd.Parameters.AddWithValue("TOURNAMENTID", tournamentId);
                cmd.Parameters.AddWithValue("TEAMID", teamId);

                cmd.ExecuteNonQuery();
            }
            catch (DALException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't register a player", ex);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("key"))
                {
                    if (ex.Message.Contains("UQ_Tournament_TeamId"))
                    {
                        throw new TeamAlreadyRegisteredException("Your team is already registered");
                    }
                }

                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't register a player", ex);
            }
        }

        public List<Team> GetParticipants()
        {
            try
            {
                string sql = "SELECT Id, NAME " +
                    "FROM teams t INNER JOIN participants p " +
                    "ON p.TeamId = t.Id " +
                    "WHERE p.TournamentId = @TOURNAMENTID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("TOURNAMENTID", tournamentId);
                List<Team> teams = new List<Team>();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int teamId = reader.GetInt32("Id");
                        string teamName = reader.GetString("NAME");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        teams.Add(new Team(teamId, teamName, teamRepository));
                    }


                }

                return teams;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Could't get teams", ex);
            }
        }

        public void RemoveTeam(Team removedTeam)
        {
            throw new NotImplementedException();
        }
    }
}
