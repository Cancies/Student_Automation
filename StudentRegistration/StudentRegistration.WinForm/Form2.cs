using StudentRegistration.BLL.Service;
using StudentRegistration.DAL.Context;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace StudentRegistration.WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        StudentContext db = new StudentContext();

        private void Form2_Load(object sender, EventArgs e)
        {
            string constring = @"server=CANER\SQLEXPRESS;database=StudentDB;uid=sa;pwd=123456";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && surname.Text != "" && department.Text != "" && gpa.Text != "" && password.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"server=CANER\SQLEXPRESS;database=StudentDB;uid=sa;pwd=123456"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();

                        cmd.CommandText = "INSERT INTO Students(studentName,studentSurname,studentDepartment,studentGPA,studentPassword) VALUES('" + name.Text + "','" + surname.Text + "','" + department.Text + "','" + gpa.Text + "','" + password.Text + "');";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Adding successful.", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fields cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int CategoriesId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"server=CANER\SQLEXPRESS;database=StudentDB;uid=sa;pwd=123456");
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE studentNumber='" + CategoriesId + "'", con);
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;

                using (SqlConnection con = new SqlConnection(@"server=CANER\SQLEXPRESS;database=StudentDB;uid=sa;pwd=123456"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();

                        cmd.CommandText = "UPDATE Students SET studentName='" + dataGridView1.Rows[rowindex].Cells[1].Value + "' , studentSurname= '" + dataGridView1.Rows[rowindex].Cells[2].Value + "' , studentDepartment='" + dataGridView1.Rows[rowindex].Cells[3].Value + "' , studentGPA='" + dataGridView1.Rows[rowindex].Cells[4].Value + "' , studentPassword='" + dataGridView1.Rows[rowindex].Cells[5].Value + "'  WHERE studentNumber='" + dataGridView1.Rows[rowindex].Cells[0].Value + "'    ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Adding successful.", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
