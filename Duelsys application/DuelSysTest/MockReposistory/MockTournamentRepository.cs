using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;
using System.Collections.Generic;


namespace DuelSysTest.MockReposistory
{
    internal class MockTournamentRepository : ITournamentRepository
    {
        private List<Match> matches;
        private List<Team> teams;

        public MockTournamentRepository(int tournamentId)
        {
            matches = new List<Match>();
            if (tournamentId == 1)
            {


                Team TeamAwayPingPong = new Team("TeamAwayPingPong");
                Team teamHomePingPon = new Team("teamHomePingPong");

                matches.Add(new Match(1, TeamAwayPingPong, null, teamHomePingPon, null, new PingPong()));

                teams = new List<Team>();

                teams.Add(new Team(1, "Team1"));
                teams.Add(new Team(2, "Team2"));
                teams.Add(new Team(3, "Team3"));
                teams.Add(new Team(4, "Team4"));
                teams.Add(new Team(5, "Team5"));
            }
            else if (tournamentId == 2)
            {
                Team team1 = new Team(1, "Team1");
                Team team2 = new Team(2, "Team2");
                Team team3 = new Team(3, "Team3");
                Team team4 = new Team(4, "Team4");

                Match match = null;
                match = new Match(1, team1, 8, team3, 21, new Badminton());
                matches.Add(match);
                match = new Match(2, team2, 8, team4, 21, new Badminton());
                matches.Add(match);
                match = new Match(3, team1, 22, team2, 24, new Badminton());
                matches.Add(match);
                match = new Match(4, team4, 30, team3, 29, new Badminton());
                matches.Add(match);
                match = new Match(5, team1, 7, team4, 21, new Badminton());
                matches.Add(match);
                match = new Match(6, team3, 30, team2, 29, new Badminton());
                matches.Add(match);
            }
            else if (tournamentId == 3)
            {
                Team team1 = new Team(1, "Team1");
                Team team2 = new Team(2, "Team2");
                Team team3 = new Team(3, "Team3");
                Team team4 = new Team(4, "Team4");

                Match match = null;

                match = new Match(1, team1, 8, team3, 21, new Badminton());

                matches.Add(match);

                match = new Match(2, team2, 8, team4, 21, new Badminton());

                matches.Add(match);

                match = new Match(3, team1, 22, team2, 24, new Badminton());

                matches.Add(match);

                match = new Match(4, team4, 30, team3, 29, new Badminton());

                matches.Add(match);

                match = new Match(5, team1, 21, team4, 7, new Badminton());

                matches.Add(match);

                match = new Match(6, team3, 30, team2, 29, new Badminton());

                matches.Add(match);
            }
            else if (tournamentId == 4)
            {
                Team team1 = new Team(1, "Team1");
                Team team2 = new Team(2, "Team2");
                Team team3 = new Team(3, "Team3");
                Team team4 = new Team(4, "Team4");

                Match match = null;

                match = new Match(1, team1, 9, team3, 21, new Badminton());

                matches.Add(match);

                match = new Match(2, team2, 33, team4, 35, new Badminton());

                matches.Add(match);

                match = new Match(3, team1, 22, team2, 24, new Badminton());

                matches.Add(match);

                match = new Match(4, team4, 30, team3, 29, new Badminton());

                matches.Add(match);

                match = new Match(5, team1, 21, team4, 6, new Badminton());

                matches.Add(match);

                match = new Match(6, team3, 21, team2, 9, new Badminton());

                matches.Add(match);
            }
            else if (tournamentId == 5)
            {
                Team team1 = new Team(1, "Team1");
                Team team2 = new Team(2, "Team2");
                Team team3 = new Team(3, "Team3");

                Match match = null;

                match = new Match(1, team1, 9, team3, 21, new Badminton());

                matches.Add(match);

                match = new Match(2, team2, null, null, null, new Badminton());

                matches.Add(match);

                match = new Match(3, team1, 22, team2, 24, new Badminton());

                matches.Add(match);

                match = new Match(4, null, null, team3, null, new Badminton());

                matches.Add(match);

                match = new Match(5, team1, null, null, null, new Badminton());

                matches.Add(match);

                match = new Match(6, team3, 21, team2, 9, new Badminton());

                matches.Add(match);
            }
            else if (tournamentId == 6) 
            {

                Team teamAwayBadminton = new Team("TeamAwayBadminton");
                Team teamHomeBadminton = new Team("teamHomeBadminton");

                matches.Add(new Match(2, teamAwayBadminton, null, teamHomeBadminton, null, new Badminton()));
            }
        }


        public List<Match> GetMatches()
        {
            return matches;
        }

        public Match GetMatchById(int matchId)
        {
            foreach (Match match in matches)
            {
                if (match.Id == matchId)
                {
                    return match;
                }
            }
            return null;
        }

        public List<Team> GetParticipants()
        {
            return teams;
        }

        public List<Match> GetTwelveMatchesPerPage(int pageNumber)
        {
            throw new System.NotImplementedException();
        }

        public void InsertMatches(List<Match> matches)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterResults(Match updatedMatch)
        {
            matches.RemoveAt(GetMatchIndex(updatedMatch.Id));
            matches.Add(new Match(updatedMatch.Id, updatedMatch.TeamAway, updatedMatch.ScoreTeamAway, updatedMatch.TeamHome, updatedMatch.ScoreTeamHome, updatedMatch.SportType));
        }

        private int GetMatchIndex(int id)
        {
            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void AddTeam(Team addedTeam)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveTeam(Team removedTeam)
        {
            throw new System.NotImplementedException();
        }
    }
}
