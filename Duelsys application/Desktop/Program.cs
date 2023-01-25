using DataAccess;
using DuelSysDesktop.ChildForms;
using System.Diagnostics;

namespace Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new LogIn());
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something went wrong the application has to close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
            }
        }
    }
}