using BusinessLayer;
using DriverLincsesSystem.Properties;
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
    public partial class FrmShowApplicationDetails : Form
    {

        private int _ApplicationID;
        public FrmShowApplicationDetails(int ApplicationID)
        {
            InitializeComponent();

            this._ApplicationID = ApplicationID;
        }


        private void _LoadDataApplicationInfoToform()
        {
            ClsApplications LoadApplication = ClsApplications.Find(_ApplicationID);

            if (LoadApplication == null)
            {
                Console.WriteLine("\a");
                MessageBox.Show("opps we can not load form", "Error", MessageBoxButtons.OK);

                this.Close();
                return; 
            }

            LabApplicationID.Text = LoadApplication.ApplactionID.ToString();
            LabFullname.Text = LoadApplication.PersonInfo.FullName();
            labBirthday.Text = LoadApplication.PersonInfo.DateOfBirth.ToShortDateString();
            LabStatus.Text = LoadApplication.ApplicationStatus == 1 ? "New" :
            LoadApplication.ApplicationStatus == 2 ? "Canceled" : "Completed";
            LabApplicationType.Text = clsApplicationTypes.GetApplicationTypeName(LoadApplication.ApplicationTypeID);
            labLastDateStatus.Text = LoadApplication.LastStatusDate.ToShortDateString();    
            labNationalNumber.Text = LoadApplication.PersonInfo.NationalNo;
            LabGendor.Text = LoadApplication.PersonInfo.Gendor == 0 ? "Male" : "Female";
            labAppliactionDate.Text = LoadApplication.ApplicationDate.ToShortDateString();
            LabCreateByUser.Text = ClsUsers.GetUserName(LoadApplication.CreatedByUserID);

            if (string.IsNullOrEmpty(LoadApplication.PersonInfo.ImagePath))

                imgPerson.Image = Resources.Man_321;
            else
                imgPerson.ImageLocation = LoadApplication.PersonInfo.ImagePath;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            _LoadDataApplicationInfoToform();
        }
    }
}
