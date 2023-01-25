using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Exceptions;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.Sports
{
    public class PingPong : Sport
    {
        private const int MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN = 11;
        private const int MIN_Points = 0;
        private const int MIN_SCORE_TO_WIN = 7;

        public override Team GetWinner(Match match)
        {
            int scoreTeamAway = 0;
            int scoreTeamHome = 0;

            if (IsScoreValide(match.ScoreTeamAway, match.ScoreTeamHome))
            {
                scoreTeamAway = (int)match.ScoreTeamAway;
                scoreTeamHome = (int)match.ScoreTeamHome;
            }
            if (scoreTeamHome > scoreTeamAway)
            {
                return match.TeamHome;
            }
            if (scoreTeamHome < scoreTeamAway)
            {
                return match.TeamAway;
            }

            throw new SettingWinnerException("Couldn't set winner");
        }

        protected override bool IsScoreValide(int? teamAwayPoint, int? teamHomePoint)
        {

            if (!IscScoreLessThanZero())
            {
                throw new WrongScoringException("Wrong scoring");
            }
            else if (IsScoreMinimum()) 
            {
                return true;
            }
            else if (IsScoreMoreThanMinimum())
            {
                return true;
            }
            else if (IsScoresOver11AndTheOtherScoreIsLessByTwo())
            {
                return true;
            }


            throw new WrongScoringException("Wrong scoring");

            bool IscScoreLessThanZero()
            {
                if (teamAwayPoint >= MIN_Points && teamHomePoint >= MIN_Points) 
                {
                    return true;
                }
                return false;
            }
            bool IsScoreMinimum()
            {
                if (teamHomePoint <= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN && teamAwayPoint <= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN) {
                    if (teamAwayPoint == MIN_SCORE_TO_WIN && teamHomePoint == MIN_Points || teamHomePoint == MIN_SCORE_TO_WIN && teamAwayPoint == MIN_Points)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool IsScoreMoreThanMinimum() 
            {
                if (teamHomePoint <= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN && teamAwayPoint <= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN) {

                    //When the point is 10 ,11 the system should player who has 11 should get one more to win 
                    if (teamHomePoint == 10 && teamAwayPoint == MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN || teamAwayPoint == 10 && teamHomePoint == MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN)    
                    {
                        return false;
                    }
                    else if (teamAwayPoint > MIN_Points && teamHomePoint == MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN || teamHomePoint > MIN_Points && teamAwayPoint == MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool IsScoresOver11AndTheOtherScoreIsLessByTwo() 
            {
                if (teamAwayPoint > MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN || teamHomePoint > MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_REACHES_TEN) {
                    if (teamHomePoint - 2 == teamAwayPoint || teamHomePoint  == teamAwayPoint - 2)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public override string ToString()
        {
            return "Ping Pong";
        }
    }
}
