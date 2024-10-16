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

namespace DriverLincsesSystem.Applacation.ApplactionType
{
    public partial class FrmApplactionType : Form
    {

        public FrmApplactionType()
        {
            InitializeComponent();
        }

        private void _loadApplactionType()
        {
         DataTable _dtApplactionTypes = clsApplicationTypes.GetAllApplicationTypes();

        dgvApplacitonType.DataSource = _dtApplactionTypes.DefaultView;

            LabTotalAppType.Text = dgvApplacitonType.Rows.Count.ToString();

            if(LabTotalAppType.Text != "0")
            {
                dgvApplacitonType.Columns[0].HeaderText = "App Type ID";
                dgvApplacitonType.Columns[0].Width = 120;

                dgvApplacitonType.Columns[1].HeaderText = "Title";

                dgvApplacitonType.Columns[2].HeaderText = "Fees";
                dgvApplacitonType.Columns[2].Width = 120;
            }


        }

        private void btnCloseFrmAppType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmApplactionType_Load(object sender, EventArgs e)
        {
            _loadApplactionType();
        }

        private void dgvApplacitonType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditApplacationTypes EditAppType = new FrmEditApplacationTypes((int)dgvApplacitonType.CurrentRow.Cells[0].Value);
            EditAppType.ShowDialog();

           FrmApplactionType_Load(null,null);

        }
    }
}
