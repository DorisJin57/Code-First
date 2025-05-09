using System;
using System.Data.Entity;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main()
        {
            using (var context = new StudentContext())
            {
                var student = new Student { Name = "John Doe" };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student saved.");
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
