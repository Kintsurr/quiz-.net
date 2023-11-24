using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}
