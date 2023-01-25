using DuelSysLogic.Managers.TournamentManager;
using DuelSysLogic.Models.TournamentModels;
using DuelSysTest.MockReposistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Managers;
using DuelSysLogic.Exceptions.TouranmentsSystems;
using DuelSysLogic.Interfaces;

namespace DuelSysTest.TournamentTests
{
    [TestClass]
    public class TiesTest
    {
        private const int TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_DEFERENT_NUMBER_OF_WINES = 2;
        private const int TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_TWO_HAS_SAME_NUMBER_OF_WINES = 3;
        private const int TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_TWO_HAS_SAME_NUMBER_OF_WINES_AND_SAME_TOTAL_WINES = 4;
        private const int TOURNAMENT_HAS_ROUND_ROBIN_SCHEDULE_WITH_BYE = 5;


        private IAssociationRepository repository;
        private Association association;

        public TiesTest()
        {
            repository = new MockAssociationRepository(1);
            association = new Association(1,"TestAssocaition",repository);
        }


        [TestMethod]
        public void GetTopThreeWinnersWithDeferentNumberOfWins()
        {
            //Arrange
            Tournament tournament = association.GetTournamentById(TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_DEFERENT_NUMBER_OF_WINES);
            List<Match> finishedTournamentSchedule = tournament.GetAllMatches();

            //Act
            List<Team> resultTeams = TiesHandler.GetTopThree(finishedTournamentSchedule);
            //Assert
            Team[] expected = {new Team(4, "Team4"),new Team(3, "Team3"), new Team(2, "Team2") };

            Assert.IsTrue(IsListsEqual(expected, resultTeams.ToArray()), "It doesn't match the expected Teams with deferent scores");
            
        }

        [TestMethod]
        public void GetTopThreeWinnersWithTwoWithSamesNumberOfWines()
        {
            //Arrange
            Tournament tournament = association.GetTournamentById(TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_TWO_HAS_SAME_NUMBER_OF_WINES);
            List<Match> finishedTournamentSchedule = tournament.GetAllMatches();

            //Act
            List<Team> resultTeams = TiesHandler.GetTopThree(finishedTournamentSchedule);
            //Assert
            Team[] expected = { new Team(3, "Team3") ,new Team(4, "Team4"), new Team(2, "Team2") };

            Assert.IsTrue(IsListsEqual(expected, resultTeams.ToArray()), "It doesn't match the expected Teams with two teams got same number of wins");

        }

        [TestMethod]
        public void GetTopThreeWinnersWithByeInSchedule()
        {
            //Arrange
            Tournament tournament = association.GetTournamentById(TOURNAMENT_HAS_ROUND_ROBIN_SCHEDULE_WITH_BYE);
            List<Match> finishedTournamentSchedule = tournament.GetAllMatches();

            //Act
            List<Team> resultTeams = TiesHandler.GetTopThree(finishedTournamentSchedule);
            //Assert
            Team[] expected = { new Team(3, "Team3"),new Team(2, "Team2") , new Team(1, "Team1") };

            Assert.IsTrue(IsListsEqual(expected, resultTeams.ToArray()), "It doesn't match the expected Teams with deferent scores");

        }

        [TestMethod]
        [ExpectedException(typeof(HandleTiesException), "It doesn't throw HandleTiesException when the matches list is empty or null")]
        public void GetTopThreeWinnersWithEmptyList()
        {
            //Arrange
            List<Match> finishedTournamentSchedule = new List<Match>();

            //Act
            TiesHandler.GetTopThree(finishedTournamentSchedule);
        }

        [TestMethod]
        [ExpectedException(typeof(HandleTiesException), "It doesn't throw HandleTiesException when number of wins is the same and total point is the same")]
        public void GetTopThreeWinnersWithTwoTeamsHasSameNumberOfWinnesAndSameNumberOfTotalPoints()
        {
            //Arrange
            Tournament tournament = association.GetTournamentById(TOURNAMENT_HAS_SCHEDULE_CREATED_WITH_TWO_HAS_SAME_NUMBER_OF_WINES_AND_SAME_TOTAL_WINES);
            List<Match> finishedTournamentSchedule = tournament.GetAllMatches();

            //Act
             TiesHandler.GetTopThree(finishedTournamentSchedule);
        }

        private bool IsListsEqual(Team[] listA, Team[] listB)
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

            if (bothNullOrNotNull(listA[i], listA[i]))
            {
                if (bothNotNull(listA[i], listB[i]))
                {
                    if (!sameId(listA[i], listB[i]))
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
