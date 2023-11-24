using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityCDbContext())
            {
                // Create students and lectures
                var student1 = new Student { Name = "John Doe" };
                var student2 = new Student { Name = "Jane Doe" };

                var lecture1 = new Lecture { Title = "Introduction to Programming" };
                var lecture2 = new Lecture { Title = "Database Management" };

                // Enroll students in lectures
                student1.Lectures.Add(lecture1);
                student2.Lectures.Add(lecture2);

                // Save changes to the database
                context.AddRange(student1, student2);
                context.SaveChanges();

                // Retrieve data
                var enrolledStudents = context.Lectures
                    .Include(l => l.Students)
                    .FirstOrDefault(l => l.Title == "Introduction to Programming")?.Students;

                // Display enrolled students
                Console.WriteLine("Enrolled students in Introduction to Programming:");
                foreach (var student in enrolledStudents)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }
    }
}