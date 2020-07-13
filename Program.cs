using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class baseClass {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Course : baseClass { 
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
    public class Author : baseClass { 
        public IList<Course> Courses { get; set; }
    }
    public class Tag : baseClass { 
        public IList<Course> Courses { get; set; }
    }
    public enum CourseLevel { 
        Beguinner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    public class PlutoDbContext : DbContext { 
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public PlutoDbContext() : base ("name=DefaultConnection"){}
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
