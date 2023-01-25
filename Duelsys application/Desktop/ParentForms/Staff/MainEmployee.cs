using DataAccess;
using DataAccess.ExceptionModels;
using DuelSysDesktop.ChildForms;
using DuelSysDesktop.ParentForms.TournamentFroms;
using DuelSysLogic.Managers;
using MediaBazaar.Design;
using System.Diagnostics;

namespace DuelSysDesktop.ParentForms
{
    public partial class MainEmployee : Form
    {
        private Association association;
        public MainEmployee(Association association)
        {
            InitializeComponent();
            DesignClass.AutoDesginerForForms(this.Controls, this);
            this.association = association;
        }

        private void btTournament_Click(object sender, EventArgs e)
        {
            try
            {
                TournamentsManagement tournamentsManagement = new TournamentsManagement(association);
                tournamentsManagement.Show();
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

        private void MainEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to close the application?",
                    "DuelSys inc.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Connection.CloseConnection();
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }
    }
}
