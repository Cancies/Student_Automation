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


        public string studentNum;
        public string studentPass;
        private void studentLogin_Click(object sender, EventArgs e)
        {

            studentNum = studentNumber.Text;
            studentPass = studentPassword.Text;

            if(studentNum == "1200" && studentPass == "123abc"){
                Console.WriteLine("Logging in");
                Search();
                mainTable.Visible = true;
            }
            else {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        public string teacherNum;
        public string teacherPass;
        private object[] row;

        private void teacherLogin_Click(object sender, EventArgs e)
        {
            teacherNum = teacherNumber.Text;
            teacherPass = teacherPassword.Text;

            if (teacherNum == "9999" && teacherPass == "1111")
            {
                Console.WriteLine("Logging in");
                Read();
                mainTable.Visible = true;
            }
            else
            {
                Console.WriteLine("not found");
                MessageBox.Show("Incorrect entry.", "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }


        public void Read()
        {
            string[] lines = File.ReadAllLines(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                mainTable.Rows.Add(row);
            }

        }

        public void Search()
        {
            string[] lines = File.ReadAllLines(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];
                

                for (int j = 0; j < values.Length; j++){
                    row[j] = values[j].Trim();
                }
            }


            for (int a = 0; a < lines.Length ; a++)
            {
                if (studentNum == lines[a])
                {
                    if (studentPass == lines[a])
                    {

                        mainTable.Rows.Add(row);
                    }
                }
            }




        }
    }

}
