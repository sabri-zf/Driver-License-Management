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
    public partial class FrmUserList : Form
    {
        private DataTable DataUsers;
        public FrmUserList()
        {
            InitializeComponent();
        }

        // create Control In Run Time 
        private void CreateTexeBox()
        {
            TextBox TxtFilter = new TextBox();

            TxtFilter.Name = "TBFilter";
            TxtFilter.BackColor = Color.White;
            TxtFilter.BorderStyle = BorderStyle.FixedSingle;
            TxtFilter.Location = new System.Drawing.Point(395, 186);
            TxtFilter.Size = new System.Drawing.Size(300, 13);
            TxtFilter.Font = new Font("Segoe UI Semibold", 12, FontStyle.Regular);
            TxtFilter.TextChanged += TxtFilter_TextCheanged;
            TxtFilter.KeyPress += TxtFilter_KeyPress;
            TxtFilter.BringToFront();

            this.Controls.Add(TxtFilter);

        }

        private void DeleteTextBoxControl()
        {
            Control TextBox;

            TextBox = FindControlTextBoxInRunTime();

            TextBox.TextChanged -= TxtFilter_TextCheanged;
            TextBox.KeyPress -= TxtFilter_KeyPress;



            this.Controls.Remove(TextBox);
            TextBox.Dispose();
        }

        private Control FindControlTextBoxInRunTime()
        {
            Control TextBoxFilter = new Control();

            try
            {

                TextBoxFilter = this.Controls.Find("TBFilter", true).First();

            }
            catch
            {

            }

            return TextBoxFilter;
        }


        private void CreateComboBox()
        {
            ComboBox comboBox = new ComboBox();

            comboBox.Location = new System.Drawing.Point(395, 186);
            comboBox.Name = "CBFilterIsActive";
            comboBox.Size = new System.Drawing.Size(300, 13);
            comboBox.SelectedIndexChanged += FilterUser_Change;
            comboBox.Items.Add("All");
            comboBox.Items.Add("Yes");
            comboBox.Items.Add("No");
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(comboBox);

            comboBox.BringToFront();
        }

        private Control FindControlCBFilterIsActiveInRunTime()
        {
            Control CBFilteUser = new Control();

            try
            {

                CBFilteUser = this.Controls.Find("CBFilterIsActive", false).First();

            }
            catch
            {

            }

            return CBFilteUser;
        }

        private void DeleteCommBox()
        {
            Control ComBox= new Control();

            ComBox = FindControlCBFilterIsActiveInRunTime();

            if (ComBox != null)
            {
                
                this.Controls.Remove(ComBox);
                ComBox.Dispose();
            }
        }

        private void FilterUser_Change(object sender, EventArgs e) {

            Control control= FindControlCBFilterIsActiveInRunTime();

            if (control.Text == "All")
            {
                _loadData();
                return;
            }

                switch (control.Text)
                {
                    case "Yes":
                        DataUsers.DefaultView.RowFilter = "IsActive = 1";
                        dgvListUsers.DataSource = DataUsers.DefaultView;
                     break;

                    case "No":
                        DataUsers.DefaultView.RowFilter = "IsActive = 0";
                        dgvListUsers.DataSource = DataUsers.DefaultView;
                        break;
                   
                }

           labTotalUsers.Text = dgvListUsers.Rows.Count.ToString(); 

        }


        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CbFilrterUser.Text == "PersonID" || CbFilrterUser.Text == "UserID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }

        private void TxtFilter_TextCheanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(FindControlTextBoxInRunTime().Text))
            {
                _loadData();
                return;
            }

            _FilterUser();

        }

        private void _FilterUser()
        {
            if (CbFilrterUser.Text == "PersonID" || CbFilrterUser.Text == "UserID")
            {
                DataUsers.DefaultView.RowFilter = $"{CbFilrterUser.Text} = {FindControlTextBoxInRunTime().Text}";
            }else if(CbFilrterUser.Text != "IsActive")
            {
                DataUsers.DefaultView.RowFilter = $"{CbFilrterUser.Text} like '{FindControlTextBoxInRunTime().Text}%'";
            }

            dgvListUsers.DataSource = DataUsers.DefaultView;
            labTotalUsers.Text = dgvListUsers.Rows.Count.ToString();
        }

        // Load Data For DGV

        private void _LoadCommbox()
        {
            CbFilrterUser.Items.Add("None");
            foreach(DataColumn Col in DataUsers.Columns)
            {
                CbFilrterUser.Items.Add(Col.ColumnName);
            }

            CbFilrterUser.SelectedIndex = 0;
        }
        private void _loadData()
        {

            DataUsers = ClsUsers.GetAllUsersWithDetail();
            dgvListUsers.DataSource = DataUsers.DefaultView;

            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 110;
                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 110;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 200;

                dgvListUsers.Columns[3].HeaderText = "User Name";
                dgvListUsers.Columns[3].Width = 110;

                dgvListUsers.Columns[4].HeaderText = "Is Active";
                dgvListUsers.Columns[4].Width = 110;

            }

            labTotalUsers.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            _loadData();
            _LoadCommbox();
        }

        private void CbFilrterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbFilrterUser.Text == "None")
            {
                DeleteTextBoxControl();
                DeleteCommBox();
                return;   
            }

            if(CbFilrterUser.Text == "IsActive")
            {
                DeleteTextBoxControl();
                CreateComboBox();
            }
            else
            {
                DeleteCommBox();
                CreateTexeBox();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddEditUser Add_EditUser = new FrmAddEditUser();
            Add_EditUser.ShowDialog();

            _loadData();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurrentUser CurrentUser = new FrmCurrentUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            CurrentUser.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditUser Add_EditUser = new FrmAddEditUser();
            Add_EditUser.ShowDialog();

            _loadData();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditUser Add_EditUser = new FrmAddEditUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            Add_EditUser.ShowDialog();

            _loadData();
        }

        private void delteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are sure to Delete this User ?") == DialogResult.OK)
            {
                if (ClsUsers.DeleteUsers((int)dgvListUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show($"User of {(int)dgvListUsers.CurrentRow.Cells[0].Value} is deleting Done ");
                }
                else
                {
                    MessageBox.Show($"Hay , You can not Delete This User sorry");
                }

            }
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature will be available soon");
        }

        private void callUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature will be available soon");
        }

        private void btnCloseFrmUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
