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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Read();
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

        public void Search(int len){

            for (int x = 0 ; x < len ; x++)
            {
                
            }

        }

    }
}
