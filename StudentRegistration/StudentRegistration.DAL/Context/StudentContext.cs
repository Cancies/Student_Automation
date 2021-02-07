using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StudentRegistration.DAL.Model.Entity;


namespace StudentRegistration.DAL.Context
{
    public class StudentContext:DbContext
    {
        public StudentContext(): base()
        {
            //todo: connection string will move to appconfig folder.
            Database.Connection.ConnectionString = @"server=CANER\SQLEXPRESS;database=StudentDB;uid=sa;pwd=123456";
        }
        
        public DbSet<Student> Students { get; set; }

    }
}
