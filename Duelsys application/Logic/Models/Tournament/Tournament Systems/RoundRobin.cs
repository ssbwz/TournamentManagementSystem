using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Exceptions.TouranmentsSystems;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.Tournament.Tournament_Systems
{
    public class RoundRobin : ITournamentSystem
    {

        public List<Match> GenerateSchedule(List<Team> enteredParticipants)
        {
            if (enteredParticipants.Count < 3) 
            {
                throw new GeneratingScheduleException("The number of participants is less than 3");
            }
            else if(enteredParticipants.Count > 64) 
            {
                throw new GeneratingScheduleException("The number of participants is more than 64");
            }

            List<Match> matches = new List<Match>();
            List<Team> groupA = new List<Team>();
            List<Team> groupB = new List<Team>();

            int halfParticipantsSize = enteredParticipants.Count / 2;
            int requiredNumOfMatches = getRequiredNumberOfMatches(enteredParticipants.Count);

            sepertaingTeam();

            for (int i = 0; i < enteredParticipants.Count; i++)
            {
                addingNewMatches();

                if (matches.Count == requiredNumOfMatches)
                {
                    matches.Reverse();
                    return matches;
                }

                applyingCircleMethod();
            }
            return matches;

            void sepertaingTeam() 
            {
                if (enteredParticipants.Count % 2 == 0)
                {
                    groupA.AddRange(enteredParticipants.Take(halfParticipantsSize));
                    groupB.AddRange(enteredParticipants.Skip(halfParticipantsSize).Take(halfParticipantsSize).Reverse());
                }
                else
                {
                    groupA.AddRange(enteredParticipants.Take(halfParticipantsSize + 1));
                    groupB.AddRange(enteredParticipants.Skip(halfParticipantsSize + 1).Take(halfParticipantsSize).Reverse());
                    groupB.Add(new Team(0, "team0"));
                }
            }
            void addingNewMatches()
            {
                for (int participantCount = 0; participantCount < groupA.Count; participantCount++)
                {
                    matches.Add(new Match(groupA[participantCount].Id == 0 ? null:groupA[participantCount],groupB[participantCount].Id == 0?null: groupB[participantCount]));
                }
            }
            void applyingCircleMethod()
            {
                groupA.Insert(1, groupB[0]);
                groupB.RemoveAt(0);
                groupB.Insert(groupB.Count, groupA[groupA.Count - 1]);
                groupA.RemoveAt(groupA.Count - 1);
            }
            int getRequiredNumberOfMatches(int participantsNumber)
            {
                if (participantsNumber % 2 == 0)
                {
                    return participantsNumber / 2 * (participantsNumber - 1);
                }
                else
                {
                    participantsNumber++;
                    return participantsNumber / 2 * (participantsNumber - 1);
                }
            }
        }

        public override string ToString()
        {
            return "Round Robin";
        }
    }
}
