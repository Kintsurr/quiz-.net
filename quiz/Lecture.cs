using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{

    public class Lecture 
    {
        [Key]
        public int LectureId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Capacity {  get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }
}
