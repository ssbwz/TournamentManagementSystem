using DataAccess.ExceptionModels;
using DataAccess.UserManagement;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models;
using System.Diagnostics;

namespace DuelSysDesktop.ParentForms.Admin
{
    public partial class EmployeeManagement : Form
    {
        private IUserRepository repository;
        private UsersManager userManager;

        private int associationId;

        public EmployeeManagement(int associationId)
        {
            InitializeComponent();

            this.associationId = associationId;

            repository = new UserDAL();
            userManager = new UsersManager(repository);

            //SetUp user management user controls 
            ucViewEmployees.Setup(associationId, this);
            ucCreateEmployee.Setup(associationId, ucViewEmployees);
            ucUpdateEmployee.Setup(associationId, ucViewEmployees);

        }

        //ToDo: Delete the row instead of refreshing the whole datagridview
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = ucViewEmployees.GetSelectedEmployee();

                if (staff == null)
                {
                    MessageBox.Show("There are no employee selected");
                    return;
                }

                var result = MessageBox.Show(
                                             $"Are you sure you want to delete {staff.FirstName} {staff.LastName} ?",
                                             "DuelSys inc.",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question
                                                         );
                if (result == DialogResult.Yes)
                {
                    userManager.DeleteUser(staff);
                    ucViewEmployees.Refresh(associationId);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ucViewEmployees.Hide();
            ucCreateEmployee.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff staff = ucViewEmployees.GetSelectedEmployee();

            if (staff == null)
            {
                MessageBox.Show("There are no employee selected");
                return;
            }

            ucViewEmployees.Hide();
            ucUpdateEmployee.FillFields(staff);
            ucUpdateEmployee.Show();
        }
    }
}
