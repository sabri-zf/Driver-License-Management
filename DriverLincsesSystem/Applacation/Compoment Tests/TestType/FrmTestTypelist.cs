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

namespace DriverLincsesSystem.Applacation.TestType
{
    public partial class FrmTestTypelist : Form
    {
        public FrmTestTypelist()
        {
            InitializeComponent();
        }

        private void btnCloseFrmAppType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTestTypelist_Load(object sender, EventArgs e)
        {
            DataTable dtTestTypes = ClsTestTypes.GetAllTestTypes();

            dgvTestTypeList.DataSource = dtTestTypes.DefaultView;

            LabTotalTestType.Text = dgvTestTypeList.Rows.Count.ToString();

            if (dgvTestTypeList.Rows.Count > 0)
            {
                dgvTestTypeList.Columns[0].HeaderText = "Type ID";
                dgvTestTypeList.Columns[0].Width = 100;

                dgvTestTypeList.Columns[1].HeaderText = "Title";
                dgvTestTypeList.Columns[1].Width = 130;

                dgvTestTypeList.Columns[3].HeaderText = "Fees";
                dgvTestTypeList.Columns[3].Width = 100;
            }


        }

        private void dgvTestTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmEditTestType testType = new FrmEditTestType((int) dgvTestTypeList.CurrentRow.Cells[0].Value);
            testType.ShowDialog();

        }

       

      
    }
}
