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

namespace DriverLincsesSystem.Drivers
{
    public partial class FrmDriverList : Form
    {

        private DataTable dtDrivers = ClsDrivers.GetAllDriver(); 
        public FrmDriverList()
        {
            InitializeComponent();
        }


        private void _LoadDrivers()
        {
            dgvListDrivers.DataSource = dtDrivers.DefaultView.ToTable(false, "DriverID", "FullName", "PersonID");

            LabTotalDriver.Text = dgvListDrivers.Rows.Count.ToString();

            if (dgvListDrivers.Rows.Count > 0)
            {
                dgvListDrivers.Columns[0].HeaderText = "Driver ID";
                dgvListDrivers.Columns[0].Width = 120;

                dgvListDrivers.Columns[2].HeaderText = "Person ID";
                dgvListDrivers.Columns[2].Width = 120;

                dgvListDrivers.Columns[1].HeaderText = "Full Name";
                dgvListDrivers.Columns[1].Width = 300;
            }


        }
        private void btnCloseFrmDriver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDriverList_Load(object sender, EventArgs e)
        {
            _LoadDrivers();
        }
    }
}
