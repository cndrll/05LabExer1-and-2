using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge2_Angeles
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Uploaded");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        public static string SetFileName;
        private void button1_Click(object sender, EventArgs e)
        {
             FrmRegistration2 frmRegistration2 = new FrmRegistration2();
            frmRegistration2.ShowDialog();
        }
    }
}
