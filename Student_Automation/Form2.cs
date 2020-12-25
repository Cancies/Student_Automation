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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void Read()
        {

            string[] lines = File.ReadAllLines(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt");
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
            }

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
            using(var textRead = new StreamReader(@"D:\APP PROJECTS\GitHub\Student_Automation\Student_Automation\text.txt"))
            foreach (DataGridViewRow row in mainTable.SelectedRows)
            {
                mainTable.Rows.RemoveAt(row.Index);
            }

            update_Click(sender,e);
        }
    }
    

}
