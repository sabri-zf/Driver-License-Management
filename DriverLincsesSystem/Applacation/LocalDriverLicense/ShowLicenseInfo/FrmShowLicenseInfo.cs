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

namespace DriverLincsesSystem.Applacation.LocalDriverLicense.ShowApplicationInfo
{
    public partial class FrmShowLicenseInfo : Form
    {
        private ClsLocalDrivingLicenseApplications _localDrivingApplication;
        public FrmShowLicenseInfo(int LocalDrivingApplication)
        {
            InitializeComponent();

            _localDrivingApplication = ClsLocalDrivingLicenseApplications.Find(LocalDrivingApplication);
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowLicenseInfo_Load(object sender, EventArgs e)
        {
           if(!ctrShowLicenseDetails1._loadShowApplicationDetails(_localDrivingApplication))
            {
                this.Close();
            }

        }
    }
}
