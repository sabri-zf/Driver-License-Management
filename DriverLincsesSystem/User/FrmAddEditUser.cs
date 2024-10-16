using BusinessLayer;
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
using System.Xml.Schema;

namespace DriverLincsesSystem.User
{
    public partial class FrmAddEditUser : Form
    {

        private int _PersonID = -1;

        private enum Emode { eAddNew,eEdit}
        private Emode _mode;


       private ClsUsers _Users;
        private int _UserID;
        public FrmAddEditUser()
        {
            InitializeComponent();

            _Users = new ClsUsers();
            this._UserID = -1;
            this._mode = Emode.eAddNew;
            LabTitleMode.Text = "Add User";
            this.Text = "Add User";
        }


        public FrmAddEditUser(int UserID)
        {
            InitializeComponent();

            this._UserID = UserID;
            this._mode = Emode.eEdit;
            this.LabTitleMode.Text = "Edit User";
            this.Text = "Edit User";

        }


        private void _ResetToDefualt()
        {

            if (_mode == Emode.eEdit)
            {
                PLUserInfo.Enabled = true;
                btnSaveUser.Enabled = true;
            }
            else
            {
                PLUserInfo.Enabled = false;
                btnSaveUser.Enabled = false;
            }

            ctrCardPersonWithFilter2._ResetControl();
            LabUserID.Text = string.Empty;
            TBUserName.Clear();
            TBNewPassword.Clear();
            TBConfirmPassword.Clear();
            ChB_IsActive.Checked = false;

        }

        private void _LoadUserinforamtion()
        {
            if (ClsUsers.IsExistsUsers(this._UserID))
            {

                _Users = ClsUsers.Find(this._UserID);


                if (_Users == null)
                {
                    MessageBox.Show("Erorr From Set Obeject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctrCardPersonWithFilter2.FilterEnable = false;
                ctrCardPersonWithFilter2.GetDataOfIdPerson(this, _Users.PersonID);

                LabUserID.Text = _Users.UserID.ToString().Trim();
                TBUserName.Text = _Users.UserName.Trim();
                TBNewPassword.Text = _Users.Password.Trim();
                TBConfirmPassword.Text = _Users.Password.Trim();
                ChB_IsActive.Checked = _Users.IsActive;

            }
            else
            {
                if (MessageBox.Show("Error This User Is Not Found In System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }


        }

        private void  ValidationString(TextBox TB, CancelEventArgs e)
        {

            if (ClsValidation.ValidateStringIsEmpty(TB.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(TB, "You can not type Empty Box");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(TB, null);
            }
            
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void FrmAddEditUser_Load(object sender, EventArgs e)
        {

            _ResetToDefualt();

            if (_mode == Emode.eEdit)
            {
               _LoadUserinforamtion();
            }

        }

        private void ToSaved()
        {


            if (TBNewPassword.Text.Trim() != TBConfirmPassword.Text.Trim())
            {
                MessageBox.Show("the password is not integrety with confirm");
                return;
            }

            _Users.UserName = TBUserName.Text.Trim();
            _Users.Password = TBNewPassword.Text.Trim();
            _Users.IsActive = ChB_IsActive.Checked;

            if (_mode != Emode.eEdit) _Users.PersonID = _PersonID;


            if (_Users.Save())
            {
                MessageBox.Show("save is done :d");

                this._UserID = _Users.UserID;
            }
            else
            {
                MessageBox.Show("save is fail :g");
            }


            _mode = Emode.eEdit;
            }
        private void ctrCardPersonWithFilter1_OnSelectedPerson_1(int obj)
        {
            _PersonID = obj;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            ToSaved();
              if(_mode == Emode.eEdit) _LoadUserinforamtion();


        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_mode != Emode.eEdit)
            {
                if (ClsUsers.IsExistsUsersByPersonID(_PersonID) || _PersonID == -1)
                {
                    MessageBox.Show("this Person already Exist");
                    _ResetToDefualt();
                    return;
                }
                else
                {
                    PLUserInfo.Enabled = true;
                    btnSaveUser.Enabled = true;
                }
            }


            tabControl1.SelectedIndex = 1;
        }

        private void TBUserName_Validating(object sender, CancelEventArgs e)
        {

            if(_Users.UserName == TBUserName.Text.Trim()) return;

            if (ClsUsers.IsExistsUsers(TBUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBUserName, "this user Already exist");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBUserName, null);
            }

            ValidationString((TextBox)sender, e);
        }

        private void TBNewPassword_Validating(object sender, CancelEventArgs e)
        {
           

            ValidationString((TextBox)sender, e);

        }

        private void TBConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidationString((TextBox)sender, e);
        }

      
    }
}
