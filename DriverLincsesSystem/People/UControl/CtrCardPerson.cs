using BusinessLayer;
using DriverLincsesSystem.Properties;
using System.IO;
using System.Windows.Forms;

namespace DriverLincsesSystem.People.UControl
{
    public partial class CtrCardPerson : UserControl
    {
       private  ClsPeople Person;

        private int _PersonID;
        public CtrCardPerson()
        {
            InitializeComponent();
        }


        public int PersonID
        {
            get { return _PersonID; }
        }

        public ClsPeople PersonInfo
        { get { return Person; } }
        public void _loadPersonCard(int PersonID)
        {
            if (ClsPeople.IsExistsPeople(PersonID))
            {
                _PersonID = PersonID;

                Person = ClsPeople.Find(PersonID);

                if (Person == null)
                {
                    _ResetData();
                    MessageBox.Show("The person is not found");
                }

                LabPerosnID.Text = PersonID.ToString();
                labFullName.Text = Person.FirstName.Trim() +" "+ Person.LastName.Trim();
                LabNational.Text = Person.NationalNo.Trim();
                labEmail.Text = (Person.Email == "")?"N/A":Person.Email;
                labPhone.Text = Person.Phone.Trim();
               if((Person.Gendor == 0))
                {
                    labGerder.Text = "Male";
                    PBGenderImage.Image = Resources.Man_32;
                }
                else
                {
                    labGerder.Text = "Female";
                    PBGenderImage.Image = Resources.Woman_32;
                }
                  
                     
                labAddress.Text = Person.Address.Trim();
                labCountry.Text = clsCountries.GetCountryName((byte)Person.NationalityCountryID);
                labBirthDay.Text = Person.DateOfBirth.ToShortDateString();

                if(Person.ImagePath == "")
                {
                    if(Person.Gendor == 0)
                    {
                        PBimagePerson.Image = Resources.Male_512;
                    }
                    else
                    {
                        PBimagePerson.Image = Resources.Female_512;

                    }
                }
                else
                {
                    if (File.Exists(Person.ImagePath))
                        PBimagePerson.ImageLocation = Person.ImagePath;
                    else
                        MessageBox.Show("Image Is Not exist in server");
                }


            }
            else
            {
                MessageBox.Show($"Person Of ID ({PersonID}) Is not Exist");
                _ResetData();
            }
        }

        public void _loadPersonCard(string NationalNumber)
        {
            if (ClsPeople.IsExistsNationalNO(NationalNumber))
            {

                Person = ClsPeople.FindNational(NationalNumber);

                _PersonID = Person.GetPersonID();

                if (Person == null)
                {
                    _ResetData();
                    MessageBox.Show("The person is not found");
                }

                LabPerosnID.Text = Person.GetPersonID().ToString();
                labFullName.Text = Person.FirstName.Trim() + " " + Person.LastName.Trim();
                LabNational.Text = Person.NationalNo.Trim();
                labEmail.Text = (Person.Email == "") ? "N/A" : Person.Email;
                labPhone.Text = Person.Phone.Trim();
                if ((Person.Gendor == 0))
                {
                    labGerder.Text = "Male";
                    PBGenderImage.Image = Resources.Man_32;
                }
                else
                {
                    labGerder.Text = "Female";
                    PBGenderImage.Image = Resources.Woman_32;
                }


                labAddress.Text = Person.Address.Trim();
                labCountry.Text = clsCountries.GetCountryName((byte)Person.NationalityCountryID);
                labBirthDay.Text = Person.DateOfBirth.ToShortDateString();

                if (Person.ImagePath == "")
                {
                    if (Person.Gendor == 0)
                    {
                        PBimagePerson.Image = Resources.Male_512;
                    }
                    else
                    {
                        PBimagePerson.Image = Resources.Female_512;

                    }
                }
                else
                {
                    if (File.Exists(Person.ImagePath))
                        PBimagePerson.ImageLocation = Person.ImagePath;
                    else
                        MessageBox.Show("Image Is Not exist in server");
                }


            }
            else
            {
                MessageBox.Show($"Person Of National Number ({NationalNumber}) Is not Exist");
                _ResetData();
            }
        }

        private void _ResetData()
        {
            LabPerosnID.Text = "[??]";
           labFullName.Text = "[??]";
            LabNational.Text = "[??]";
             labEmail.Text = "[??]";
            labPhone.Text = "[??]";
            labAddress.Text = "[??]";
            labCountry.Text = "[??]";
            labBirthDay.Text = "[??]";
            labGerder.Text = "[??]";
            PBimagePerson.Image = Resources.Male_512;
            PBGenderImage.Image = Resources.Man_32;


        }
        private void LinkToEddetPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Person != null)
            {
                FrmAdd_UpdatePeople EditPerson = new FrmAdd_UpdatePeople(Person.GetPersonID());
                EditPerson.ShowDialog();
                _loadPersonCard(Person.GetPersonID());
            }
            else
            {
                MessageBox.Show("Hey you are not have any data used", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
