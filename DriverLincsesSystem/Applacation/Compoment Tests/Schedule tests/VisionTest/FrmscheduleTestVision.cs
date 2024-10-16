using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.VisionTest
{
    public partial class FrmscheduleTestVision : Form
    {

        enum Mode { eAddNew,eUpdate}

        private Mode _mode=Mode.eAddNew;

        private int _TestAppointmentID = -1;
        private int _LocalDLAppId = -1;

        public FrmscheduleTestVision(int LocalDrivingLicneseID)
        {
            InitializeComponent();

            _mode = Mode.eAddNew;
            this._LocalDLAppId = LocalDrivingLicneseID;
            this.Text = "Add Tets Vision";
        }


        public FrmscheduleTestVision(int LocalDrivingLicneseID,int TestAppointmentID)
        {
            InitializeComponent();
            _mode = Mode.eUpdate;
            _LocalDLAppId  = LocalDrivingLicneseID ;
            _TestAppointmentID = TestAppointmentID;

            this.Text = "edit Test Vision";
        }


        private void _ShowDataOnForm()
        {
            // get the id from Data Grid view cells[0] value
            ctrScheduleTestInfo1.TestTypeID = 1;
            ctrScheduleTestInfo1._loadScheduleinfo(_LocalDLAppId);

        }

        private void btnClosePageLocalDrivingApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmscheduleTestVision_Load(object sender, EventArgs e)
        {

            if (_mode != Mode.eAddNew)
            {
                ctrScheduleTestInfo1.UpdateApointment(_TestAppointmentID);
                ctrScheduleTestInfo1.checkingIFTestApointmentexist(_TestAppointmentID);
            }

            _ShowDataOnForm();

        }
    }
}
