using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FirstDayWithEntityFramework
{

    class FirstContext : DbContext
    {
        public FirstContext() : base("name=FirstConn")
        {

        }

        public DbSet<Student> Students { get; set; }
    }

    public class Program
    {


        public static void Main(string[] args)
        {
            FirstContext context = new FirstContext();

            //Student student=new Student()
            //{
            //    Name = "Qasim",
            //    FatherName = "Saleem",
            //    Fee = 00.00,
            //    RollNumber = 111
            //};

            //Create

            //using (context)
            //{
            //    context.Students.Add(student);
            //    context.SaveChanges();
            //}

            //Read
            Student student;
            using (context)
            {
                //student = context.Students.Find(1);
                student = (from s in context.Students
                           where s.Id == 1
                           select s).FirstOrDefault();
            }
            if (student != null)
            {
                Console.WriteLine($"Roll Number : {student.RollNumber}\n" +
                                  $"Name        : {student.Name}\n" +
                                  $"Father Name : {student.FatherName}\n" +
                                  $"Fee         : {student.Fee}");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }

            //Update
            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "AAAA",
            //    FatherName = "BBBB",
            //    Fee = 00.00,
            //    RollNumber = 222
            //};
            //using (context)
            //{
            //    context.Entry(student).State=EntityState.Modified;
            //    context.SaveChanges();
            //}
            //Remove
            //Student student;
            //using (context)
            //{
            //    student = context.Students.Find(1);
            //    if (student!=null)
            //    {
            //        context.Students.Remove(student);
            //        context.SaveChanges();
            //    }

            //}




            Console.WriteLine("Done");

            Console.ReadKey();


        }


    }
}
