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

namespace DriverLincsesSystem.User.UC
{
    public partial class ctrChangePassword : UserControl
    {
        public ctrChangePassword()
        {
            InitializeComponent();
        }


        private void _Reset()
        {
            TBConfirmPassword.Clear();
            TBCurrentPassword.Clear();
            TbNewPassword.Clear();
        }
        public void ChangePassword(ClsUsers user)
        {
            if (user.Password.Trim() == TBCurrentPassword.Text.Trim())
            {
                if (TbNewPassword.Text.Trim() == TBConfirmPassword.Text.Trim())
                {
                    user.Password = TbNewPassword.Text.Trim();

                    if (user.Save())
                    {
                        MessageBox.Show("Save Seccssfully :D", "Congratolation");
                        ClsSetting.logInUser = user;
                        return;
                    }

                    MessageBox.Show("Error Inside Your system Please Contact Mantinens");
                }
                else
                {
                    MessageBox.Show("Please Check your New password is Not \n agree with Confiram password", "Error");
                    _Reset();
                }
            }
            else
            {
                MessageBox.Show("Current Password Is Not Correct");
                _Reset();
            }
        }

        private void _ValidateText(TextBox sender, CancelEventArgs e)
        {
            if (ClsValidation.ValidateStringIsEmpty(sender.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(sender, "Plases don't quit field Empty");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(sender,null);
            }
        }
        private void TBCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            _ValidateText((TextBox)sender, e);


        }

        private void TbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidateText((TextBox)sender, e);

        }

        private void TBConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidateText((TextBox)sender, e);
        }
    }
}
