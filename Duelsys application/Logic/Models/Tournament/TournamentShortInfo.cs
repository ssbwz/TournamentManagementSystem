using DuelSysLogic.Interfaces;
using DuelSysLogic.Models.Sports;
using System.ComponentModel.DataAnnotations;

namespace DuelSysLogic.Models.TournamentModels
{
    public class TournamentShortInfo
    {

        public TournamentShortInfo(int id,string title, ITournamentSystem tournamentSystem, Sport sportType, int participantsNum)
        {
            this.Id = id;
            this.Title = title;
            this.TournamentSystem = tournamentSystem;
            this.SportType = sportType;
            this.ParticipantsNum = participantsNum;
        }

        public TournamentShortInfo(int id, string title, ITournamentSystem tournamentSystem, Sport sportType)
        {
            this.Id = id;
            this.Title = title;
            this.TournamentSystem = tournamentSystem;
            this.SportType = sportType;
        }

        public TournamentShortInfo(string title, ITournamentSystem tournamentSystem, Sport sportType)
        {
            this.Title = title;
            this.TournamentSystem = tournamentSystem;
            this.SportType = sportType;
        }

        public int Id { get; private set; }
      
        public string Title { get; private set; }

        public Sport SportType { get; private set; }

        public ITournamentSystem TournamentSystem { get; private set; }

        public int ParticipantsNum { get; private set; }

    }
}
