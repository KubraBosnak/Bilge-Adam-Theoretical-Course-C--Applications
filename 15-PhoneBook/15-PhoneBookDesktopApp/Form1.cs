using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_PhoneBookDesktopApp
{
    public partial class Form1 : Form
    {
        private Person[] People = new Person[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;   // form ilk açıldığında butonlar görünmeyecek
            btnSave.Visible = false;
            btnDel.Visible = false;

            //lstPeople.Items.Add("Murat Başeren");
            //lstPeople.Items.Add("Murat Başeren");
            //lstPeople.Items.Add("Murat Başeren");
            //lstPeople.Items.Add("Murat Başeren");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // txtName.Text = "";
            // txtName.Text = string.Empty;
            //txtName.Clear();
            //txtSurname.Clear();
            //mtxtPhone.Clear();
            //rdbFemale.Checked = true;
            //chkFavorite.Checked = false;
            //cmbCategory.SelectedIndex = -1;

            btnAdd.Visible = true;
            btnSave.Visible =false;
            btnDel.Visible = false;



        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPeople.SelectedIndex;

            if (index > -1)
            {
            Person person = People[index];

            txtName.Text = person.Name;
            txtSurname.Text = person.Surname;
            mtxtPhone.Text = person.Phone;
            cmbCategory.SelectedIndex = person.CategoryIndex;
            rdbFemale.Checked = person.IsFemale;
            rdbMale.Checked = !person.IsFemale;
            //rdbMale.Checked = (person.IsFemale == true) ? false : true;
            chkFavorite.Checked = person.IsFavorite;

            btnAdd.Visible = false;
            btnSave.Visible = true;
            btnDel.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.Name = txtName.Text;
            newPerson.Surname = txtSurname.Text;
            newPerson.Phone = mtxtPhone.Text;
            newPerson.CategoryIndex = cmbCategory.SelectedIndex;
            newPerson.IsFemale = rdbFemale.Checked;
            newPerson.IsFavorite = chkFavorite.Checked;

            Array.Resize(ref People, People.Length + 1);
            People[People.Length - 1] = newPerson;
            ListPeople();
        }

        private void ListPeople()
        {
            lstPeople.Items.Clear();

            for (int i = 0; i < People.Length; i++)
            {
                Person p = People[i];
                lstPeople.Items.Add(p.Name + " " + p.Surname + " - " + p.Phone + "- " + p.CategoryIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //   1. YÖNTEM
           // Person newPerson = new Person();

           // newPerson.Name = txtName.Text;
           // newPerson.Surname = txtSurname.Text;
           // newPerson.Phone = mtxtPhone.Text;
           // newPerson.CategoryIndex = cmbCategory.SelectedIndex;
           // newPerson.IsFemale = rdbFemale.Checked;
           // newPerson.IsFavorite = chkFavorite.Checked;

           //// int index = lstPeople.SelectedIndex;
           // People[index] = newPerson;

            //    2. YÖNTEM
          
            int index = lstPeople.SelectedIndex;
            Person person = People[index];

            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.Phone = mtxtPhone.Text;
            person.CategoryIndex = cmbCategory.SelectedIndex;
            person.IsFemale = rdbFemale.Checked;
            person.IsFavorite = chkFavorite.Checked;

            ListPeople();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lstPeople.SelectedIndex;

            if (index > -1)
            {
                Person person = People[index];

                DialogResult result = MessageBox.Show($"{person.Name} {person.Surname} isimli telefon kaydını silmek istediğinizden emin misiniz?", "Telefon Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Person[] newArray = new Person[People.Length - 1];

                    bool isSkip = false;
                    
                        for (int i = 0; i < People.Length; i++)
                        {
                            if (i == index)
                            {
                                //bunu atla
                                isSkip = true;
                                continue;
                            }
                            if (isSkip == false)
                            {
                                newArray[i] = People[i];
                            }
                            else
                            {
                                newArray[i - 1] = People[i];
                            }
                        }

                        People = newArray;

                    ListPeople();
                    }
                }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtSearch.Text);
            string search = txtSearch.Text.Trim();

            //if (string.IsNullOrEmpty(search))  Aşağıdaki if ile aynı            
            if (search=="")
            {
                // Tüm kayıtları listele
                int index = lstPeople.SelectedIndex;
            }
            else
            {
                // Yazılana göre arama yaparak uygun kayıtları göstermemiz gerekiyor

                //for (int i = 0; i < People.Length; i++)
                //{
                //    Person person = People[i];
                //}

                foreach (var item in collection)
                {

                }
            }

        }
    }
    
}
