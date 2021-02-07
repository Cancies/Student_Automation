using System;
using System.Windows.Forms;
using StudentRegistration.BLL.Service;

namespace StudentRegistration.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentService studentService = new StudentService();






        public string teacherNum;
        public string teacherPass;

        private void button1_Click(object sender, EventArgs e)
        {
            teacherNum = tbNumber.Text;
            teacherPass = tbPassword.Text;

            if (teacherNum == "9999" && teacherPass == "1111")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect entry.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
