using DuelSys_Logic.Enums;
using System.Text.RegularExpressions;
using DuelSysLogic.Interfaces;
using DataAccess.UserManagement;
using DuelSysLogic.Managers;
using DuelSysLogic.Models;
using DuelSysLogic.Enums;
using System.Diagnostics;
using DataAccess.ExceptionModels;


namespace DuelSysDesktop.UserControlsEmployeesManagement
{
    public partial class UCCreateEmployee : UserControl
    {
        private IUserRepository repository;
        private UsersManager userManager;

        private int associationId;
        private UCViewEmployees uCViewEmployees;

        public UCCreateEmployee()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        internal void Setup(int associationId, UCViewEmployees uCViewEmployees)
        {
            try
            {
                this.repository = new UserDAL();
                this.userManager = new UsersManager(repository);
                this.associationId = associationId;
                this.uCViewEmployees = uCViewEmployees;

                setUpCBGender();
                setUpDTPDateOfBirth();

                // If the user isn't admin in Duelsys
                if (associationId != 0)
                {
                    cbUserType.Items.Remove("Admin");
                }
                else
                {
                    cbUserType.Items.Clear();
                    cbUserType.Items.Add("Admin");
                }

                void setUpCBGender()
                {
                    cbGender.Items.Clear();
                    cbGender.Items.Add(Gender.Male.ToString());
                    cbGender.Items.Add(Gender.Female.ToString());
                    cbGender.Items.Add(Gender.Other.ToString());
                }
                void setUpDTPDateOfBirth()
                {
                    dtpDateOfBirth.MaxDate = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string birthdate = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            string phoneNumber = tbPhoneNumber.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string newPassword = tbPassword.Text;
            string BSN = tbBSN.Text;
            string userType = cbUserType.Text;

            try
            {
                cleanAnnotation();

                //Checking if empty
                if (string.IsNullOrWhiteSpace(firstname))
                {
                    lbFirstName.Visible = true;
                    lbFirstName.Text = "Please fill first name field.";
                }
                if (string.IsNullOrWhiteSpace(lastname))
                {
                    lbLastName.Visible = true;
                    lbLastName.Text = "Please fill last name field.";
                }
                if (string.IsNullOrWhiteSpace(birthdate))
                {
                    lbDateOfBirth.Visible = true;
                    lbDateOfBirth.Text = "Please select birthdate.";
                }
                if (cbGender.SelectedItem == null)
                {
                    lbGender.Visible = true;
                    lbGender.Text = "Please select gender.";
                }
                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    lbPhoneNumber.Visible = true;
                    lbPhoneNumber.Text = "Please fill phone number field.";
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    lbEmail.Visible = true;
                    lbEmail.Text = "Please fill email field.";
                }
                if (string.IsNullOrWhiteSpace(username))
                {
                    lbUsername.Visible = true;
                    lbUsername.Text = "Please fill username field.";
                }
                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    lbPassword.Visible = true;
                    lbPassword.Text = "Please fill password field.";
                }
                if (string.IsNullOrWhiteSpace(BSN))
                {
                    lbBSN.Visible = true;
                    lbBSN.Text = "Please fill BSN field.";
                }
                if (string.IsNullOrWhiteSpace(BSN))
                {
                    lbBSN.Visible = true;
                    lbBSN.Text = "Please fill BSN field.";
                }
                if (string.IsNullOrWhiteSpace(userType) && cbUserType.Visible)
                {
                    lbType.Visible = true;
                    lbType.Text = "Please select type.";
                }

                //Validating the unique values

                if (userManager.CheckDuplicationBSN(BSN, associationId) && !string.IsNullOrEmpty(BSN))
                {
                    lbBSN.Visible = true;
                    lbBSN.Text = "This BSN is already registered";
                    BSN = String.Empty;
                }

                //Validating the inputs 
                if (!Regex.IsMatch(firstname, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$") && !string.IsNullOrWhiteSpace(firstname))
                {
                    lbFirstName.Visible = true;
                    lbFirstName.Text = "Please enter vaild first name.";
                    firstname = String.Empty;
                }
                if (!Regex.IsMatch(lastname, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$") && !string.IsNullOrWhiteSpace(lastname))
                {
                    lbLastName.Visible = true;
                    lbLastName.Text = "Please enter vaild last name.";
                    lastname = String.Empty;
                }
                if (!Regex.IsMatch(email, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$") && !string.IsNullOrWhiteSpace(email))
                {
                    lbEmail.Visible = true;
                    lbEmail.Text = "Please enter vaild email.";
                    email = String.Empty;
                }
                if (!Regex.IsMatch(phoneNumber, @"^\d{10,15}$") && !string.IsNullOrWhiteSpace(phoneNumber))
                {
                    lbPhoneNumber.Visible = true;
                    lbPhoneNumber.Text = "Please enter vaild phone number.";
                    phoneNumber = String.Empty;
                }
                if (!Regex.IsMatch(username, @"^[^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,30}$") && !string.IsNullOrWhiteSpace(username))
                {
                    lbUsername.Visible = true;
                    lbUsername.Text = $"Please make sure that you don't have any characters{Environment.NewLine}and username is longer than 2 characters";
                    username = String.Empty;
                }
                if (!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\W+]).{8,20}$") && !string.IsNullOrWhiteSpace(newPassword))
                {
                    lbPassword.Visible = true;
                    lbPassword.Text = $"Password should include one lowercase letter and one capital letter and one{Environment.NewLine}character and should be longer than 8 characters";
                    newPassword = String.Empty;
                }
                if (!Regex.IsMatch(BSN, @"^\d{8,9}$") && !string.IsNullOrWhiteSpace(BSN))
                {
                    lbBSN.Visible = true;
                    lbBSN.Text = "BSN should be 8 or 9 digits.";
                    BSN = String.Empty;
                }


                if (cbUserType.Visible == true ? string.IsNullOrEmpty(userType) : true)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname) && !string.IsNullOrEmpty(birthdate)
                    && cbGender.SelectedItem != null && !string.IsNullOrEmpty(phoneNumber)
                    && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(newPassword)
                    )
                {
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), cbGender.SelectedItem.ToString());
                    UserType type;

                    if (userType == "Association Admin")
                    {
                        type = UserType.AssociationAdmin;
                    }
                    else if (userType == "Admin")
                    {
                        type = UserType.Admin;
                    }
                    else
                    {
                        type = cbUserType.Visible ? (UserType)Enum.Parse(typeof(UserType), userType) : UserType.Employee;
                    }

                    UserCredentials userCredentials = new UserCredentials(username.Trim(), newPassword.Trim(), type,associationId);

                    userManager.CreateUser(new Staff(BSN, firstname, lastname, gender, birthdate, phoneNumber, email, userCredentials));

                    uCViewEmployees.UpdateDataGrideViewEmployess(uCViewEmployees.PageNumber);
                    this.Hide();
                    restFields();
                    uCViewEmployees.Show();
                }
            }
            catch (UsernameDuplicationException ex)
            {
                lbUsername.Visible = true;
                lbUsername.Text = ex.Message;
                username = String.Empty;
            }
            catch (PhoneNumberDuplicationException ex)
            {
                lbPhoneNumber.Visible = true;
                lbPhoneNumber.Text = ex.Message;
                phoneNumber = String.Empty;
            }
            catch (EmailDuplicationException ex)
            {
                lbEmail.Visible = true;
                lbEmail.Text = ex.Message;
                email = String.Empty;
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

            void cleanAnnotation()
            {
                lbFirstName.Visible = true;
                lbFirstName.Text = String.Empty;

                lbLastName.Visible = true;
                lbLastName.Text = String.Empty;

                lbGender.Visible = true;
                lbGender.Text = String.Empty;

                lbDateOfBirth.Visible = true;
                lbDateOfBirth.Text = String.Empty;

                lbPhoneNumber.Visible = true;
                lbPhoneNumber.Text = String.Empty;

                lbEmail.Visible = true;
                lbEmail.Text = String.Empty;

                lbUsername.Visible = true;
                lbUsername.Text = String.Empty;

                lbPassword.Visible = true;
                lbPassword.Text = String.Empty;


                lbBSN.Visible = true;
                lbBSN.Text = String.Empty;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                uCViewEmployees.Show();
                restFields();
        }

        private void restFields()
        {
                tbFirstName.Text = String.Empty;
                lbFirstName.Visible = true;
                lbFirstName.Text = String.Empty;

                tbLastName.Text = String.Empty;
                lbLastName.Visible = true;
                lbLastName.Text = String.Empty;

                cbGender.SelectedItem = null;
                lbGender.Visible = true;
                lbGender.Text = String.Empty;

                cbUserType.SelectedItem = null;
                cbUserType.Visible = true;
                cbUserType.Text = String.Empty;

                dtpDateOfBirth.Text = String.Empty;
                lbDateOfBirth.Visible = true;
                lbDateOfBirth.Text = String.Empty;

                tbPhoneNumber.Text = String.Empty;
                lbPhoneNumber.Visible = true;
                lbPhoneNumber.Text = String.Empty;

                tbEmail.Text = String.Empty;
                lbEmail.Visible = true;
                lbEmail.Text = String.Empty;

                tbUsername.Text = String.Empty;
                lbUsername.Visible = true;
                lbUsername.Text = String.Empty;

                tbPassword.Text = String.Empty;
                lbPassword.Visible = true;
                lbPassword.Text = String.Empty;


                tbBSN.Text = String.Empty;
                lbBSN.Visible = true;
                lbBSN.Text = String.Empty;

            cbUserType.SelectedItem = null;
            lbType.Text = String.Empty;
            lbType.Visible = true;
           
        }
    }
}
