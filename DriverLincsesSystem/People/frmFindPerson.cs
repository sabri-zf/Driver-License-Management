using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.People
{
    public partial class frmFindPerson : Form
    {

        public delegate void FrmFindPersonHandling(object sender, int PersonID);

        public event FrmFindPersonHandling DataBakPeronsID;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClosePage_Click(object sender, EventArgs e)
        {
            DataBakPeronsID?.Invoke(sender, ctrCardPersonWithFilter1.personID);
            this.Close();
        }
    }
}
