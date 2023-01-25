using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Exceptions;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.Sports
{
    public class Badminton : Sport
    {
        private const int MIN_SCORE_TO_WIN = 21;
        private const int MIN_POINTS = 0;
        private const int MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_HAS_TO_GET_TWO_POINTS = 20;
        private const int SCORE_BEFORE_GOLDEN_GOAL = 29;

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

        public override string ToString()
        {
            return "Badminton";
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
            else if (IsScoresOver11AndTheOtherScoreIsLessByTwo())
            {
                return true;
            }

            throw new WrongScoringException("Wrong scoring");


            bool IscScoreLessThanZero()
            {
                if (teamAwayPoint >= MIN_POINTS && teamHomePoint >= MIN_POINTS)
                {
                    return true;
                }
                return false;
            }
            bool IsScoreMinimum()
            {
                if (teamAwayPoint != MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_HAS_TO_GET_TWO_POINTS && teamHomePoint != MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_HAS_TO_GET_TWO_POINTS)
                {
                    if (teamHomePoint <= MIN_SCORE_TO_WIN && teamAwayPoint == MIN_SCORE_TO_WIN || teamAwayPoint <= MIN_SCORE_TO_WIN && teamHomePoint == MIN_SCORE_TO_WIN)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool IsScoresOver11AndTheOtherScoreIsLessByTwo()
            {
                if (teamAwayPoint == SCORE_BEFORE_GOLDEN_GOAL || teamHomePoint == SCORE_BEFORE_GOLDEN_GOAL)
                {
                    if (teamAwayPoint - 1 == SCORE_BEFORE_GOLDEN_GOAL || teamHomePoint - 1 == SCORE_BEFORE_GOLDEN_GOAL)
                    {
                        return true;
                    }
                }

                if (teamAwayPoint >= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_HAS_TO_GET_TWO_POINTS && teamHomePoint >= MAX_SCORE_BEFORE_BOTH_OF_THE_TEAMS_HAS_TO_GET_TWO_POINTS)
                {
                    if (teamHomePoint - 2 == teamAwayPoint || teamHomePoint == teamAwayPoint - 2)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
