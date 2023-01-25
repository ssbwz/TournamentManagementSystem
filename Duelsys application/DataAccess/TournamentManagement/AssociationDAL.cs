using DataAccess.ExceptionModels;
using DataAccess.TournamentManagement;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;
using DuelSysLogic.Models.Tournament.Tournament_Systems;
using DuelSysLogic.Models.Tournament.TournamentDetails;
using DuelSysLogic.Models.TournamentModels;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DataAccess
{
    public class AssociationDAL : IAssociationRepository
    {
        private MySqlConnection conn { get { return Connection.Connect; } }

        private int associationId;

        private Dictionary<string, ITournamentSystem> tournamentSystems;
        private Dictionary<string, Sport> sportypes;


        ///<summary> When there is known association id <paramref name="description"/>
        ///<para>Can be used to manage tounaments for one association</para>
        ///</summary>
        public AssociationDAL(int associationId)
        {
            this.associationId = associationId;

            tournamentSystems = new Dictionary<string, ITournamentSystem>();
            tournamentSystems.Add("Round Robin", new RoundRobin());

            sportypes = new Dictionary<string, Sport>();
            sportypes.Add("Badminton", new Badminton());
            sportypes.Add("Ping Pong", new PingPong());
        }

        public void CreateTournament(Tournament newTournament)
        {
            try
            {
                string sql = String.Empty;
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "INSERT INTO `tournaments`(`AssociationId`,`Title`, `Decription`, `MinPlayers`, " +
                    "`MaxPlayers`, `StartDate`, `EndDate`, `Street`, `BuidlingNum`, `Zipcode`, `SportType`, `TournamentSystem`) " +
                    "VALUES (@ASSOCIATIONID,@TITLE,@DESCRIPTION,@MINPLAYERS,@MAXPLAYERS," +
                    "@STARTDATE,@ENDDATE,@STREET,@BUIDLINGNUM,@ZIPCODE,@SPORTTYPE,@TOURNAMENTSYSTEM)";

                cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);
                cmd.Parameters.AddWithValue("TITLE", newTournament.TournamentShortInfo.Title);

                cmd.Parameters.AddWithValue("DESCRIPTION", newTournament.Description);

                cmd.Parameters.AddWithValue("MINPLAYERS", newTournament.Requirement.MinPlayers);
                cmd.Parameters.AddWithValue("MAXPLAYERS", newTournament.Requirement.MaxPlayers);

                cmd.Parameters.AddWithValue("STARTDATE", newTournament.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("ENDDATE", newTournament.EndDate.ToString("yyyy-MM-dd"));

                cmd.Parameters.AddWithValue("STREET", newTournament.Location.Street);
                cmd.Parameters.AddWithValue("BUIDLINGNUM", newTournament.Location.BuidlingNum);
                cmd.Parameters.AddWithValue("ZIPCODE", newTournament.Location.ZipCode);

                cmd.Parameters.AddWithValue("SPORTTYPE", newTournament.TournamentShortInfo.SportType.ToString());
                cmd.Parameters.AddWithValue("TOURNAMENTSYSTEM", newTournament.TournamentShortInfo.TournamentSystem.ToString());

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't create tournament", ex);
            }
        }

        public void DeleteTournament(TournamentShortInfo deletedTournament)
        {
            try
            {
                string sql = string.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "DELETE FROM `tournaments` WHERE Id = @ID";

                cmd.Parameters.AddWithValue("ID", deletedTournament.Id);

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't delete a tournament", ex);
            }
        }

        public List<TournamentShortInfo> GetEightTournamentShortInfoEachTime(int pageNumber)
        {
            try
            {
                --pageNumber;
                int groupNum = pageNumber * 8;

                List<TournamentShortInfo> tournamentShortInfos = new List<TournamentShortInfo>();

                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT `Id`, `Title`, `SportType` `Sport Type`, `TournamentSystem` `Tournament System`, COUNT(teamId) as `Participants Number`" +
                    $" FROM participants RIGHT JOIN tournaments " +
                    $"ON Id = TournamentId " +
                    $"WHERE associationId = @ASSOCIATIONID " +
                    $"GROUP BY(Id) " +
                    $"LIMIT {groupNum}, 8", conn);

                cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    while (reader.Read())
                    {

                        tournamentShortInfos.Add(
                            new TournamentShortInfo(
                            reader.GetInt32("Id"),
                            reader.GetString("Title"),
                            tournamentSystems[reader.GetString("Tournament System")],
                            sportypes[reader.GetString("Sport Type")],
                            reader.GetInt32("Participants Number")
                            ));
                    }

                    return tournamentShortInfos;
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't load tournament list");
                return null;
            }
        }

        public List<TournamentShortInfo> GetThreeTournamentShortInfoEachTime(int pageNumber)
        {
            try
            {
                --pageNumber;
                int groupNum = pageNumber * 3;

                List<TournamentShortInfo> tournamentShortInfos = new List<TournamentShortInfo>();

                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT `Id`, `Title`, `SportType` `Sport Type`, `TournamentSystem` `Tournament System`, COUNT(teamId) as `Participants Number`" +
                    $" FROM participants RIGHT JOIN tournaments " +
                    $"ON Id = TournamentId " +
                    $"WHERE associationId = @ASSOCIATIONID " +
                    $"GROUP BY(Id) " +
                    $"LIMIT {groupNum}, 3", conn);

                cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    while (reader.Read())
                    {

                        tournamentShortInfos.Add(
                            new TournamentShortInfo(
                            reader.GetInt32("Id"),
                            reader.GetString("Title"),
                            tournamentSystems[reader.GetString("Tournament System")],
                            sportypes[reader.GetString("Sport Type")],
                            reader.GetInt32("Participants Number")
                            ));
                    }

                    return tournamentShortInfos;
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't load tournament list");
                return null;
            }
        }

        public Tournament GetTournamentById(int tournamentId)
        {
            try
            {
                string sql = string.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "SELECT t.Id, `Title`, `Decription`, `MinPlayers`, `MaxPlayers`, `StartDate`, `EndDate`, `Street`, `BuidlingNum`, `Zipcode`, `SportType`, `TournamentSystem`," +
                    " COUNT(teamId) AS `Participants Number`, TeamIdGold, tg.Name AS `Golden name`, TeamIdSilver, ts.Name As `Silver name`, TeamIdBronze, tb.Name AS `Bronze name` " +
                    "FROM participants RIGHT JOIN tournaments t ON Id = TournamentId " +
                    "LEFT JOIN teams tg ON TeamIdGold = tg.Id LEFT JOIN teams ts ON TeamIdSilver = ts.Id " +
                    "LEFT JOIN teams tb ON TeamIdBronze = tb.Id WHERE t.Id = @ID";

                cmd.Parameters.AddWithValue("ID", tournamentId);

                cmd.CommandText = sql;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    reader.Read();

                    Team goldenTeam = null;
                    Team silverTeam = null;
                    Team bronzeTeam = null;
                    if (reader["TeamIdGold"] != DBNull.Value) 
                    {
                        int teamId = reader.GetInt32("TeamIdGold");
                        string teamName = reader.GetString("Golden name");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        goldenTeam = new Team(teamId, teamName, teamRepository);

                    }
                    if (reader["TeamIdSilver"] != DBNull.Value)
                    {
                        int teamId = reader.GetInt32("TeamIdSilver");
                        string teamName = reader.GetString("Silver name");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        silverTeam = new Team(teamId, teamName, teamRepository);

                    }
                    if (reader["TeamIdBronze"] != DBNull.Value)
                    {
                        int teamId = reader.GetInt32("TeamIdBronze");
                        string teamName = reader.GetString("Bronze name");
                        ITeamRepository teamRepository = new TeamDAL(teamId);

                        bronzeTeam = new Team(teamId, teamName, teamRepository);

                    }

                    int id = reader.GetInt32("Id");
                    string title = reader.GetString("Title");
                    Sport sportType = sportypes[reader.GetString("SportType")];
                    ITournamentSystem tournamentSystem = tournamentSystems[reader.GetString("TournamentSystem")];
                    int particiapntsNum = reader.GetInt32("Participants Number");

                    TournamentShortInfo tournamentShortInfo = new TournamentShortInfo(id, title, tournamentSystem, sportType,particiapntsNum);


                    int minPlayer = reader.GetInt32("MinPlayers");
                    int maxPlayer = reader.GetInt32("MaxPlayers");
                    Requirement requirement = new Requirement(minPlayer, maxPlayer);


                    string street = reader.GetString("Street");
                    string buildingNum = reader.GetString("BuidlingNum");
                    string zipcode = reader.GetString("Zipcode");
                    Location location = new Location(street, buildingNum, zipcode);

                    string description = reader.GetString("Decription");
                    DateTime startDate = reader.GetDateTime("StartDate");
                    DateTime endDate = reader.GetDateTime("EndDate");

                    ITournamentRepository repository = new TouranmentDAL(id);

                    Tournament tournament = new Tournament(tournamentShortInfo, description, location, requirement, startDate, endDate,repository);

                    tournament.GoldenMedalTeam = goldenTeam;
                    tournament.SilverMedalTeam = silverTeam;
                    tournament.BronzeMedalTeam = bronzeTeam;

                    return tournament;
                }
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get a tournament", ex);
            }
        }

        public void UpdateTournament(Tournament updatedTournament)
        {
            try
            {
                string sql = string.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "UPDATE `tournaments` " +
                    "SET `Title`=@TITLE,`Decription`=@DECRIPTION," +
                    "`MinPlayers`=@MINPLAYERS,`MaxPlayers`=@MAXPLAYERS,`StartDate`=@STARTDATE,`EndDate`=@ENDDATE,`Street`=@STREET," +
                    "`BuidlingNum`=@BUILDINGNUM,`Zipcode`=@ZIPCODE,`SportType`=@SPORTYPE,`TournamentSystem`=@TOURNAMENTSYSTEM" +
                    " WHERE Id = @ID";

                cmd.Parameters.AddWithValue("ID", updatedTournament.TournamentShortInfo.Id);

                cmd.Parameters.AddWithValue("TITLE", updatedTournament.TournamentShortInfo.Title);
                cmd.Parameters.AddWithValue("DECRIPTION", updatedTournament.Description);

                cmd.Parameters.AddWithValue("MINPLAYERS", updatedTournament.Requirement.MinPlayers);
                cmd.Parameters.AddWithValue("MAXPLAYERS", updatedTournament.Requirement.MaxPlayers);
                cmd.Parameters.AddWithValue("STARTDATE", updatedTournament.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("ENDDATE", updatedTournament.EndDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("STREET", updatedTournament.Location.Street);

                cmd.Parameters.AddWithValue("BUILDINGNUM", updatedTournament.Location.BuidlingNum);
                cmd.Parameters.AddWithValue("ZIPCODE", updatedTournament.Location.ZipCode);
                cmd.Parameters.AddWithValue("SPORTYPE", updatedTournament.TournamentShortInfo.SportType.ToString());
                cmd.Parameters.AddWithValue("TOURNAMENTSYSTEM", updatedTournament.TournamentShortInfo.TournamentSystem.ToString());

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't update a tournament", ex);
            }
        }

        public void UpdateMedals(Tournament updatedTournament)
        {
            try
            {
                string sql = string.Empty;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "UPDATE `tournaments` " +
                    "SET `TeamIdGold`=@TEAMIDGOLD,`TeamIdSilver`=@TEAMIDSILVER," +
                    " `TeamIdBronze`=@TEAMIDBRONZE"+
                    " WHERE Id = @ID";

                cmd.Parameters.AddWithValue("ID", updatedTournament.TournamentShortInfo.Id);

                cmd.Parameters.AddWithValue("TEAMIDGOLD", updatedTournament.GoldenMedalTeam.Id);
                cmd.Parameters.AddWithValue("TEAMIDSILVER", updatedTournament.SilverMedalTeam.Id);
                cmd.Parameters.AddWithValue("TEAMIDBRONZE", updatedTournament.BronzeMedalTeam.Id);

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't update medals", ex);
            }
        }
    }
}
