using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DuelSysLogic.Interfaces;
using DataAccess;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using Microsoft.AspNetCore.Authorization;

namespace DuelSysWebsite.Pages.Tournaments
{
    [AllowAnonymous]
    public class TournamentsModel : PageModel
    {
        private Association association;
        private AssociationsDAL associationsRepository;
        private AssociationsManager associationsManager;

        public List<TournamentShortInfo> TournamentShortInfos { get; private set; }


        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; }

        public IActionResult OnGet(int associationId)
        {
            try
            {
                //ToDo: make association choose
                associationsRepository = new AssociationsDAL();
                associationsManager = new AssociationsManager(associationsRepository);

                association = associationsManager.GetAssociation(1);

                PageNumber = PageNumber == 0 ? 1 : PageNumber;

                TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(PageNumber);

            }
            catch (Exception)
            {
                return Redirect($"../Error");
            }
            return Page();
        }

        public IActionResult OnPostNextPage(int pageNumber)
        {
            try
            {
                //ToDo: make association choose
                associationsRepository = new AssociationsDAL();
                associationsManager = new AssociationsManager(associationsRepository);

                association = associationsManager.GetAssociation(1);



                PageNumber = pageNumber + 1;
                PageNumber = PageNumber == 0 ? 1 : PageNumber;

                TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(PageNumber);
                if (TournamentShortInfos == null ||TournamentShortInfos.Count == 0 )
                {
                    TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(--PageNumber);
                    return Page();
                }
                return Page();

            }

            catch (Exception)
            {
                return Redirect($"../Error");
            }
            return Page();
        }

        public IActionResult OnPostPreviousPage(int pageNumber)
        {
            try
            {
                associationsRepository = new AssociationsDAL();
                associationsManager = new AssociationsManager(associationsRepository);

                association = associationsManager.GetAssociation(1);

                if (TournamentShortInfos == null)
                {
                    TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(PageNumber);
                    return Page();
                }
                //ToDo: make association choose


                PageNumber = pageNumber - 1;
                PageNumber = PageNumber <= 0 ? 1 : PageNumber;

                TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(PageNumber);
                if (TournamentShortInfos == null || TournamentShortInfos.Count == 0)
                {
                    TournamentShortInfos = association.GetThreeTournamentShortInfoEachTime(--PageNumber);
                    return Page();
                }
                return Page();

            }

            catch (Exception) 
            {
                return Redirect($"../Error");
            }
            return Page();
        }


    }
}
