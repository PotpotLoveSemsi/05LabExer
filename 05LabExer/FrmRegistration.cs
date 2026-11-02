using System;
using System.IO; 
using System.Windows.Forms;

namespace _05LabExer
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fileName = txtStudentNo.Text + ".txt"; 

            string[] outputData = {
                "Student No.: " + txtStudentNo.Text,
                "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text + ".",
                "Program: " + cbProgram.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"), 
                "Contact No. " + txtContactNo.Text
            };

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (string line in outputData)
                {
                    outputFile.WriteLine(line);
                }
            }
            
            MessageBox.Show("Registered Successfully!");
        }
    }
}