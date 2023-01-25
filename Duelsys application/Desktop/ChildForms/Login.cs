using DuelSysLogic.Managers;
using DuelSysLogic.Interfaces;
using DataAccess.UserManagement;
using DuelSysLogic.Models;
using DuelSysLogic.Enums;
using DuelSysDesktop.ParentForms.Admin;
using DuelSysDesktop.ParentForms;
using DataAccess;
using DataAccess.ExceptionModels;
using System.Diagnostics;

namespace DuelSysDesktop.ChildForms
{
    public partial class LogIn : Form
    {
        private IUserRepository repository;
        private UsersManager userManager;
        private IAssociationsRepository associationsRepository;
        private AssociationsManager associationsManager;
        private IAssociationRepository associationRepository;

        public LogIn()
        {
            InitializeComponent();
            repository = new UserDAL();
            userManager = new UsersManager(repository);
            associationsRepository = new AssociationsDAL();
            associationsManager = new AssociationsManager(associationsRepository);
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("If you couldn't login please contact the customer service", "Couldn't login");
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill the username and password");
                    return;
                }

                UserCredentials loginCredentials = null;


                loginCredentials = userManager.GetUserCredentials(username);


                if (loginCredentials == null)
                {
                    tbPassword.Text = String.Empty;
                    MessageBox.Show("Please check the password and username");
                    return;
                }

                if (loginCredentials.UserType == UserType.Employee || loginCredentials.UserType == UserType.Admin)
                {
                    if (userManager.GetAccess(loginCredentials, username, password))
                    {
                        
                        Association currentAssociation = associationsManager.GetAssociation(loginCredentials.AssociationId);
                        associationRepository = new AssociationDAL(currentAssociation.Id);

                        switch (loginCredentials.UserType)
                        {
                            case UserType.Admin:
                                this.Hide();
                                MainDuelSysAdmin newMainAdmin = new MainDuelSysAdmin(loginCredentials.AssociationId);
                                newMainAdmin.ShowDialog();
                                ; break;
                            case UserType.Employee:
                                MainEmployee newMainEmployee = new MainEmployee(currentAssociation);
                                this.Hide();
                                newMainEmployee.ShowDialog();
                                ; break;
                        }
                    }
                    else
                    {
                        tbPassword.Text = String.Empty;
                        MessageBox.Show("Please check the password and username");
                    }
                }
                else
                {
                    MessageBox.Show("You don't have access to this application");
                    return;
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

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Connection.CloseConnection();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
