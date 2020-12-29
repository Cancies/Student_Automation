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
            //  USING DATABASE (MSSQL 2017)
            string constring = @"Data Source=CANER\CANERSQL;Initial Catalog='student automation';Integrated Security=True";
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


        public void Search()
        {
            string[] lines = File.ReadAllLines(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt");
            string[] values;
            Form1 frm1 = new Form1();

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];


                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j];
                }
                if (i == frm1.foundedIndex)
                {
                    mainTable.Rows.Add(row[frm1.foundedIndex]);
                }
            }
        }


        private void add_Click(object sender, EventArgs e)
        {

            //  USING SQL
            SqlConnection con = new SqlConnection(@"Data Source=CANER\CANERSQL;Initial Catalog='student automation';Integrated Security=True");

            for (int i = 0; i < mainTable.Rows.Count; i++){

                if (mainTable.Rows[i].Cells[0] != null){
                    continue;
                }

                SqlCommand cmd = new SqlCommand(@"INSERT INTO students (Number,Name,Surname,Department,GPA,Password)VALUES('"+mainTable.Rows[i-1].Cells[0].Value+"','"+mainTable.Rows[i-1].Cells[1].Value+ "','" + mainTable.Rows[i-1].Cells[2].Value + "','" + mainTable.Rows[i-1].Cells[3].Value + "','" + mainTable.Rows[i-1].Cells[4].Value + "','" + mainTable.Rows[i-1].Cells[5].Value + "')",con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
        }


        public void delete_Click(object sender, EventArgs e)
        {
            //  USING SQL
            foreach (DataGridViewRow item in this.mainTable.SelectedRows){
                int CategoriesId = Convert.ToInt32(mainTable.SelectedRows[0].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"Data Source=CANER\CANERSQL;Initial Catalog='student automation';Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE ID='" + CategoriesId + "'", con);
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
