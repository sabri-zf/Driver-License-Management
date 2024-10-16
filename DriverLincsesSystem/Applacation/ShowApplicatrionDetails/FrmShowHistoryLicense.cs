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

namespace DriverLincsesSystem.Applacation.ShowApplicatrionDetails
{
    public partial class FrmShowHistoryLicense : Form
    {

        private int Application_ID;
        private int DriverID ;
        public FrmShowHistoryLicense(int ApplicationID)
        {
            InitializeComponent();
            this.Application_ID = ApplicationID;
        }

        private void btnClosePageLocalDrivingApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void LoadPersonInfo()
        {
            int perisnID = ClsApplications.Find(Application_ID).ApplicantPersonID;
            DriverID = ClsDrivers.FindByPersonID(perisnID).DriverID;
            ctrCardPerson1._loadPersonCard(perisnID);
        }



        private void _LoadTRecordLocal()
        {

             DataTable EditView = ClsLicenses.GetAllHistoryLicenseDetails(DriverID).DefaultView.ToTable(false, "LicenseID","ApplicationID","ClassName","IssueDate","ExpirationDate","IsActive");
            DgvLocalHistory.DataSource = EditView.DefaultView;

            if (DgvLocalHistory.Rows.Count > 0)
            {
                DgvLocalHistory.Columns[0].HeaderText = "Licens ID";
                DgvLocalHistory.Columns[0].Width = 100;

                DgvLocalHistory.Columns[1].HeaderText = "App ID";
                DgvLocalHistory.Columns[1].Width = 100;

                DgvLocalHistory.Columns[5].HeaderText = "Is Active";
                DgvLocalHistory.Columns[5].Width = 100;
            }

            labTotalLocalLicense.Text = DgvLocalHistory.Rows.Count.ToString();
        }

        private void _LoadTRecordInternationall()
        {
            DgvInternationalHistory.DataSource = clsInternationalLicenses.GetAllHistoryLinceseDetils(DriverID).DefaultView;

            if(DgvInternationalHistory.Rows.Count > 0)
            {
                DgvInternationalHistory.Columns[0].HeaderText = "IN_License";
                DgvInternationalHistory.Columns[0].Width = 80;

                DgvInternationalHistory.Columns[1].HeaderText = "App ID";
                DgvInternationalHistory.Columns[1].Width = 80;

                DgvInternationalHistory.Columns[2].HeaderText = "Local Linces";
                DgvInternationalHistory.Columns[2].Width = 100;

                DgvInternationalHistory.Columns[5].HeaderText = "Is Active";
                DgvInternationalHistory.Columns[5].Width = 100;
            }

            LabTotalInternationalLicense.Text = DgvInternationalHistory.Rows.Count.ToString();
        }

        private void TabHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TabHistory.SelectedIndex == 0)
            {
                _LoadTRecordLocal();
            }
            else
            {
                _LoadTRecordInternationall();

            }

        }

        private void FrmShowHistoryLicense_Load(object sender, EventArgs e)
        {
            LoadPersonInfo();
            TabHistory.SelectedIndex = 0;
            TabHistory_SelectedIndexChanged(null,null);
        }

    }
}
