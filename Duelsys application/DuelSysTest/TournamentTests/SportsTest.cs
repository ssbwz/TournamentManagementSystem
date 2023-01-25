using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Exceptions;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using DuelSysTest.MockReposistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuelSysTest.TournamentTests
{
    [TestClass]
    public class SportsTest
    {
        private const int PING_PONG_MATCH_ID = 1;
        private const int BADMINTON_MATCH_ID = 2;
        private const int PING_PONG_TOURNAMENT_ID = 1;
        private const int BADMINTON_TOURNAMENT_ID = 6;

        private Tournament PingPongTounament; 

        private Tournament BadmintonTournament;
        private IAssociationRepository repository;
        private Association association;

        public SportsTest()
        {
            repository = new MockAssociationRepository(1);
            association = new Association(1,"TestAssociation",repository);
            PingPongTounament = association.GetTournamentById(PING_PONG_TOURNAMENT_ID);
            BadmintonTournament = association.GetTournamentById(BADMINTON_TOURNAMENT_ID);
        }

        /*Ping Pong tests*/

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is -1 for team away and 7 for team home")]
        public void RegisteringResultsForPinPongWithValueLessThanZero()
        {
            //Arrange

            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
            
            match.ScoreTeamAway = -1;
            match.ScoreTeamHome = 7;
            //Act
            Team winner = match.Winner;

        }

        [TestMethod]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithZeroForAteamAndOtherTeamSeven()
        {
            //Arrange

            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 0;
            match.ScoreTeamHome = 7;
            //Act
            PingPongTounament.RegisterResults(match);

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 0 for team away and 7 for team home");

        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 6 for team away and 0 for team home")]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithZeroForAteamAndOtherTeamSix()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);

            match.ScoreTeamAway = 6;
            match.ScoreTeamHome = 0;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 7 for team away and 3 for team home")]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithSevenForAteamAndOtherTeamThree()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);

            match.ScoreTeamAway = 7;
            match.ScoreTeamHome = 3;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithEightForAteamAndOtherTeamEleven()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 8;
            match.ScoreTeamHome = 11;
            //Act
            PingPongTounament.RegisterResults(match);

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 8 for team away and 11 for team home");
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 10 for team away and 11 for team home")]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithTenForAteamAndOtherTeamEleven()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
      
            match.ScoreTeamAway = 10;
            match.ScoreTeamHome = 11;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 7 for team away and 9 for team home")]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithSevenATeamAndTheOtherTeamhasNine()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);

            match.ScoreTeamAway = 7;
            match.ScoreTeamHome = 9;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithTenForAteamAndOtherTeamTwelve()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 10;
            match.ScoreTeamHome = 12;
            //Act
            PingPongTounament.RegisterResults(match);

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 10 for team away and 12 for team home");
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 14 for team away and 15 for team home")]
        public void RegisteringResultsForPinPongWhenTheMatchsEndWithTheMoreThan11ForATeamAndTheOtherTeamhasMoreThan1point()
        {
            //Arrange
            Match match = PingPongTounament.GetSelectedMatch(PING_PONG_MATCH_ID);
            match.ScoreTeamAway = 14;
            match.ScoreTeamHome = 15;
            //Act
            Team winner = match.Winner;
        }


        /*Badminton tests*/

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is -1 for team away and 21 for team home")]
        public void RegisteringResultsForBadmintonWithValueLessThanZero()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
            
            match.ScoreTeamAway = -1;
            match.ScoreTeamHome = 21;
            //Act
            Team winner = match.Winner;

        }

        [TestMethod]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithZeroForAteamAndOtherTeamtwentyOne()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 0;
            match.ScoreTeamHome = 21;
            //Act
            Team Winner = match.Winner;

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 0 for team away and 21 for team home");

        }

        [TestMethod]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithFiveForAteamAndOtherTeamtwentyOne()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 5;
            match.ScoreTeamHome = 21;
            //Act
            Team Winner = match.Winner;

            //Assert
            Assert.AreEqual(teamHome.Id, Winner.Id, "It doesn't get the winner in when the results is 5 for team away and 21 for team home");

        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 10 for team away and 12 for team home")]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTenForAteamAndOtherTeamTwelve()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);

            match.ScoreTeamAway = 10;
            match.ScoreTeamHome = 12;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 20 for team away and 20 for team home")]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyForAteamAndOtherTeamTwenty()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
           
            match.ScoreTeamAway = 20;
            match.ScoreTeamHome = 20;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyTwoForAteamAndOtherTeamTwenty()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 22;
            match.ScoreTeamHome = 20;
            //Act
            Team winner = match.Winner;

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 22 for team away and 20 for team home");

        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 20 for team away and 21 for team home")]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyForAteamAndOtherTeamTwentyOne()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);

            match.ScoreTeamAway = 20;
            match.ScoreTeamHome = 21;
            //Act
            Team winner = match.Winner;
        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 20 for team away and 24 for team home")]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyForAteamAndOtherTeamTwentyFour()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);

            match.ScoreTeamAway = 20;
            match.ScoreTeamHome = 24;
            //Act
            Team winner = match.Winner;
        }


        [TestMethod]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyNineForAteamAndOtherTeamThirty()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);
            Team teamHome = match.TeamHome;
            match.ScoreTeamAway = 30;
            match.ScoreTeamHome = 29;
            //Act
            Team winner = match.Winner;

            //Assert
            Assert.AreEqual(teamHome.Id, match.Winner.Id, "It doesn't get the winner in when the results is 30 for team away and 29 for team home");

        }

        [TestMethod]
        [ExpectedException(typeof(WrongScoringException), "It doesn't throw WrongScoringException when the results is 29 for team away and 29 for team home")]
        public void RegisteringResultsForBadmintonWhenTheMatchsEndWithTwentyNineForAteamAndOtherTeamTwentyNine()
        {
            //Arrange

            Match match = BadmintonTournament.GetSelectedMatch(BADMINTON_MATCH_ID);

            match.ScoreTeamAway = 29;
            match.ScoreTeamHome = 29;
            //Act
            Team winner = match.Winner;
        }

    }
}
