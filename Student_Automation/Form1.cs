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
using System.Globalization;

namespace Student_Automation
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public bool control = false;


        public string studentNum;
        public string studentPass;

        private void studentLogin_Click(object sender, EventArgs e)
        {

            studentNum = studentNumber.Text;
            studentPass = studentPassword.Text;

            if(studentNum == "1200" && studentPass == "123abc"){
                Console.WriteLine("Student logging in");
            }
            else {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public string teacherNum;
        public string teacherPass;

        private void teacherLogin_Click(object sender, EventArgs e)
        {
            teacherNum = teacherNumber.Text;
            teacherPass = teacherPassword.Text;

            if (teacherNum == "9999" && teacherPass == "1111")
            {
                Console.WriteLine("Teacher logging in");
                Form2 frm2 = new Form2();
                frm2.Show();
                control = true;
            }
            else
            {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        

    }

}
 