using DuelSysLogic.Interfaces;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Models.Sports;
using DuelSysLogic.Models.Tournament.Tournament_Systems;
using DuelSysLogic.Models.Tournament.TournamentDetails;
using DuelSysLogic.Models.TournamentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysTest.MockReposistory
{
    internal class MockAssociationRepository : IAssociationRepository
    {
        private List<Tournament> tournaments;
        public MockAssociationRepository(int associaitonId)
        {
            tournaments = new List<Tournament>();
            if (associaitonId == 1)
            {
                #region first Tournament
                TournamentShortInfo shortInfo = new TournamentShortInfo(1,"TestTournament", new RoundRobin(), new PingPong());
                string description = "Test Tounament";
                Location location = new Location("Street coolblue", "15", "1324 AB");
                Requirement requirement = new Requirement(2, 4);
                DateTime startTime = new DateTime(2022, 12, 10);
                DateTime endTime = new DateTime(2022, 12, 20);
                ITournamentRepository repostitory = new MockTournamentRepository(shortInfo.Id);

                tournaments.Add(new Tournament(shortInfo, description, location, requirement, startTime, endTime, repostitory));
                #endregion

                #region second tournament
                TournamentShortInfo shortInfo2 = new TournamentShortInfo(2,"TestTournament2", new RoundRobin(), new PingPong());
                string description2 = "Test Tounament2";
                Location location2 = new Location("Street coolblue2", "15", "1324 AB");
                Requirement requirement2 = new Requirement(2, 4);
                DateTime startTime2 = new DateTime(2022, 12, 10);
                DateTime endTim2 = new DateTime(2022, 12, 20);
                ITournamentRepository repository2 = new MockTournamentRepository(shortInfo2.Id);
                tournaments.Add(new Tournament(shortInfo2, description2, location2, requirement2, startTime2, endTim2, repository2));
                #endregion

                #region Third tournament
                TournamentShortInfo shortInfo3 = new TournamentShortInfo(3,"TestTournament3", new RoundRobin(), new PingPong(), 3);
                string description3 = "Test Tounament3";
                Location location3 = new Location("Street coolblue3", "15", "1324 AB");
                Requirement requirement3 = new Requirement(2, 4);
                DateTime startTime3 = new DateTime(2022, 12, 10);
                DateTime endTime3 = new DateTime(2022, 12, 20);
                ITournamentRepository repository3 = new MockTournamentRepository(shortInfo3.Id);
                tournaments.Add(new Tournament(shortInfo3, description3, location3, requirement3, startTime3, endTime3, repository3));
                #endregion

                #region Fourth tournament
                TournamentShortInfo shortInfo4 = new TournamentShortInfo(4,"TestTournament4", new RoundRobin(), new PingPong(), 4);
                string description4 = "Test Tounament4";
                Location location4 = new Location("Street coolblue4", "15", "1324 AB");
                Requirement requirement4 = new Requirement(2, 4);
                DateTime startTime4 = new DateTime(2022, 12, 10);
                DateTime endTime4 = new DateTime(2022, 12, 20);
                ITournamentRepository repository4 = new MockTournamentRepository(shortInfo4.Id);
                tournaments.Add(new Tournament(shortInfo4, description4, location4, requirement4, startTime4, endTime4, repository4));
                #endregion

                #region Fifth tournament
                TournamentShortInfo shortInfo5 = new TournamentShortInfo(5,"TestTournament5", new RoundRobin(), new PingPong(), 5);
                string description5 = "Test Tounament5";
                Location location5 = new Location("Street coolblue5", "15", "1324 AB");
                Requirement requirement5 = new Requirement(2, 4);
                DateTime startTime5 = new DateTime(2022, 12, 10);
                DateTime endTime5 = new DateTime(2022, 12, 20);
                ITournamentRepository repository5 = new MockTournamentRepository(shortInfo5.Id);
                tournaments.Add(new Tournament(shortInfo5, description5, location5, requirement5, startTime5, endTime5, repository5));
                #endregion

                #region Sixth tournament
                TournamentShortInfo shortInfo6 = new TournamentShortInfo(6, "TestTournament5", new RoundRobin(), new PingPong(), 5);
                string description6 = "Test Tounament6";
                Location location6 = new Location("Street coolblue6", "15", "1324 AB");
                Requirement requirement6 = new Requirement(2, 4);
                DateTime startTime6 = new DateTime(2022, 12, 10);
                DateTime endTime6 = new DateTime(2022, 12, 20);
                ITournamentRepository repository6 = new MockTournamentRepository(shortInfo6.Id);
                tournaments.Add(new Tournament(shortInfo6, description6, location6, requirement6, startTime6, endTime6, repository6));
                #endregion
            }
        }

        public void CreateTournament(Tournament newTournament)
        {
            throw new NotImplementedException();
        }

        public void DeleteTournament(TournamentShortInfo deletedTournament)
        {
            throw new NotImplementedException();
        }

        public List<TournamentShortInfo> GetEightTournamentShortInfoEachTime(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public List<TournamentShortInfo> GetThreeTournamentShortInfoEachTime(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Tournament GetTournamentById(int tournamentId)
        {
            foreach (Tournament tournament in tournaments)
            {
                if (tournament.TournamentShortInfo.Id == tournamentId)
                {
                    return tournament;
                }
            }
            return null;
        }

        public void UpdateMedals(Tournament updatedTournament)
        {
            throw new NotImplementedException();
        }

        public void UpdateTournament(Tournament updatedTournament)
        {
            throw new NotImplementedException();
        }
    }
}
