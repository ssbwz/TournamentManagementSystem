using DuelSysDesktop.ChildForms;
using DuelSysDesktop.ParentForms.Admin;
using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.AssociationAdmin
{
    public partial class MainAssociationAdmin : Form
    {
        private int associationId;
        public MainAssociationAdmin(int associationId)
        {
            InitializeComponent();
            DesignClass.AutoDesginerForForms(this.Controls, this);

            this.associationId = associationId;
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void btEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(associationId);
            employeeManagement.Show();
        }
    }
}
