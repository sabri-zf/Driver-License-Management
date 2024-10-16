using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DriverLincsesSystem.People
{
    public partial class FrmpeopleLists : Form
    {

        DataTable PeopleDataSet;
        public FrmpeopleLists()
        {
            InitializeComponent();
        }

        private void CreateTexeBox()
        {
            TextBox TxtFilter = new TextBox();

            TxtFilter.Name = "TBFilter";
            TxtFilter.BackColor = Color.White;
            TxtFilter.BorderStyle = BorderStyle.FixedSingle;
            TxtFilter.Location = new System.Drawing.Point(305, 166);
            TxtFilter.Size = new System.Drawing.Size(300, 13);
            TxtFilter.Font = new Font("Segoe UI Semibold", 12 , FontStyle.Regular);
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
            Control TextBoxFilter = new Control() ;

            try
            {

            TextBoxFilter = this.Controls.Find("TBFilter", true).First();

            }
            catch
            {

            }

            return TextBoxFilter;
        }


        private void _LoadPeopleData()
        {
            

            PeopleDataSet = ClsPeople.GetAllPeopleDetails();

            if (PeopleDataSet.Rows.Count > 0)
            {
                PeopleDataSet.Columns[0].ColumnName = "PeopeleID";
                PeopleDataSet.Columns[1].ColumnName = "NationalN";
                PeopleDataSet.Columns[2].ColumnName = "FirstName";
                PeopleDataSet.Columns[3].ColumnName = "LastName";
                PeopleDataSet.Columns[4].ColumnName = "BirthDay";
                PeopleDataSet.Columns[5].ColumnName = "Gender";
                PeopleDataSet.Columns[9].ColumnName = "Country";



                DGVPeopleList.DataSource = PeopleDataSet.DefaultView;

                LabTotalRecord.Text = (DGVPeopleList.Rows.Count).ToString();


            }
        }


        private void PbAddNewPeople_Click(object sender, EventArgs e)
        {
            // Add New And update people

            FrmAdd_UpdatePeople AddNewPople = new FrmAdd_UpdatePeople();
            AddNewPople.ShowDialog();
            _LoadPeopleData();
        }

        private void _LoadCommBoxListFilter()
        {
            DataColumnCollection Columns = PeopleDataSet.Columns;

            CBFilterOption.Items.Add("None");
            foreach (DataColumn Col in Columns)
            {
                CBFilterOption.Items.Add(Col.ColumnName);
            }
            CBFilterOption.SelectedIndex = 0;

        }

        private void TxtFilter_TextCheanged(object sender , EventArgs e)
        {
            if (string.IsNullOrEmpty(FindControlTextBoxInRunTime().Text))
            {
                _LoadPeopleData();
                return;
            }

            if (CBFilterOption.Text == "PeopeleID")
            {
                    PeopleDataSet.DefaultView.RowFilter = $"PeopeleID = {FindControlTextBoxInRunTime().Text}";
                DGVPeopleList.DataSource = PeopleDataSet.DefaultView;
            }
            else
            {

            PeopleDataSet.DefaultView.RowFilter = $"{CBFilterOption.Text} like '{FindControlTextBoxInRunTime().Text}%'";
            DGVPeopleList.DataSource = PeopleDataSet.DefaultView;
            }


            LabTotalRecord.Text = DGVPeopleList.Rows.Count.ToString();
        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBFilterOption.Text == "PeopeleID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void FrmpeopleLists_Load(object sender, EventArgs e)
        {
            _LoadPeopleData();
            _LoadCommBoxListFilter();

        }

        private void CBFilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFilterOption.Text == "None")
            {
                DeleteTextBoxControl();
            }
            else
            {
                CreateTexeBox();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //context meun Event
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd_UpdatePeople UpdatePeron = new FrmAdd_UpdatePeople((int)DGVPeopleList.SelectedCells[0].Value);
            UpdatePeron.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FrmPeopleCardShowDetail personCard = new FrmPeopleCardShowDetail((int)DGVPeopleList.SelectedCells[0].Value);
            personCard.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd_UpdatePeople UpdatePeron = new FrmAdd_UpdatePeople();
            UpdatePeron.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want delete this person ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClsPeople.DeletePeople((int)DGVPeopleList.SelectedCells[0].Value))
                {
                    MessageBox.Show("Delete is Sccefully ", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This porperty is No work now ");
        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This porperty is No work now ");
        }
    }
}
