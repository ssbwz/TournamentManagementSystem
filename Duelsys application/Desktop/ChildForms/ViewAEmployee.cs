using DuelSysLogic.Models;


namespace DuelSysDesktop.ChildForms
{
    public partial class ViewAEmployee : Form
    {
        public ViewAEmployee(Staff staff)
        {
            InitializeComponent();

            setStaffInFields();

            void setStaffInFields() 
            {
                tbFirstName.Text = staff.FirstName;
                tbLastName.Text = staff.LastName;
                tbGender.Text = staff.Gender.ToString();
                tbDateOfBirth.Text = staff.BirthDate;
                tbEmail.Text = staff.Email;
                tbPhoneNumber.Text = staff.PhoneNumber;
                tbUsername.Text = staff.UserCredentials.UserName;
                tbBSN.Text = staff.BSN;

            }
        }

    }
}
