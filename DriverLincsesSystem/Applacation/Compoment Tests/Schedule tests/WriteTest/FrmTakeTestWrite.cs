using BusinessLayer;
using DriverLincsesSystem.GlobleClasses;
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
    public partial class FrmTakeTestWrite : Form
    {

        private clsTestAppointments _TestAppoitment;

        private int _TestAppoitmentId;
        private clsTests _Test = new clsTests();

        public FrmTakeTestWrite(int testAppoitmentID)
        {
            InitializeComponent();
            _TestAppoitmentId = testAppoitmentID;
        }



        private void _LoadTestInFormation()
        {
            _TestAppoitment = clsTestAppointments.Find(_TestAppoitmentId);

            if (_TestAppoitment != null)
            {
                ctrTakeTestInformation1.LoadData(_TestAppoitment.LocalDrivingLicenseApplicationID, 1);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool CloseTestAppoitment()
        {
            _TestAppoitment.IsLocked = true;

            if (MessageBox.Show("Becarfull If You Prees Save , you Can Not edit this test \n Are You sure do you want save ", "Attention",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return _TestAppoitment.Save();
            }

            return false;   
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren()) return;


            _Test.TestResult = (BtnFail.Checked == true) ? false : true;
            _Test.Notes = TBNotes.Text.Trim();
            _Test.TestAppointmentID = _TestAppoitment.TestAppointmentID;
            _Test.CreatedByUserID = ClsSetting.logInUser.UserID;

            if (CloseTestAppoitment())
            {

                if (_Test.Save())
                {
                    MessageBox.Show("Save Sccessfully ");

                    LabTestID.Text = _Test.TestID.ToString();
                }

                return;
            }


            MessageBox.Show("Save Fail ");
        }

       

        private void FrmTakeTestWrite_Load(object sender, EventArgs e)
        {
            _LoadTestInFormation();
        }
    }
}
