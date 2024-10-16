using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.WriteTest
{
    public partial class FrmWriteTest : Form
    {

        private DataTable dt_LoadWriteTestAppoitment;
        private int _LocalDrivingLiecnseID;

        public FrmWriteTest(int localDrivingLiecnseID)
        {
            InitializeComponent();
          this._LocalDrivingLiecnseID = localDrivingLiecnseID;
        }

        private void btnCloseVisionAppoitment_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _FillDataGridOFWriteTest()
        {
            dt_LoadWriteTestAppoitment = clsTestAppointments.GetAllTestAppoitmentOfWriteTest(_LocalDrivingLiecnseID);

            if (dt_LoadWriteTestAppoitment.Rows.Count <= 0) return;

            DGVScheduleWriteTest.DataSource = dt_LoadWriteTestAppoitment.DefaultView;

            DGVScheduleWriteTest.Columns[0].HeaderText = "Test ID";
            DGVScheduleWriteTest.Columns[0].Width = 100;

            DGVScheduleWriteTest.Columns[1].HeaderText = "Appoitment Date";
            DGVScheduleWriteTest.Columns[1].Width = 250;

            DGVScheduleWriteTest.Columns[1].HeaderText = "Fees";
            DGVScheduleWriteTest.Columns[1].Width = 100;

            DGVScheduleWriteTest.Columns[1].HeaderText = "Is Test Close";
            DGVScheduleWriteTest.Columns[1].Width = 130;

            LabTotalAppoitment.Text = DGVScheduleWriteTest.Rows.Count.ToString();
        }

        private void FrmWriteTest_Load(object sender, EventArgs e)
        {
            _FillDataGridOFWriteTest();
            ctrLocalDrivingLinceseApplactionInfo1._loadLocalDrivingApplivationInfo(_LocalDrivingLiecnseID);
        }


        
        private void btnAddNewAppoitment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.IsLockedTest(Local_DL_AppID: _LocalDrivingLiecnseID, TestTypeID: 2))
            {

                MessageBox.Show("Opps, you Already Have Schedule Test ,Please Go To Take Test");
                return;

            }
            else
            {

                if (clsTests.IsPassedInTest(_LocalDrivingLiecnseID, 2))
                {
                    MessageBox.Show("This Test End Because it's Pass in test");
                    return;
                }
               
            }

            


            FrmScheduleTestWrite ScheduleWriteTest = new FrmScheduleTestWrite(LocalDrivingLicenseID: _LocalDrivingLiecnseID);
            ScheduleWriteTest.ShowDialog();

            FrmWriteTest_Load(sender: null, e: null);
        }

        private void BtnEditAppoitment_Click(object sender, EventArgs e)
        {
            FrmScheduleTestWrite ScheduleWriteTest = new FrmScheduleTestWrite(LocalDrivingLicenseID: _LocalDrivingLiecnseID,
                                                     TestAppoitmentID:(int)DGVScheduleWriteTest.CurrentRow.Cells[0].Value);
            ScheduleWriteTest.ShowDialog();

            FrmWriteTest_Load(sender: null, e: null);
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            if ((bool)DGVScheduleWriteTest.CurrentRow.Cells[3].Value)
            {
                MessageBox.Show("You Can Not Take ReTake Test In This Appoitment Plese Take another Test If you not pass");
                return;
            }

            FrmTakeTestWrite ScheduleTest = new FrmTakeTestWrite((int)DGVScheduleWriteTest.CurrentRow.Cells[0].Value);
            ScheduleTest.ShowDialog();
            FrmWriteTest_Load(sender: null, e: null);
        }
    }
}
