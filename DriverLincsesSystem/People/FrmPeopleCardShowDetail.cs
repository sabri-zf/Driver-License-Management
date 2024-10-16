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
    public partial class FrmPeopleCardShowDetail : Form
    {
        public FrmPeopleCardShowDetail(int person)
        {
            InitializeComponent();
          if(person >0)
                ctrCardPerson1._loadPersonCard(person);

        }

        public FrmPeopleCardShowDetail(string NationalNumber)
        {
            InitializeComponent();
            if (NationalNumber != "")
                ctrCardPerson1._loadPersonCard(NationalNumber);
        }

        private void FrmPeopleCardShowDetail_Load(object sender, EventArgs e)
        {
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
