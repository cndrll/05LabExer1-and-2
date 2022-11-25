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
    public partial class FrmRegistration2 : Form
    {
        public FrmRegistration2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getStudnum = textBox1.Text;
            string getProgram = comboBox1.Text;
            string getLastName = textBox2.Text;
            string getFirstName = textBox4.Text;
            string getMiddleInitial = textBox6.Text;
            int getAge = Convert.ToInt32(textBox3.Text);
            string getGender = comboBox2.Text;
            string getBirthday = dateTimePicker1.Text;
            string getContactNo = textBox5.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No.: " + getStudnum);
                Console.WriteLine(getStudnum);
                outputFile.WriteLine("Program: " + getProgram);
                Console.WriteLine(getProgram);
                outputFile.WriteLine("Name: " + getLastName + " " + getFirstName + " " + getMiddleInitial);
                outputFile.WriteLine("Age: " + getAge);
                Console.WriteLine(getAge);
                outputFile.WriteLine("Gender: " + getGender);
                Console.WriteLine(getGender);
                outputFile.WriteLine("Birthday: " + getBirthday);
                Console.WriteLine(getBirthday);
                outputFile.WriteLine("Contact No.: " + getContactNo);
                Console.WriteLine(getContactNo);
            }
        }
    }
}
