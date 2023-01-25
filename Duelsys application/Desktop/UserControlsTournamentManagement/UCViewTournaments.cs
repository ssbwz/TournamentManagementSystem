using DataAccess.ExceptionModels;
using DuelSysDesktop.ParentForms.TournamentFroms;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using System.Diagnostics;

namespace DuelSysDesktop.UserControlsTournamentManagement
{
    public partial class UCViewTournaments : UserControl
    {
        private Association association;

        private const int FIRSTPAGE = 1;
        private List<TournamentShortInfo> tournamentShortInfos;

        private int pageNumber;

        public UCViewTournaments()
        {
            InitializeComponent();
        }

        internal void Setup(Association association)
        {
            this.association = association;
            intializeDGVViewTournaments();
            RefreshDGVViewTournaments(FIRSTPAGE);

            void intializeDGVViewTournaments()
            {
                DGVViewTournaments.Columns.Add("TournamentShortInfo", "TournamentShortInfo");
                DGVViewTournaments.Columns["TournamentShortInfo"].Visible = false;
                DGVViewTournaments.Columns.Add("Title", "Title");
                DGVViewTournaments.Columns.Add("SportType", "Sport Type");
                DGVViewTournaments.Columns.Add("TournamentSystem", "Tournament System");
                DGVViewTournaments.Columns.Add("ParticipantsNum", "Participants Number");
            }
        }

        //ToDo: Update when there is change
        internal void RefreshDGVViewTournaments(int pageNumber)
        {
            try
            {
                if (pageNumber < 0)
                {
                    return;
                }

                DGVViewTournaments.Rows.Clear();

                tournamentShortInfos = association.GetEightTournamentShortInfoEachTime(pageNumber);

                NUDPages.Value = pageNumber;
                if (tournamentShortInfos == null)
                {
                    return;
                }
                foreach (var tournamentShortInfo in tournamentShortInfos)
                {
                    DGVViewTournaments.Rows.Add(tournamentShortInfo, tournamentShortInfo.Title, tournamentShortInfo.SportType.ToString(), tournamentShortInfo.TournamentSystem.ToString(), tournamentShortInfo.ParticipantsNum);
                }
            }
            catch (DALException ex)
            {
                throw new DALException(ex.Message, ex);
            }
            catch (UnableToConnectToHostException ex)
            {
                throw new UnableToConnectToHostException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void NUDPages_ValueChanged(object sender, EventArgs e)
        {
            if (pageNumber < 1) 
            {
                pageNumber = 1;
            }
            pageNumber = (int)NUDPages.Value;
            RefreshDGVViewTournaments(pageNumber);

            if (tournamentShortInfos == null)
            {
                --NUDPages.Value;
            }

            if (tournamentShortInfos.Count < 8 && pageNumber > 1)
            {
                if(pageNumber< 1)
                --NUDPages.Value;
                return;
            }
            RefreshDGVViewTournaments(pageNumber);
            return;
        
        }

        private void DGVViewTournaments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewATournament tournamentForm = null;
            Tournament selectedTouranment = null;
            try
            {
                try
                {
                     selectedTouranment = getSelectedTournament();
                }
                catch (UnableToConnectToHostException ex)
                {
                    MessageBox.Show(ex.Message + ", Please make sure that you are connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (DALException ex)
                {
                    MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedTouranment == null) 
                {
                    MessageBox.Show("Couldn't find tournament" + ",Please refesh the page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tournamentForm = new ViewATournament(association,selectedTouranment,this);
                tournamentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private Tournament getSelectedTournament()
        {
            return association.GetTournamentById(getSeletedTournamentShortInfo().Id);
        }

        internal TournamentShortInfo getSeletedTournamentShortInfo() 
        {
            int selectedIndex = DGVViewTournaments.CurrentRow.Index;
            return (TournamentShortInfo)DGVViewTournaments.Rows[selectedIndex].Cells["TournamentShortInfo"].Value;
        }   
    }
}
