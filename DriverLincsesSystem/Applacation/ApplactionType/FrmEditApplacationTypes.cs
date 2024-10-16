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

namespace DriverLincsesSystem.Applacation.ApplactionType
{
    public partial class FrmEditApplacationTypes : Form
    {
        private int _AppTypeID=-1;

        private clsApplicationTypes _ObjAppType;
        public FrmEditApplacationTypes(int AppTypeID)
        {
            InitializeComponent();

            this._AppTypeID = AppTypeID;


        }



        private void _ResetDefualt()
        {
            if (clsApplicationTypes.IsExistsApplicationTypes(this._AppTypeID))
            {

                _ObjAppType = clsApplicationTypes.Find(_AppTypeID);

                if (_ObjAppType == null)
                {
                    MessageBox.Show("This Information Is Not Found ,Erorr Inside system");
                    this.Close();
                    return;
                }

                LabApplacationTypeID.Text = _ObjAppType.ApplicationTypeID.ToString();
                TBApplacitionTypeTitle.Text = _ObjAppType.ApplicationTypeTitle.Trim();
                TBFees.Text = _ObjAppType.ApplicationFees.ToString().Trim();

                return;
            }


            MessageBox.Show($"Type ID of ({this._AppTypeID}) Is Not Exist ");
        }
        private void btnCloseFrmEditeAppType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditApplacationTypes_Load(object sender, EventArgs e)
        {
            _ResetDefualt();
        }

        private void BtnSaveAppType_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren()) return;

            _ObjAppType.ApplicationTypeTitle = TBApplacitionTypeTitle.Text.Trim();
            _ObjAppType.ApplicationFees = Convert.ToDecimal(TBFees.Text);

            if (_ObjAppType.Save())
            {
                LabMessageError.Visible = true;
            }
            else
            {
                LabMessageError.Visible = true;

                LabMessageError.Text = "Fial To Save Edit :G";
                LabMessageError.ForeColor = Color.Red;

            }
        }

        private void TBApplacitionTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (ClsValidation.ValidateStringIsEmpty(TBApplacitionTypeTitle.Text) )
            {
                e.Cancel = true;

                errorProvider1.SetError(TBApplacitionTypeTitle, "Please Enter Title");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBApplacitionTypeTitle, "");

            }
        }

        private void TBFees_Validating(object sender, CancelEventArgs e)
        {


            if (ClsValidation.ValidateStringIsEmpty(TBFees.Text) || !ClsValidation.IsNumber(TBFees.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(TBFees, "Please Enter Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBFees, "");

            }
        }
    }
}
