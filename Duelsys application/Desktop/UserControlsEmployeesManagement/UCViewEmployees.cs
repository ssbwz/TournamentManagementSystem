using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using DataAccess.UserManagement;
using DuelSysDesktop.ParentForms.Admin;
using DuelSys_Logic.Models;
using DuelSysLogic.Models;
using DuelSysDesktop.ChildForms;
using DataAccess.ExceptionModels;
using System.Diagnostics;

namespace DuelSysDesktop.UserControlsEmployeesManagement
{
    public partial class UCViewEmployees : UserControl
    {
        private const int MIN_PAGE_NUMBER = 1;
        private const int FIRST_PAGE_NUMBER = MIN_PAGE_NUMBER;
        private const int MAX_ROW = 8;
        private IUserRepository repository;
        private UsersManager userManager;
        private int associationId;
        private EmployeeManagement employeeManagement;
        private List<Staff> staffs;

        private int pageNumber;

        public UCViewEmployees()
        {
            InitializeComponent();
        }

        public int PageNumber
        {
            get
            {
                return (int)NUDPages.Value;
            }
        }

        internal void Setup(int associationId, EmployeeManagement employeeManagement)
        {
            this.repository = new UserDAL();
            this.userManager = new UsersManager(repository);
            this.associationId = associationId;
            this.employeeManagement = employeeManagement;
            initializeDGVViewEmployess();
            Refresh(FIRST_PAGE_NUMBER);
        }

        internal Staff GetSelectedEmployee()
        {
            if (DGVViewEmployess.CurrentRow == null)
            {
                return null;
            }

            int selectedIndex = DGVViewEmployess.CurrentRow.Index;
            return (Staff)DGVViewEmployess.Rows[selectedIndex].Cells["Staff"].Value;
        }

        //ToDO: Add filter method
        internal void Refresh(int pageNumber)
        {
            try
            {
                if (pageNumber < 0)
                {
                    return;
                }

                NUDPages.Value = pageNumber;

                DGVViewEmployess.Rows.Clear();
                if (associationId == 0)
                {
                    staffs = userManager.GetEightAdminsEachTime(pageNumber, associationId);
                }
                else
                {
                    staffs = userManager.GetEightEmployeesEachTime(pageNumber, associationId);
                }

                if (staffs == null)
                {
                    return;
                }
                foreach (User user in staffs)
                {
                    DGVViewEmployess.Rows.Add(user, user.FirstName, user.LastName, user.BirthDate, user.Gender.ToString());
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

        //ToDO: update when there are changes
        internal void UpdateDataGrideViewEmployess(int pageNumber)
        {
            Refresh(pageNumber);
        }

        private void NUDPages_ValueChanged(object sender, EventArgs e)
        {
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
            pageNumber = (int)NUDPages.Value;
            Refresh(pageNumber);

            if (staffs == null)
            {
                --NUDPages.Value;
            }

            if (staffs.Count < 8 && pageNumber > 1)
            {
                --NUDPages.Value;
                return;
            }
            Refresh(pageNumber);
            return;
        }

        private void DGVViewEmployess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff staff = GetSelectedEmployee();

            if (staff == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            ViewAEmployee viewAEmployee = new ViewAEmployee(staff);
            viewAEmployee.Show();
        }

        private void initializeDGVViewEmployess()
        {
            DGVViewEmployess.Columns.Add("Staff", "Staff");
            DGVViewEmployess.Columns["Staff"].Visible = false;
            DGVViewEmployess.Columns.Add("First name", "First name");
            DGVViewEmployess.Columns.Add("Last name", "Last name");
            DGVViewEmployess.Columns.Add("Date of birth", "Date of birth");
            DGVViewEmployess.Columns.Add("Gender", "Gender");
        }
    }
}
