using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace quiz
{
    public class UniversityCDbContext : DbContext
    {
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }

        public string DbPath { get; }

        public UniversityCDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

       
    }
}
