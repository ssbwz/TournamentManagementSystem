using DataAccess;
using DataAccess.ExceptionModels;
using DataAccess.TournamentManagement;
using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages.Tournaments
{
    [AllowAnonymous]
    public class TournamentModel : PageModel
    {
        private Association association;

        private IAssociationsRepository associationsRepository;
        private AssociationsManager associationsManager;

        internal Tournament ShownTournament { get; private set; }

        internal List<Match> TournamentMatches { get; private set; }

        internal bool CanRegister { get; private set; }
        internal bool HasMatches { get; private set; }
        internal bool IsTournamentCancelled { get; private set; }

        private int playerId { get { return Convert.ToInt32(User.FindFirst("playerId").Value); } }
        private string playerUsername { get { return User.FindFirst("username").Value.ToString(); } }

        internal string MessageTitle { get; private set; }

        internal string MessageDescription { get; private set; }

        //when player register player can see this page only and can't see others tournaemnt from other associations if send to access denide 
        //the parameter of this Onget should take the tournament id
        public IActionResult OnGet(int id)
        {
            try
            {
                associationsRepository = new AssociationsDAL();
                associationsManager = new AssociationsManager(associationsRepository);

                association = associationsManager.GetAssociation(1); 

                ShownTournament = association.GetTournamentById(id);

                TournamentMatches = ShownTournament.GetAllMatches();

                if (TournamentMatches != null) 
                {
                    HasMatches = true;
                }


                if (ShownTournament.StartDate > DateTime.Now.AddDays(7) && ShownTournament.TournamentShortInfo.ParticipantsNum < ShownTournament.Requirement.MaxPlayers && TournamentMatches == null)
                {
                    CanRegister = true;
                }
                else if (ShownTournament.TournamentShortInfo.ParticipantsNum == ShownTournament.Requirement.MaxPlayers)
                {
                    CanRegister = false;
                }
                else if(!HasMatches)
                {
                    IsTournamentCancelled = true;
                }
            }
            catch (Exception)
            {
                return Redirect($"../Error");
            }
            return Page();
        }

        public IActionResult OnPostRegister(int tournamentId)
        {

            try
            {
                //ToDo: make association choose
                associationsRepository = new AssociationsDAL();
                associationsManager = new AssociationsManager(associationsRepository);

                association = associationsManager.GetAssociation(1);

                Tournament selectedTournament = association.GetTournamentById(tournamentId);

                Team addedTeam = new Team(playerId, playerUsername);
                selectedTournament.AddTeam(addedTeam);

                MessageTitle = "Info";
                MessageDescription = $"You got registered.";
            }
            catch (TeamAlreadyRegisteredException ex)
            {
                MessageTitle = "Info";
                MessageDescription = $"{ex.Message}.";
            }
            catch (Exception)
            {
                return Redirect($"../Error");
            }

            ShownTournament = association.GetTournamentById(tournamentId);



            if (ShownTournament.StartDate > DateTime.Now.AddDays(7) && ShownTournament.TournamentShortInfo.ParticipantsNum < ShownTournament.Requirement.MaxPlayers)
            {
                CanRegister = true;
            }
            else if (ShownTournament.TournamentShortInfo.ParticipantsNum == ShownTournament.Requirement.MaxPlayers)
            {
                CanRegister = false;
            }
            else
            {
                IsTournamentCancelled = true;
            }


            return Page();
        }
    }
}
