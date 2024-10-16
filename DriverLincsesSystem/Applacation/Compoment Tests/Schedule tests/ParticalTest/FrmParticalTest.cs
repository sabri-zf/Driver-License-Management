using BusinessLayer;
using DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.WriteTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.ParticalTest
{
    public partial class FrmParticalTest : Form
    {

        private DataTable dt_TestApoitmentStreetTest;
        private int _LocalDrivingLicenseID;
        public FrmParticalTest(int localDrivingLicenseID)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = localDrivingLicenseID;
        }

        private void _FillDataGridOFStreetTest()
        {
            dt_TestApoitmentStreetTest = clsTestAppointments.GetAllTestAppoitmentOfPracticalTest(_LocalDrivingLicenseID);

            if (dt_TestApoitmentStreetTest.Rows.Count <= 0) return;

            DGVScheduleStreetTest.DataSource = dt_TestApoitmentStreetTest.DefaultView;

            DGVScheduleStreetTest.Columns[0].HeaderText = "Test ID";
            DGVScheduleStreetTest.Columns[0].Width = 100;

            DGVScheduleStreetTest.Columns[1].HeaderText = "Appoitment Date";
            DGVScheduleStreetTest.Columns[1].Width = 250;
            
            DGVScheduleStreetTest.Columns[1].HeaderText = "Fees";
            DGVScheduleStreetTest.Columns[1].Width = 100;

            DGVScheduleStreetTest.Columns[1].HeaderText = "Is Test Close";
            DGVScheduleStreetTest.Columns[1].Width = 130;

            LabTotalAppoitment.Text = DGVScheduleStreetTest.Rows.Count.ToString();
        }
        private void btnCloseVisionAppoitment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            // btn take test
            if ((bool)DGVScheduleStreetTest.CurrentRow.Cells[3].Value)
            {
                MessageBox.Show("You Can Not Take ReTake Test In This Appoitment Plese Take another Test If you not pass");
                return;
            }


            FrmTakeStreetTest TakeTest= new FrmTakeStreetTest((int)DGVScheduleStreetTest.CurrentRow.Cells[0].Value);
            TakeTest.ShowDialog();
            FrmParticalTest_Load(null,null);

        }

        private void BtnEditAppoitment_Click(object sender, EventArgs e)
        {
            FrmScheduleStreetTest scheduleStreetTest = new FrmScheduleStreetTest(_LocalDrivingLicenseID, (int)DGVScheduleStreetTest.CurrentRow.Cells[0].Value);
            scheduleStreetTest.ShowDialog();
            FrmParticalTest_Load(null, null);
        }

        private void btnAddNewAppoitment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.IsLockedTest(Local_DL_AppID: _LocalDrivingLicenseID, TestTypeID: 3))
            {

                MessageBox.Show("Opps, you Already Have Schedule Test , Please Go Take Test");
                return;

                

            }
            else
            {

                if (clsTests.IsPassedInTest(_LocalDrivingLicenseID,TestTypeID: 3))
                {
                    MessageBox.Show("This Test Finish Because it is Pass on this test");
                    return;
                }

            }


            FrmScheduleStreetTest scheduleStreetTest = new FrmScheduleStreetTest(_LocalDrivingLicenseID);
            scheduleStreetTest.ShowDialog();

            FrmParticalTest_Load(null, null);

        }

        private void FrmParticalTest_Load(object sender, EventArgs e)
        {
            _FillDataGridOFStreetTest();
            ctrLocalDrivingLinceseApplactionInfo1._loadLocalDrivingApplivationInfo(_LocalDrivingLicenseID);

        }
    }
}
