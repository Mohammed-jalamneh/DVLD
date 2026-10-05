using DVLD.Users;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (sender, args) =>
            {
                clsEventLogger.LogException(args.Exception);
                MessageBox.Show("An unexpected error occurred. Details have been logged to the system event log.",
                                "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                if (args.ExceptionObject is Exception ex)
                {
                    clsEventLogger.LogException(ex);
                }
            };

            if (clsLoggedUser.CurrentUser == null)
            {
                clsLoggedUser.CurrentUser = clsUsersB.Find(1);
            }

            Application.Run(new frmLogicScreen());
        }
    }
}