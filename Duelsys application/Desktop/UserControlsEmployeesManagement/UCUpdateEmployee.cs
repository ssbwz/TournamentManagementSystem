using DataAccess.ExceptionModels;
using DataAccess.UserManagement;
using DuelSys_Logic.Enums;
using DuelSysLogic.Enums;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DuelSysLogic.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DuelSysDesktop.UserControlsEmployeesManagement
{
    public partial class UCUpdateEmployee : UserControl
    {
        private IUserRepository repository;
        private UsersManager userManager;

        private int associationId;

        private UCViewEmployees uCViewEmployees;

        private Staff oldStaff = null;

        public UCUpdateEmployee()
        {
            InitializeComponent();
        }

        internal void Setup(int associationId, UCViewEmployees uCViewEmployees)
        {

            repository = new UserDAL();
            this.userManager = new UsersManager(repository);


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

        internal void FillFields(Staff staff)
        {
            oldStaff = staff;
            tbFirstName.Text = staff.FirstName;
            tbLastName.Text = staff.LastName;

            dtpDateOfBirth.Value = convertBirthDateStringToDateTime(staff.BirthDate);

            tbPhoneNumber.Text = staff.PhoneNumber;
            tbEmail.Text = staff.Email;
            tbUsername.Text = staff.UserCredentials.UserName;
            tbBSN.Text = staff.BSN;
            cbUserType.SelectedItem = staff.UserCredentials.UserType == UserType.AssociationAdmin ? "Association Admin" : staff.UserCredentials.UserType.ToString();
            cbGender.SelectedItem = staff.Gender.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cleanAnnotation();

            Staff updatedStaff = null;

            oldStaff.BirthDate = convertBirthDateStringToDateTime(oldStaff.BirthDate).ToString("yyyy-MM-dd");
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
                if (userManager.CheckDuplicationBSN(BSN, associationId) && !string.IsNullOrEmpty(BSN) && oldStaff.BSN != BSN)
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
                    && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(username)
                    )
                {
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), cbGender.SelectedItem.ToString());
                    UserType type = (UserType)Enum.Parse(typeof(UserType), userType);


                    UserCredentials userCredentials = null;
                    if (string.IsNullOrWhiteSpace(newPassword))
                    {
                        newPassword = oldStaff.UserCredentials.HashedPassword;
                        userCredentials = new UserCredentials(oldStaff.UserCredentials.Id, username, newPassword, oldStaff.UserCredentials.Salt, type, associationId);
                    }
                    else
                    {
                        userCredentials = new UserCredentials(oldStaff.UserCredentials.Id, username, oldStaff.UserCredentials.Salt, type, newPassword, associationId);
                    }

                    updatedStaff = new Staff(BSN, firstname, lastname, gender, birthdate, phoneNumber, email, userCredentials);

                    userManager.UpdateUser(oldStaff, updatedStaff);

                    uCViewEmployees.UpdateDataGrideViewEmployess(uCViewEmployees.PageNumber);
                    MessageBox.Show("The account got updated successfully","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
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
                this.Hide();
                uCViewEmployees.Show();
                tbPassword.Text = string.Empty;
            }
            catch (DALException ex)
            {
                MessageBox.Show(ex.Message + ", Please try again", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                uCViewEmployees.Show();
                tbPassword.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
                this.Hide();
                uCViewEmployees.Show();
                tbPassword.Text = string.Empty;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            uCViewEmployees.Show();
            cleanAnnotation();
        }

        private void cleanAnnotation()
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

        private DateTime convertBirthDateStringToDateTime(string birthdate)
        {
            //inser date of birth of staff in the date time picker
            int dateOfBirthDay = Convert.ToInt32(birthdate.Substring(0, 2));
            int dateOfBirthMonth = Convert.ToInt32(birthdate.Substring(3, 2));
            int dateOfBirthYear = Convert.ToInt32(birthdate.Substring(6, 4));

            return new DateTime(dateOfBirthYear, dateOfBirthMonth, dateOfBirthDay);
        }
    }
}
