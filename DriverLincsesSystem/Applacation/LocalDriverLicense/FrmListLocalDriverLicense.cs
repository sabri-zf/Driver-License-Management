using BusinessLayer;
using DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.ParticalTest;
using DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.VisionTest;
using DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.WriteTest;
using DriverLincsesSystem.Applacation.LocalDriverLicense.IssueLicenseFirtsTime;
using DriverLincsesSystem.Applacation.LocalDriverLicense.NewLocalDriverLicense;
using DriverLincsesSystem.Applacation.LocalDriverLicense.ShowApplicationInfo;
using DriverLincsesSystem.Applacation.ShowApplicatrionDetails;
using DriverLincsesSystem.GlobleClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DriverLincsesSystem.Applacation.LocalDriverLicense
{
    public partial class FrmListLocalDriverLicense : Form
    {



        DataTable dt_L_D_LAppViww;
        
        public FrmListLocalDriverLicense()
        {
            InitializeComponent();
        }

        private void _loadCommbBox()
        {
           
            CBFilterOption.Items.Clear();

            CBFilterOption.Items.Add("None");
            CBFilterOption.Items.Add("L_DL_App");
            CBFilterOption.Items.Add(DGVLocalDrivingLicenseAppList.Columns[2].Name);
            CBFilterOption.Items.Add(DGVLocalDrivingLicenseAppList.Columns[3].Name);
            CBFilterOption.Items.Add(DGVLocalDrivingLicenseAppList.Columns[6].Name);

            CBFilterOption.SelectedIndex = 0;
        }

        private void _loadLocalDrivingLicnsesApp_View()
        {

             dt_L_D_LAppViww = ClsLocalDrivingLicenseApplications.FullDetailsApplicationType();

            DGVLocalDrivingLicenseAppList.DataSource = null;
            DGVLocalDrivingLicenseAppList.DataSource = dt_L_D_LAppViww.DefaultView;

            if (DGVLocalDrivingLicenseAppList.Rows.Count > 0)
            {
                DGVLocalDrivingLicenseAppList.Columns[0].HeaderText = "L_DL_App";
                DGVLocalDrivingLicenseAppList.Columns[0].Width = 100;

                DGVLocalDrivingLicenseAppList.Columns[1].HeaderText = "Class Name";
                DGVLocalDrivingLicenseAppList.Columns[1].Width = 200;

                DGVLocalDrivingLicenseAppList.Columns[2].HeaderText = "National N";
                DGVLocalDrivingLicenseAppList.Columns[2].Width = 100;
                
                DGVLocalDrivingLicenseAppList.Columns[3].HeaderText = "Full Name";

                DGVLocalDrivingLicenseAppList.Columns[4].HeaderText = "App Date";
                DGVLocalDrivingLicenseAppList.Columns[4].Width = 150;

                DGVLocalDrivingLicenseAppList.Columns[5].HeaderText = "Pass Test";
                DGVLocalDrivingLicenseAppList.Columns[5].Width = 80;

                DGVLocalDrivingLicenseAppList.Columns[6].HeaderText = "Status";
                DGVLocalDrivingLicenseAppList.Columns[6].Width = 100;

                LabTotalRecord.Text = DGVLocalDrivingLicenseAppList.Rows.Count.ToString();
            }

            }
            private void btnClosePageLocalDrivingApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListLocalDriverLicense_Load(object sender, EventArgs e)
        {
            _loadLocalDrivingLicnsesApp_View();
            _loadCommbBox();
        }

        private void TBInputFilter_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TBInputFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBInputFilter.Text))
            {
                _loadLocalDrivingLicnsesApp_View();
                return;
            }

            if (CBFilterOption.Text == "L_DL_App")
            {
                dt_L_D_LAppViww.DefaultView.RowFilter = string.Format("{0} = {1}", "LocalDrivingLicenseApplicationID", TBInputFilter.Text);
            }
            else
            {
                dt_L_D_LAppViww.DefaultView.RowFilter = string.Format("{0} like '{1}%'", CBFilterOption.Text, TBInputFilter.Text);
            }

            DGVLocalDrivingLicenseAppList.DataSource = dt_L_D_LAppViww.DefaultView;
            LabTotalRecord.Text = DGVLocalDrivingLicenseAppList.Rows.Count.ToString();

        }

        private void TBInputFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (CBFilterOption.Text == "L_DL_App")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            
        }

        private void CBFilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CBFilterOption.Text == "None")
            {
                TBInputFilter.Clear();
                TBInputFilter.Visible = false;
                return;
            }

            TBInputFilter.Clear();
            TBInputFilter.Visible = true;
            TBInputFilter.Focus();

        }

        private void PbAddNewLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApp NewLocal = new FrmLocalDrivingLicenseApp();
            NewLocal.ShowDialog();
            FrmListLocalDriverLicense_Load(null, null);
        }


        private void ConvertStatus()
        {
            ClsLocalDrivingLicenseApplications Local = ClsLocalDrivingLicenseApplications.Find((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);

            if (Local == null) {

                MessageBox.Show("We Can Not Access this application , Please Contact for Developer");
                return;
            }

            Local.ApplicationsInfo.ApplicationStatus = 2;

            if (Local.ApplicationsInfo.Save())
            {
                return;
            }

            MessageBox.Show("Error To Convert Status at Cancel ");
        }

 
        private void editAppliactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApp EditApploication = new FrmLocalDrivingLicenseApp((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            EditApploication.ShowDialog();
            _loadLocalDrivingLicnsesApp_View();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you Delete This Application","Attention",MessageBoxButtons.YesNo
                ,MessageBoxIcon.Warning)== DialogResult.Yes)
            {

                if(ClsLocalDrivingLicenseApplications.
                    DeleteLocalDrivingLicenseApplications((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK);
                }

            }
        }

        private void canceledApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure , need Canceled this application ? ", "question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConvertStatus();

                _loadLocalDrivingLicnsesApp_View();
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVisionTest NewVisionTest = new FrmVisionTest((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            NewVisionTest.ShowDialog();
            FrmListLocalDriverLicense_Load(null, null);
        }


        private void CheckCompletedTest()
        {
            switch ((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[5].Value)
            {
                case 1:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWriteTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWriteTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:

                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWriteTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicesnseFirstTimeToolStripMenuItem.Enabled = true;
                    break;
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string Case = (string)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[6].Value;
            

            if(Case != "New")
            {
                canceledApplicationToolStripMenuItem.Enabled = false;
                editAppliactionToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                issueDrivingLicesnseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                if (Case == "Completed")
                {
                    showLicenseToolStripMenuItem.Enabled = true;
                    issueDrivingLicesnseFirstTimeToolStripMenuItem.Enabled = false;
                }

            }
            else
            {
                canceledApplicationToolStripMenuItem.Enabled = true;
                editAppliactionToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                scheduleTestToolStripMenuItem.Enabled = true;
                issueDrivingLicesnseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                CheckCompletedTest();

            }



        }

        private void scheduleWriteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWriteTest NewWriteTest = new FrmWriteTest(localDrivingLiecnseID: (int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            NewWriteTest.ShowDialog();
            FrmListLocalDriverLicense_Load(null, null);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticalTest NewPartical = new FrmParticalTest((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            NewPartical.ShowDialog();
            FrmListLocalDriverLicense_Load(null, null);
        }

        private void issueDrivingLicesnseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueLinceseFirstTime CreateLicese = new FrmIssueLinceseFirstTime((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            CreateLicese.ShowDialog();
            FrmListLocalDriverLicense_Load(null, null);

        }

        private void showHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowHistoryLicense HisortyLicense = new FrmShowHistoryLicense(ClsLocalDrivingLicenseApplications.Find((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value).ApplicationID);
            HisortyLicense.ShowDialog();
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        FrmShowApplicationDetails AppDetails = new FrmShowApplicationDetails(ClsLocalDrivingLicenseApplications.Find((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value).ApplicationID);
            AppDetails.ShowDialog();
        }



        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowLicenseInfo ShowLicense = new FrmShowLicenseInfo((int)DGVLocalDrivingLicenseAppList.CurrentRow.Cells[0].Value);
            ShowLicense.ShowDialog();
        }
    }
}
