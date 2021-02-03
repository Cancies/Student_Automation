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
using System.Data.SqlClient;


namespace Student_Automation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        


        public void Read()
        {
            //  USING DB
            string constring = @"Data Source=CANER\SQLEXPRESS;Initial Catalog='Student Automation DB';Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM students", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            mainTable.DataSource = dt;
                        }
                    }
                }
            }
        



        //  USING TEXT FILE
        /*string[] lines = File.ReadAllLines(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt");
        string[] values;

        for (int i = 0; i < lines.Length; i++)
        {
            values = lines[i].ToString().Split(',');
            string[] row = new string[values.Length];

            for (int j = 0; j < values.Length; j++)
            {
                row[j] = values[j];
            }

            mainTable.Rows.Add(row);
        }*/

        }







        private void add_Click(object sender, EventArgs e)
        {
            //  USING SQL
            if (tbNumber.Text != "" && tbName.Text != "" && tbSurname.Text != "" && tbDepartment.Text != "" && tbGPA.Text != "" && tbPassword.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=CANER\SQLEXPRESS;Initial Catalog='Student Automation DB';Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();

                        cmd.CommandText = "INSERT INTO students VALUES('" + tbNumber.Text + "','" + tbName.Text + "','" + tbSurname.Text + "','" + tbDepartment.Text + "','" + tbGPA.Text + "','" + tbPassword.Text + "')";
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



            //  USING TEXT FILE
            /*
            using (TextWriter txt = new StreamWriter(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt"))
                for (int i = 0; i < mainTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < mainTable.Columns.Count; j++)
                    {
                        txt.Write($"{mainTable.Rows[i].Cells[j].Value.ToString()}");

                        if (j != mainTable.Columns.Count - 1)
                        {
                            txt.Write(",");
                        }
                    }
                    txt.WriteLine();
                }
            */
        }


        
        private void update_Click(object sender, EventArgs e)
        {
            //USING SQL
            if (mainTable.CurrentRow != null)
            {
                int rowindex = mainTable.CurrentCell.RowIndex;

                using (SqlConnection con = new SqlConnection(@"Data Source=CANER\SQLEXPRESS;Initial Catalog='Student Automation DB';Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        con.Open();

                        cmd.CommandText = "UPDATE students SET Number= '"+mainTable.Rows[rowindex].Cells[0].Value+ "' , Name='" + mainTable.Rows[rowindex].Cells[1].Value + "' , Surname= '" + mainTable.Rows[rowindex].Cells[2].Value + "' , Department='" + mainTable.Rows[rowindex].Cells[3].Value + "' , GPA='" + mainTable.Rows[rowindex].Cells[4].Value + "' , Password='" + mainTable.Rows[rowindex].Cells[5].Value + "'  WHERE Number='"+ mainTable.Rows[rowindex].Cells[0].Value + "'    ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Adding successful.", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //USING TEXT FILE
            /*
            using (TextWriter txtUpdate = new StreamWriter(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt"))
            

            for (int i = 0 ; i < mainTable.Rows.Count-1 ; i++)
            {
                for (int j = 0 ; j < 6 ; j++)
                {
                    if (mainTable.Rows[i].Cells[j].Value == null)
                    {
                        mainTable.Rows[i].Cells[j].Value = "null";
                    }
                    txtUpdate.Write($"{mainTable.Rows[i].Cells[j].Value.ToString() + ','}");   
                }
                txtUpdate.WriteLine();
            }
            */
        }



        public void delete_Click(object sender, EventArgs e)
        {
            //  USING SQL
            foreach (DataGridViewRow item in this.mainTable.SelectedRows){
                int CategoriesId = Convert.ToInt32(mainTable.SelectedRows[0].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"Data Source=CANER\SQLEXPRESS;Initial Catalog='Student Automation DB';Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE Number='" + CategoriesId + "'", con);
                mainTable.Rows.RemoveAt(this.mainTable.SelectedRows[0].Index);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
                


            //  USING TEXT FILE
            /*
            using(var textRead = new StreamReader(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt"))
            foreach (DataGridViewRow row in mainTable.SelectedRows)
            {
                mainTable.Rows.RemoveAt(row.Index);
            }

            update_Click(sender,e);
            */
        }

    }
    

}
