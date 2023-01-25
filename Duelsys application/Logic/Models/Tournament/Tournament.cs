using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Tournament.TournamentDetails;
using System.ComponentModel.DataAnnotations;

namespace DuelSysLogic.Models.TournamentModels
{
    public partial class Tournament
    {
        public Tournament(TournamentShortInfo tournamentShorInfo, string description, Location location, Requirement requirement, DateTime startDate, DateTime endDate)
        {
            this.TournamentShortInfo = tournamentShorInfo;
            this.Description = description;
            this.Location = location;
            this.Requirement = requirement;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Tournament(TournamentShortInfo tournamentShorInfo, string description, Location location, Requirement requirement, DateTime startDate, DateTime endDate,ITournamentRepository repository)
        {
            this.TournamentShortInfo = tournamentShorInfo;
            this.Description = description;
            this.Location = location;
            this.Requirement = requirement;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.repository = repository;
        }

        public TournamentShortInfo TournamentShortInfo { get; set; }

        public string Description { get; private set; }

        public Requirement Requirement { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public Location Location { get; private set; }

        public Team? GoldenMedalTeam { get; set; }

        public Team? BronzeMedalTeam { get; set; }

        public Team? SilverMedalTeam { get; set; }
    }
}
