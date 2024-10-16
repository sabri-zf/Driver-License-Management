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

namespace DriverLincsesSystem.User.UC
{
    public partial class CtrUserCard : UserControl
    {
        public CtrUserCard()
        {
            InitializeComponent();
        }




        public void ShowUser(ClsUsers User)
        {

            labUserID.Text = User.UserID.ToString().Trim();
            labUserName.Text = User.UserName.ToString().Trim();
            labIsActive.Text = (User.IsActive == true) ? "Yes" : "No";
            ctrCardPerson1._loadPersonCard(User.PersonID);

        }

    }
}
