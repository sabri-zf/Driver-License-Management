using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.VisionTest
{
    public partial class FrmVisionTest : Form
    {
        DataTable dt_AppoitmentDetails;
        private int _LocalDrivingLincesID;
     

        public FrmVisionTest(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            this._LocalDrivingLincesID = LocalDrivingLicenseID;
        }

        
        private void _LoadAppoitments()
        {

            dt_AppoitmentDetails = clsTestAppointments.GetAllTestAppoitmentOfVisionTest(LocalDrivingLinceseApplicaionID: _LocalDrivingLincesID);

            DGVScheduleVisonTest.DataSource = dt_AppoitmentDetails.DefaultView;

            if (DGVScheduleVisonTest.Rows.Count > 0)
            {
                DGVScheduleVisonTest.Columns[0].HeaderText = "Test ID";
                DGVScheduleVisonTest.Columns[0].Width = 100;
                
                DGVScheduleVisonTest.Columns[2].HeaderText = "Test Fees";
                DGVScheduleVisonTest.Columns[2].Width = 150;

                DGVScheduleVisonTest.Columns[3].HeaderText = "Finish Test";
                DGVScheduleVisonTest.Columns[3].Width = 150;

            }

            LabTotalAppoitment.Text = DGVScheduleVisonTest.Rows.Count.ToString();
        }

        private void btnCloseVisionAppoitment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewAppoitment_Click(object sender, EventArgs e)
        {
          

            if (clsTestAppointments.FindByLocalDrivingLicenseID(_LocalDrivingLincesID)  != null)
            {
                if (clsTests.IsPassedInTest(_LocalDrivingLincesID, 1))
                {
                    MessageBox.Show("This Customer Already Schedule Test In This Test, So You cann't Take Test Again", "Worrnig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!clsTestAppointments.IsLockedTest(_LocalDrivingLincesID, 1))
                {
                    MessageBox.Show("This Appoitment Test Is Opend ");
                    return;
                }
            }
          


                FrmscheduleTestVision VisionTest = new FrmscheduleTestVision(_LocalDrivingLincesID);
            VisionTest.ShowDialog();

            FrmVisionTest_Load(null, null);

            //first check about if this person have another appoitment

        }

        private void FrmVisionTest_Load(object sender, EventArgs e)
        {
            _LoadAppoitments();

            ctrLocalDrivingLinceseApplactionInfo1._loadLocalDrivingApplivationInfo(_LocalDrivingLincesID);
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            if ((bool)DGVScheduleVisonTest.CurrentRow.Cells[3].Value)
            {
                MessageBox.Show("You Can Not Take ReTake Test In This Appoitment Plese Take another Test If you not pass");
                return;
            }

            FrmTakeTestVision TakeTestVision = new FrmTakeTestVision((int)DGVScheduleVisonTest.CurrentRow.Cells[0].Value);
            TakeTestVision.ShowDialog();
            FrmVisionTest_Load(null, null);
        }

        private void BtnEditAppoitment_Click(object sender, EventArgs e)
        {
            FrmscheduleTestVision VisionTest = new FrmscheduleTestVision(_LocalDrivingLincesID, (int)DGVScheduleVisonTest.CurrentRow.Cells[0].Value);
            VisionTest.ShowDialog();
        }
    }
}
