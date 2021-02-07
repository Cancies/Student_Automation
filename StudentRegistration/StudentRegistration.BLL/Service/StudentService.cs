using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistration.DAL.Context;
using StudentRegistration.DAL.Model.Entity;

namespace StudentRegistration.BLL.Service
{
    public class StudentService
    {
        StudentContext context = new StudentContext();

        //Get Students
        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }



    }
}
