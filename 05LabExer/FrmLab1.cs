using System;
using System.IO;
using System.Windows.Forms;

namespace _05LabExer
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Opens FrmFileName[cite: 7]
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            // Gets text input and path[cite: 7]
            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Writes the file[cite: 7]
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("Text file created successfully!");
        }
    }
}