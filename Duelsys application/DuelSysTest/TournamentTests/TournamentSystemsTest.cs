using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using DuelSysTest.MockReposistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DuelSysLogic.Exceptions.TouranmentsSystems;
using DuelSysLogic.Interfaces;

namespace DuelSysTest.TournamentTests
{
    [TestClass]
    public class TournamentSystemsTest
    {
        private const int TOURNAMENT_HAS_NO_SCHEDULE_CREATED = 1;

        private IAssociationRepository repository;
        private Association association;
        private Tournament tournament;

        public TournamentSystemsTest() 
        {
            repository = new MockAssociationRepository(1);
            association = new Association(1,"AssocaitionTest",repository);
        }

        [TestMethod]
        public void CreatingRoundRobinWithEvenParticipants()
        {
            //Arrange
            tournament = association.GetTournamentById(TOURNAMENT_HAS_NO_SCHEDULE_CREATED);
            List<Team> teams = tournament.GetParticipants();
            teams.RemoveRange(teams.Count - 1, 1);

            //Act
            List<Match> genertedMatches = tournament.TournamentShortInfo.TournamentSystem.GenerateSchedule(teams);

            //Assert
            Match[] excpectedMatches =  {
                new Match(new Team(3, "Team3"),new Team(4, "Team4")),
                 new Match(new Team(1, "Team1"),new Team(2, "Team2")),
                  new Match(new Team(4, "Team4"),new Team(2, "Team2")),
                  new Match(new Team(1, "Team1"),new Team(3, "Team3")),
                  new Match(new Team(2, "Team2"),new Team(3, "Team3")),
                  new Match(new Team(1, "Team1"),new Team(4, "Team4")),
                   };

            Assert.IsTrue(IsListsEqual(genertedMatches.ToArray(), excpectedMatches), "The round robin generater doesn't generate as excpeted list when number of participants is even");
        }

        [TestMethod]
        public void CreatingRoundRobinWithOddParticipants()
        {
            //Arrange        
            tournament = association.GetTournamentById(TOURNAMENT_HAS_NO_SCHEDULE_CREATED);
            List<Team> teams = tournament.GetParticipants();

            //Act
            List<Match> genertedMatches = tournament.TournamentShortInfo.TournamentSystem.GenerateSchedule(teams);
            //Assert
            Match[] excpectedMatches =  {
                new Match(null,new Team(4, "Team4")),
                new Match(new Team(3, "Team3"),new Team(5, "Team5")),
                new Match(new Team(1, "Team1"),new Team(2, "Team2")),
                new Match(new Team(4, "Team4"),new Team(5, "Team5")),
                new Match(null,new Team(2, "Team2")),
                new Match(new Team(1, "Team1"),new Team(3, "Team3")),
                new Match(new Team(5, "Team5"),new Team(2, "Team2")),
                new Match(new Team(4, "Team4"),new Team(3, "Team3")),
                new Match(new Team(1, "Team1"),null),
                new Match(new Team(2, "Team2"),new Team(3, "Team3")),
                new Match(new Team(5, "Team5"),null),
                new Match(new Team(1, "Team1"),new Team(4, "Team4")),
                new Match(new Team(3, "Team3"),null),
                new Match(new Team(2, "Team2"),new Team(4, "Team4")),
                new Match(new Team(1, "Team1"),new Team(5, "Team5")),
                   };

            Assert.IsTrue(IsListsEqual(genertedMatches.ToArray(), excpectedMatches), "The round robin generater doesn't generate as excpeted list when number of participants is odd");
        }

        [TestMethod]
        [ExpectedException(typeof(GeneratingScheduleException), "It does generate schedule when the participant number is one")]
        public void CreatingRoundRobinWithlessThanThreeParticipants()
        {
            //Arrange
            List<Team> teams = new List<Team>();
            tournament = association.GetTournamentById(TOURNAMENT_HAS_NO_SCHEDULE_CREATED);

            for (int i = 0; i < 2; i++)
            {
                teams.Add(new Team(i, $"Team{i}"));
            }

            //Act
             tournament.TournamentShortInfo.TournamentSystem.GenerateSchedule(teams);
        }

        [TestMethod]
        [ExpectedException(typeof(GeneratingScheduleException), "It does generate schedule when the participant number is 64")]
        public void CreatingRoundRobinWithlessThanSixtyFourParticipants()
        {
            //Arrange
            List<Team> teams = new List<Team>();
            tournament = association.GetTournamentById(TOURNAMENT_HAS_NO_SCHEDULE_CREATED);

            for (int i = 0; i < 65; i++) 
            {
                teams.Add(new Team(i,$"Team{i}"));
            }
         
            //Act
            tournament.TournamentShortInfo.TournamentSystem.GenerateSchedule(teams);
        }

        private bool IsListsEqual(Match[] listA, Match[] listB)
        {
            if (listA == null || listA.Length == 0 || listB == null || listB.Length == 0)
            {
                return false;
            }
            if (listA.Length != listB.Length)
            {
                return false;
            }

            for (int i = 0; i < listA.Length; i++)
            {
                if (listA[i] == null && listB[i] != null && listA[i] != null && listB[i] == null)
                {
                    return false;
                }

                if (bothNullOrNotNull(listA[i].TeamAway, listA[i].TeamHome))
                {
                    if (bothNotNull(listA[i].TeamAway, listB[i].TeamAway))
                    {
                        if (!sameId(listA[i].TeamAway, listB[i].TeamAway))
                        {
                            return false;
                        }
                    }
                }
                if (bothNullOrNotNull(listA[i].TeamHome, listA[i].TeamHome))
                {
                    if (bothNotNull(listA[i].TeamHome, listB[i].TeamHome))
                    {
                        if (!sameId(listA[i].TeamHome, listB[i].TeamHome))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;

            bool bothNullOrNotNull(object objectA, object objectB)
            {
                if (objectA == null && objectB == null || objectA != null && objectB != null)
                {
                    return true;
                }
                return false;
            }
            bool bothNotNull(object objectA, object objectB)
            {
                if (objectA != null && objectB != null)
                {
                    return true;
                }
                return false;
            }
            bool sameId(Team teamA, Team teamB)
            {
                if (teamA.Id == teamB.Id)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
