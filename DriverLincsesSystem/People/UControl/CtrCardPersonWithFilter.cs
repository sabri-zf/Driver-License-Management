using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverLincsesSystem.People.UControl
{
    public partial class CtrCardPersonWithFilter : UserControl
    {

        public event Action<int> OnSelectedPerson;
        protected virtual void PersonSelected(int personID)
        {
            Action<int> Handle = OnSelectedPerson;

            if (Handle != null)
            {
                Handle(personID);
            }
        }

        public CtrCardPersonWithFilter()
        {
            InitializeComponent();
        }

        private bool _AddNewPerson = true;
        public bool AddNewPerson
        {
            get { return _AddNewPerson; }
            set { 
                _AddNewPerson = value;
                btnAddNew.Visible = _AddNewPerson;
                 }
        }
        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get { return _FilterEnable; }

            set { _FilterEnable = value;
                panel1.Enabled = _FilterEnable;
            }
        }

        public int personID
        {
            get { return ctrCardPerson1.PersonID; }
        }
        public ClsPeople SelectedPeople
        {
            get { return ctrCardPerson1.PersonInfo;}
        }

        public void _ResetControl()
        {
            TBFilterInput.Clear();
            CBFilterPerson.SelectedIndex = 0;

        }
        private void CtrCardPersonWithFilter_Load(object sender, EventArgs e)
        {
            _ResetControl();

        }
        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAdd_UpdatePeople AddNewPerson = new FrmAdd_UpdatePeople();
            AddNewPerson.DataBackPeronID += GetDataOfIdPerson;
            AddNewPerson.Show();
            panel1.Enabled = false;
        }

        public void GetDataOfIdPerson(object sender,int PeronID)
        {
            TBFilterInput.Text = PeronID.ToString();
            ctrCardPerson1._loadPersonCard(PeronID);

            if (OnSelectedPerson != null)
            {
                OnSelectedPerson(PeronID);
            }
        }

        private void TBFilterInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar == (char)13)
            {
                btnSerch.PerformClick();
                return;
            }

            if(CBFilterPerson.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (CBFilterPerson.Text == "Person ID")
            {

                ctrCardPerson1._loadPersonCard(Convert.ToInt32(TBFilterInput.Text.Trim()));
            }
            else
            {

            ctrCardPerson1._loadPersonCard(TBFilterInput.Text.Trim());
            }



            if (OnSelectedPerson != null && FilterEnable)
            {
                PersonSelected(ctrCardPerson1.PersonID);
            }

        }
    }
}
