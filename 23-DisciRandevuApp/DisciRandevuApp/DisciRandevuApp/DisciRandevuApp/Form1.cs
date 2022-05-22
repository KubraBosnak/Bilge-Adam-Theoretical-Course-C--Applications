using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DisciRandevuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Doctor> Doctors = new List<Doctor>();
        List<Customer> Customers = new List<Customer>();
        string doctorsFilePath = Application.StartupPath + @"\doctors.txt";
        string customersFilePath = Application.StartupPath + @"\customers.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTreeView();
        }

        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            frmDoctorAdd doctorAddForm = new frmDoctorAdd();
            DialogResult result = doctorAddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Doctors.Add(new Doctor()
                {
                    FullName = doctorAddForm.txtDoctorName.Text.ToUpper(),
                    Phone = doctorAddForm.txtDoctorPhone.Text,
                    Email = doctorAddForm.txtDoctorEmail.Text,
                    Field = doctorAddForm.txtDoctorField.Text,
                    TcNo = doctorAddForm.txtDoctorTcNo.Text,
                });

                LoadTreeView();
            }
        }


        public void LoadTreeView()
        {
            trvDoctorsCustomers.Nodes.Clear();

            foreach (Doctor doctor in Doctors)
            {
                TreeNode tnDoctor = new TreeNode(doctor.FullName);

                foreach (Customer customer in Customers)
                {
                    if (customer.DoctorTcNo == doctor.TcNo)
                    {
                        TreeNode tnCustomer = new TreeNode(customer.FullName);
                        tnDoctor.Nodes.Add(tnCustomer);
                    }
                }

                trvDoctorsCustomers.Nodes.Add(tnDoctor);
            }
        }

        private void btnAppointmentAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.DoctorList = Doctors;

            DialogResult result = frmCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                string doctorTcNo = frmCustomer.cmbDoctors.Text.Split('-')[1];

                Customers.Add(new Customer()
                {
                    FullName = frmCustomer.txtCustomerName.Text.ToUpper(),
                    Phone = frmCustomer.txtCustomerPhone.Text,
                    Email = frmCustomer.txtCustomerEmail.Text,
                    BirthDate = frmCustomer.dtpCustomerBirthDate.Value,
                    Note = frmCustomer.txtCustomerNote.Text,
                    DoctorTcNo = doctorTcNo,
                    TcNo = frmCustomer.txtCustomerTcNo.Text
                });

                LoadTreeView();
            }
        }

        private void btnSaveDoctorsCustomers_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveAppointments_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            List<string> doctorsLines = new List<string>(Doctors.Count);
            List<string> customersLines = new List<string>(Customers.Count);

            foreach (Doctor doctor in Doctors)
            {
                doctorsLines.Add($"{doctor.FullName}|{doctor.Phone}|{doctor.Email}|{doctor.Field}|{doctor.TcNo}");
            }

            foreach (Customer customer in Customers)
            {
                customersLines.Add($"{customer.FullName}|{customer.Phone}|{customer.Email}|{customer.BirthDate.ToShortDateString()}|{customer.DoctorTcNo}|{customer.TcNo}|{customer.Note}");
            }

            File.WriteAllLines(doctorsFilePath, doctorsLines);
            File.WriteAllLines(customersFilePath, customersLines);
        }

        private void LoadData()
        {
            List<string> doctorsLines = File.ReadAllLines(doctorsFilePath).ToList();
            
            foreach (string line in doctorsLines)
            {
                string[] lineParts = line.Split('|');
                Doctor doctor = new Doctor()
                {
                    FullName = lineParts[0],
                    Phone = lineParts[1],
                    Email = lineParts[2],
                    Field = lineParts[3],
                    TcNo = lineParts[4]
                };

                Doctors.Add(doctor);
            }

            List<string> customersLines = File.ReadAllLines(customersFilePath).ToList();

            foreach (string line in customersLines)
            {
                string[] lineParts = line.Split('|');
                Customer customer = new Customer()
                {
                    FullName = lineParts[0],
                    Phone = lineParts[1],
                    Email = lineParts[2],
                    BirthDate = DateTime.Parse(lineParts[3]),   // Convert.ToDateTime(lineParts[3])
                    DoctorTcNo = lineParts[4],
                    TcNo = lineParts[5],
                    Note = lineParts[6],
                };

                Customers.Add(customer);
            }
        }
    }
}
