using DriverLincsesSystem.Applacation.ApplactionType;
using DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.VisionTest;
using DriverLincsesSystem.Applacation.LocalDriverLicense;
using DriverLincsesSystem.Applacation.LocalDriverLicense.NewLocalDriverLicense;
using DriverLincsesSystem.Applacation.ShowApplicatrionDetails;
using DriverLincsesSystem.Applacation.TestType;
using DriverLincsesSystem.Drivers;
using DriverLincsesSystem.People;
using DriverLincsesSystem.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());


            //Application.Run(new FrmShowHistoryLicense());


            FrmLogInScreen Login = new FrmLogInScreen();
            Login.ShowDialog();

            // this is Logic To loop To Run Form2 if Close Form 1 
            while (!(Login.DialogResult == DialogResult.Cancel))
            {
                if (Login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new FrmMain());
                }
                else
                {
                    Application.Exit();
                };

                // reload this form After close from two
                Login.ShowDialog();
            }


            // Application.Run(new FrmPeopleCardWithFilter());
        }
    }
}
