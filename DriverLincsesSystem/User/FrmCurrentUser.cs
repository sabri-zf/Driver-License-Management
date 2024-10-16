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

namespace DriverLincsesSystem.User
{
    public partial class FrmCurrentUser : Form
    {
        public FrmCurrentUser(int UserID)
        {
            InitializeComponent();

            ClsUsers user = ClsUsers.Find(UserID);

            if(user != null ) 
            ctrUserCard1.ShowUser(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
