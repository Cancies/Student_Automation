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
        public int foundedIndex;

        private void studentLogin_Click(object sender, EventArgs e)
        {

            studentNum = studentNumber.Text;
            studentPass = studentPassword.Text;
            Form2 frm2 = new Form2();
            frm2.Read();

            for (int i=0; i<frm2.mainTable.Rows.Count ; i++){
                if (studentNum == frm2.mainTable.Rows[i].Cells[0].ToString() && studentPass == frm2.mainTable.Rows[i].Cells[5].ToString())
                {
                    Console.WriteLine("Student logging in");
                    foundedIndex = i;
                    frm2.delete_Click(sender,e);
                    frm2.Show();
                    frm2.Search();
                    break;
                }

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
                frm2.Read();
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
 