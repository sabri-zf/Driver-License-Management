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
using System.IO;
using Microsoft.Win32;

namespace DriverLincsesSystem.User
{
    public partial class FrmLogInScreen : Form
    {

        public FrmLogInScreen()
        {
            InitializeComponent();
        }

        private void FrmLogInScreen_Load(object sender, EventArgs e)
        {
            GetRemember();
        }


        private void GetRemember()
        {
            ///<summary> this is  old Code to Get Remimber of User login</summary>

            //string value = _loadDataFromFile();

            //string[]list = value.Split('/');
            //if (list[0] == "1")
            //{
            //    CBRememberMe.Checked = true;
            //    TBUserName.Text = list[1];
            //    TBPassword.Text = list[2];
            //}
            //else
            //{
            //    _ResetScreen();
            //}

            //if(!CBRememberMe.Checked) return;

            try
            {
                string StatusOfRemember = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting"
                                            , "CheckRemember", null) as string;

                if(StatusOfRemember == null) return;

                if(StatusOfRemember == "True")
                {
                    CBRememberMe.Checked = true;
                string UserName = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting"
                                            , "UserName", null) as string;
                string Password = ClsUtil.DecrepteData(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting"
                                           , "Password", null) as string);

                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                {
                    TBUserName.Text = UserName;
                    TBPassword.Text = Password;
                }

                return;
                }

                _ResetScreen();

            }
            catch 
            {
                MessageBox.Show("Error From Load Remember User Log in","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
        private void _ResetScreen()
        {
            TBUserName.Clear();
            TBPassword.Clear();
            CBRememberMe.Checked = false;
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        [Obsolete("this Code is not Run Now",false)]
        private string _loadDataFromFile()
        {
                    string Line = "";

            try
            {

                if (File.Exists(ClsSetting.FilePath))
                {

                    StreamReader Sr = new StreamReader(ClsSetting.FilePath);

                   
                       Line =  ClsUtil.DecrepteData(Sr.ReadLine());
                    


                Sr.Close();
                return Line;
                }
               
                    
            }catch
            {

            }

            return string.Empty;
        }
        [Obsolete("this Code is not Run Now", false)]
        private void WriteDataFromFile(string DataToFile)
        {

            try
            {
                if (!File.Exists(ClsSetting.FilePath))
                {
                    File.Create(ClsSetting.FilePath);
                }

                using (StreamWriter WriteDataUser =  new StreamWriter(ClsSetting.FilePath,false))
                {
                    WriteDataUser.WriteLine(ClsUtil.encrepteData(DataToFile));
                }
            }catch 
            {

            }


        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void _SaveInfoAtFile()
        {
            string Load = _loadDataFromFile();

            if (!CBRememberMe.Checked)
            {
                //if(Load == ("1/" + TBUserName.Text +"/"+ TBPassword.Text))
                //{
                //    return;
                //}

                //WriteDataFromFile(("1/"+TBUserName.Text + "/" + TBPassword.Text));
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting", "CheckRemember", CBRememberMe.Checked, RegistryValueKind.String);
                return;

            }

            //WriteDataFromFile(("0/" + TBUserName.Text + "/" + TBPassword.Text));try{
            
            try
            {
               
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting", "UserName", TBUserName.Text,RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting", "Password", ClsUtil.encrepteData(TBPassword.Text), RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\DrivingLicense\Setting", "CheckRemember", CBRememberMe.Checked,RegistryValueKind.String);
                

            }catch
            {
                MessageBox.Show("Can't Save The Infon User");
            }
            

        }
        private void RememberYourUserNameAndPassword()
        {
               _SaveInfoAtFile();
        }
        private bool CheckCorrectSignIn()
        {
            if (ClsUsers.IsExistsUsers(TBUserName.Text.Trim()))
            {
               ClsUsers infoUser = ClsUsers.FindUserNameAndPassword(TBUserName.Text.Trim(),TBPassword.Text.Trim());

                if (infoUser != null)
                {
                    if (infoUser.IsActive)
                    {
                        RememberYourUserNameAndPassword();

                        ClsSetting.logInUser = infoUser;
                    
                    } else
                    {
                        MessageBox.Show("This User Is not Active in system pleses contact Adminstration ", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return true;
                       
                }

                MessageBox.Show("Incorrect User Name or Password Please Try Again");
                return false;
            }


            MessageBox.Show("UserName Is Not Exist inside System");

            return false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckCorrectSignIn())
            {
            DialogResult = DialogResult.OK;

            }
        }

    }
}
