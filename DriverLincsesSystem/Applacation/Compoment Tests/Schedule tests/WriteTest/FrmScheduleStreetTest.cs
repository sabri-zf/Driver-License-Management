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
    public partial class FrmScheduleStreetTest : Form
    {
        enum Mode { Add, Update }

        private Mode _mode;
        private int _TestAppoitmentID;
        private int _LocalDrivingLicenseID;
        public FrmScheduleStreetTest(int LocalDrivingLicenseID)
        {
            InitializeComponent();

            this._LocalDrivingLicenseID = LocalDrivingLicenseID;
            this._mode = Mode.Add;
        }

        public FrmScheduleStreetTest(int LocalDrivingLicenseID, int TestAppoitmentID)
        {
            InitializeComponent();

            this._LocalDrivingLicenseID = LocalDrivingLicenseID;
            this._TestAppoitmentID = TestAppoitmentID;
            this._mode = Mode.Update;
        }


        private void _LoadInforOFApplication()
        {
            ctrScheduleTestInfo1.TestTypeID = 3;
            ctrScheduleTestInfo1._loadScheduleinfo(LDL_ApplicationID: _LocalDrivingLicenseID);
        }
        private void btnClosePageLocalDrivingApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScheduleStreetTest_Load(object sender, EventArgs e)
        {
            if (this._mode == Mode.Update)
            {
                ctrScheduleTestInfo1.UpdateApointment(_TestAppoitmentID);
                ctrScheduleTestInfo1.checkingIFTestApointmentexist(_TestAppoitmentID);
            }

            _LoadInforOFApplication();
        }

    }
}
