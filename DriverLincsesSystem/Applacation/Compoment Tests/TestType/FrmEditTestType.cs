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

namespace DriverLincsesSystem.Applacation.TestType
{
    public partial class FrmEditTestType : Form
    {

        private int _TestTypeID = -1;
        private ClsTestTypes _ObjTestType;
        public FrmEditTestType(int TestTypeID)
        {
            InitializeComponent();

            this._TestTypeID = TestTypeID;
        }

        private bool CheckDefualtInput()
        {
            if (_ObjTestType != null)
            {

                return ((TBTestTitle.Text.Trim() == _ObjTestType.TestTypeTitle.Trim())
                     && (TBDescription.Text.Trim() == _ObjTestType.TestTypDescription.Trim())
                      && (TBFees.Text.Trim() == Convert.ToSingle(_ObjTestType.TestTypeFees).ToString().Trim()));

            }

            return false;
        }

        private void btnCloseFrmEditeAppType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditTestType_Load(object sender, EventArgs e)
        {
            if (ClsTestTypes.IsExistTestTypes(_TestTypeID))
            {

                _ObjTestType = ClsTestTypes.FindByID(_TestTypeID);

                if (_ObjTestType == null)
                {
                    MessageBox.Show("Error Member Is not Found");
                    this.Close();
                    return;
                }


                LabTestTypeID.Text = _ObjTestType.TestTypeID.ToString();
                TBTestTitle.Text = _ObjTestType.TestTypeTitle.Trim();
                TBDescription.Text = _ObjTestType.TestTypDescription.Trim();
                TBFees.Text = Convert.ToSingle(_ObjTestType.TestTypeFees).ToString().Trim();

            }
            else
            {
                MessageBox.Show("This Test Type Filed Is Not Exist ");
                this.Close();
            }
        }

        private void BtnSaveAppType_Click(object sender, EventArgs e)
        {

            if(!this.ValidateChildren()) return;


            _ObjTestType.TestTypeTitle = TBTestTitle.Text.Trim();
            _ObjTestType.TestTypDescription = TBDescription.Text.Trim();
            _ObjTestType.TestTypeFees = Convert.ToDecimal(TBFees.Text.Trim());

            if (_ObjTestType.Save())
            {
                MessageBox.Show("Save Succesfully");

            }
            else
            {
                MessageBox.Show("Save Fial");
            }

        }

        private void TBTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if(CheckDefualtInput()) return;


            if (ClsValidation.ValidateStringIsEmpty(TBTestTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBTestTitle, "Can Not catch Feild Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBTestTitle,"");
            }

        }

        private void TBDescription_Validating(object sender, CancelEventArgs e)
        {
            if (CheckDefualtInput()) return;


            if (ClsValidation.ValidateStringIsEmpty(TBDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBDescription, "Can Not catch Feild Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBDescription, "");
            }

        }

        private void TBFees_Validating(object sender, CancelEventArgs e)
        {

            if (CheckDefualtInput()) return;


            if (ClsValidation.ValidateStringIsEmpty(TBFees.Text) || !ClsValidation.IsNumber(TBFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBFees, "Can Not catch Feild Empty and Plases Enter Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBFees, "");
            }

        }
    }
}
