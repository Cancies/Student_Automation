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

namespace Student_Automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentLogin_Click(object sender, EventArgs e)
        {
            string studentNum = studentNumber.Text;
            string studentPass = studentPassword.Text;

            if(studentNum == "1200" && studentPass == "123abc"){
                Console.WriteLine("Logging in");
            }
            else {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teacherLogin_Click(object sender, EventArgs e)
        {
            string teacherNum = teacherNumber.Text;
            string teacherPass = teacherPassword.Text;

            if (teacherNum == "9999" && teacherPass == "1111")
            {
                Console.WriteLine("Logging in");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
