using DataAccess;
using DataAccess.ExceptionModels;
using DuelSysDesktop.ChildForms;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models;
using MediaBazaar.Design;
using System.Diagnostics;

namespace DuelSysDesktop.ParentForms.Admin
{
    public partial class MainDuelSysAdmin : Form
    {
        private const int PAGE_NUM = 1;

        private AssociationsManager associationsManager;

        private IAssociationsRepository repository;

        private List<Association> associations;

        private int associationId;
        public MainDuelSysAdmin(int associationId)
        {

            InitializeComponent();
            DesignClass.AutoDesginerForForms(this.Controls, this);

            repository = new AssociationsDAL();
            associationsManager = new AssociationsManager(repository);

            this.associationId = associationId;

            setUpDGVAssociatinos();
            RefreshDGVViewAssociations(PAGE_NUM);

            void setUpDGVAssociatinos()
            {
                DGVViewAssociations.Columns.Add("Association", "Association");
                DGVViewAssociations.Columns.Add("Id", "Id");
                DGVViewAssociations.Columns["Association"].Visible = false;
                DGVViewAssociations.Columns.Add("Name", "Name");
            }
        }

        internal void RefreshDGVViewAssociations(int pageNumber)
        {

            DGVViewAssociations.Rows.Clear();

            associations = associationsManager.GetEightAssociationEachTime(pageNumber);

            foreach (Association associationDetails in associations)
            {
                DGVViewAssociations.Rows.Add(associationDetails, associationDetails.Id, associationDetails.Name);
            }
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void MainAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                if (getSelectedAssociationId() != -1)
                {

                    EmployeeManagement employeeManagement = new EmployeeManagement(getSelectedAssociationId());
                    employeeManagement.Show();
                    return;
                }
                MessageBox.Show("Please select association");
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
                Debug.Write(ex.Message);
            }
        }

        private int getSelectedAssociationId()
        {
            if (DGVViewAssociations.CurrentRow == null)
            {
                return -1;
            }
            int selectedIndex = DGVViewAssociations.CurrentRow.Index;
            return ((Association)DGVViewAssociations.Rows[selectedIndex].Cells["Association"].Value).Id;
        }

        private void NUDPages_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int pageNumber = (int)NUDPages.Value;

                if (pageNumber < 1)
                {
                    pageNumber = 1;
                }
                RefreshDGVViewAssociations(pageNumber);

                if (associations.Count < 8 && pageNumber > 1)
                {
                    --NUDPages.Value;
                    return;
                }
                RefreshDGVViewAssociations(pageNumber);
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
                Debug.Write(ex.Message);
            }
        }

        private void btAdmins_Click(object sender, EventArgs e)
        {

            try
            {
                EmployeeManagement employeeManagement = new EmployeeManagement(associationId);
                employeeManagement.Show();
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
                Debug.Write(ex.Message);
            }
        }
    }
}
