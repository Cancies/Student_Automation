using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.DAL.Model.Entity
{
    public class Student
    {
        [Key]
        public int studentNumber { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentDepartment { get; set; }
        public float studentGPA { get; set; }
        public string studentPassword { get; set; }
    }
}
