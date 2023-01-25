using DataAccess.ExceptionModels;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;
using MediaBazaar.Design;
using System.Diagnostics;

namespace DuelSysDesktop.ParentForms.TournamentFroms
{
    public partial class TournamentsManagement : Form
    {
        private const int PAGE_NUMBER_ONE = 1;
        private Association association;

        public TournamentsManagement(Association association)
        {
            InitializeComponent();
            DesignClass.AutoDesginerForForms(this.Controls, this);

            this.association = association;

            ucViewTournaments.Setup(association);
            ucCreateTournament.Setup(association, ucViewTournaments);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ucViewTournaments.Hide();
            ucCreateTournament.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                TournamentShortInfo deletedTournamentShortInfo = ucViewTournaments.getSeletedTournamentShortInfo();

                var result = MessageBox.Show($"Are you sure you want to delete?" +
                    $"{Environment.NewLine}Title: {deletedTournamentShortInfo.Title}" +
                    $"{Environment.NewLine}Spor type: {deletedTournamentShortInfo.SportType.ToString()}" +
                    $"{Environment.NewLine}Tournament system: {deletedTournamentShortInfo.TournamentSystem.ToString()}" +
                    $"{Environment.NewLine}All of {deletedTournamentShortInfo.ParticipantsNum} participants will be deleted", "Deleting tournament", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    association.DeleteTournament(deletedTournamentShortInfo);
                    MessageBox.Show("Tournament got deleted successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucViewTournaments.RefreshDGVViewTournaments(PAGE_NUMBER_ONE);
                }
            }
            catch (UnableToConnectToHostException ex)
            {
                MessageBox.Show(ex.Message + ", Please make sure that you are connected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DALException ex)
            {
                MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

    }
}
