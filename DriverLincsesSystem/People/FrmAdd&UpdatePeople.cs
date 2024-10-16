using BusinessLayer;
using DriverLincsesSystem.GlobleClasses;
using DriverLincsesSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.People
{
    public partial class FrmAdd_UpdatePeople : Form
    {

        public delegate void DataBackAHandling(object sender, int personID);

        public event DataBackAHandling DataBackPeronID;

        private int _PersonID = -1;
        private ClsPeople _Person = new ClsPeople();

        enum eMode { eAddNew = 0, eUpdate = 1 }

        private eMode _Mode = eMode.eAddNew;
        public FrmAdd_UpdatePeople()
        {
            InitializeComponent();
            this.Text = "Add New Person";
        }

        public FrmAdd_UpdatePeople(int PersonID)
        {
            InitializeComponent();

            if(PersonID < 0) return;

            this._PersonID = PersonID;

            _Mode = eMode.eUpdate;
            this.Text = "Edit Person";



        }


        private void _LoadCommBox()
        {
            DataTable dtCommBox = clsCountries.GetAllCountries();

            foreach (DataRow dr in dtCommBox.Rows)
            {

                CBCountry.Items.Add(dr["CountryName"].ToString());
            }
        }

        private void _ResetDefult()
        {
            
            labPersonID.Text = "[??]";
            TBFirstname.Text = "";
            TBLastname.Text = "";
            TBEmail.Text = "";
            TBAddress.Text = "";
            TBNationalNum.Text = "";
            DTBirthDay.MaxDate = DateTime.Now.AddYears(-18);
            DTBirthDay.MinDate = DateTime.Now.AddYears(-70);
            DTBirthDay.Value = DTBirthDay.MaxDate;
            TBPhone.Text = "";
            PBImgPeople.Image = Resources.Male_512;
            RBmale.Checked = true;
            CBCountry.SelectedIndex = 0;
            LabRemoveImg.Visible = false;
        }
        private void _loadDataOfPeople()
        {
          
                if (_Person == null)
                {
                    MessageBox.Show("Erorr You can not Arrive this Person From Peopel !!");
                    return;
                }
                
               
                labPersonID.Text = _Person.GetPersonID().ToString();
                TBFirstname.Text = _Person.FirstName.Trim();
                TBLastname.Text = _Person.LastName.Trim();
                TBEmail.Text = _Person.Email.Trim();   
                TBNationalNum.Text = _Person.NationalNo.Trim();
                TBAddress.Text = _Person.Address.Trim();
                TBPhone.Text = _Person.Phone.Trim();
                DTBirthDay.Value = _Person.DateOfBirth;
                CBCountry.Text = clsCountries.GetCountryName((byte)_Person.NationalityCountryID);

                if (_Person.Gendor == 0)
                    RBmale.Checked = true;
                else
                    RBFemale.Checked = true;

                if(_Person.ImagePath == "")
                {
                    if(RBmale.Checked)
                    PBImgPeople.Image = Resources.Male_512;
                    else
                    PBImgPeople.Image = Resources.Female_512;


                    LabRemoveImg.Visible = false;

                }else
                {
                    PBImgPeople.ImageLocation = _Person.ImagePath;
                    LabRemoveImg.Visible = true;

                }
            
        }

        private void FrmAdd_UpdatePeople_Load(object sender, EventArgs e) { 
         

            _LoadCommBox();
            _ResetDefult();
            _Add_UpdatePerson();
            if (_Mode == eMode.eUpdate)
            {
                _loadDataOfPeople();
            }
        }


        private void _Add_UpdatePerson()
        {
            if (_Mode == eMode.eAddNew)
            {
                LabTitleMode.Text = "Add New Person";
                return;
            }

            if (ClsPeople.IsExistsPeople(_PersonID))
            {
            _Person = ClsPeople.Find(_PersonID);

            if(_Person == null)
            {
                MessageBox.Show("Error This Poeple Is not Exist");
                _ResetDefult();
                return;
            }
            LabTitleMode.Text = "Edit Person";

            }

        }

     
        private void _Saveing()
        {
            _Add_UpdatePerson();

            
            _Person.FirstName = TBFirstname.Text.Trim();
            _Person.LastName = TBLastname.Text.Trim();
            _Person.NationalNo = TBNationalNum.Text.Trim();
            _Person.Address = TBAddress.Text.Trim();
            _Person.Email = TBEmail.Text.Trim();
            _Person.DateOfBirth = Convert.ToDateTime(DTBirthDay.Value.ToShortDateString());
            _Person.Gendor = (byte)((RBmale.Checked) ? 0 : 1);
            _Person.Phone = TBPhone.Text.Trim();
            _Person.NationalityCountryID = clsCountries.GetCountryID(CBCountry.Text);

            if (string.IsNullOrEmpty(PBImgPeople.ImageLocation))
            {
                _Person.ImagePath = "";
            }
            else
            {
                _Person.ImagePath = PBImgPeople.ImageLocation;
            }



            if (_Person.Save())
            {
                MessageBox.Show("Save Is Sccessfully :D");

                // return PersonID To any form Progress
                DataBackPeronID?.Invoke(this, _Person.GetPersonID());
            }
            else
            {
                MessageBox.Show("Error at Save :G","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            LabTitleMode.Text = "Edit Person";
            _Mode = eMode.eUpdate;


        }

        private bool _ImageHandling()
        {
            //block of Code Handlig copy Image In Folder Project Image

            if(_Person.ImagePath != PBImgPeople.ImageLocation)
            {

                if(_Person.ImagePath != "")
                {
                    File.Delete(_Person.ImagePath);
                    return true;
                }
            }

            if (PBImgPeople.ImageLocation != null)
            {
                string sourceFile = PBImgPeople.ImageLocation;
                if (ClsUtil.CopyImageToFolderX(ref sourceFile))
                {
                    PBImgPeople.ImageLocation = sourceFile;
                    return true;
                }

                MessageBox.Show("Erorr At Save Image ");

            }

            return false;
        }
        private void btnSavePeople_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            if(!_ImageHandling()) return;

            _Saveing();

            if (_Mode == eMode.eUpdate)
                _loadDataOfPeople();
        }
        private void LabRemoveImg_Click(object sender, EventArgs e)
        {
            PBImgPeople.ImageLocation = null;

            if (RBmale.Checked)
            {
                PBImgPeople.Image = Resources.Male_512;
            }
            else
            {
                PBImgPeople.Image = Resources.Female_512;

            }

            LabRemoveImg.Visible=false;
        }

        private void LabSetImag_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Title = "Set Image";
            openFileDialog1.Filter = "image All |*.png;*.jpg;*.tiff;*.ai;*.Row";
            openFileDialog1.FilterIndex = 0;

            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                PBImgPeople.ImageLocation = openFileDialog1.FileName.Trim();
            }

            LabRemoveImg.Visible = true;
        }
        private void RBmale_CheckedChanged(object sender, EventArgs e)
        {
            PBImgPeople.Image = Resources.Male_512;
        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            PBImgPeople.Image = Resources.Female_512;

        }

        // Validation checking

        private void ValidationStringInput(TextBox sender , CancelEventArgs e )
        {
            if (ClsValidation.ValidateStringIsEmpty(sender.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(sender, "Enter Valid Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(sender, null);
            }

        }

        private void TBFirstname_Validating(object sender, CancelEventArgs e)
        {

            ValidationStringInput((TextBox)sender, e);

        }

        private void TBAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidationStringInput((TextBox)sender, e);
        }

        private void TBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TBLastname_Validating(object sender, CancelEventArgs e)
        {
            ValidationStringInput((TextBox)sender, e);

        }

        private void TBNationalNum_Validating(object sender, CancelEventArgs e)
        {
            if(_Mode == eMode.eUpdate && (_Person.NationalNo == TBNationalNum.Text))
            {
                return;
            }

            if(ClsValidation.ValidateStringIsEmpty(TBNationalNum.Text) 
                || ClsPeople.IsExistsNationalNO(TBNationalNum.Text))
            {
                e.Cancel=true;
                errorProvider1.SetError(TBNationalNum, "This National Number Already Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBNationalNum,null);
            }
        }

        private void TBEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!ClsValidation.ValidationEmail(TBEmail.Text))
            {
                e.Cancel=true;
                errorProvider1.SetError(TBEmail, "This Email is not match the protocol");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBEmail, null);

            }
        }

        private void TBPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidationStringInput((TextBox)sender, e);
        }

        private void btnClosePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
