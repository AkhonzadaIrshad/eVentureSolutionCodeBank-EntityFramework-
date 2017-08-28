using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.Entity;
namespace OurClassLibrary
{
    public class StudentHandler
    {
        public void Add(Student student)
        {
            OurContext context = new OurContext();
            //Create
            using (context)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            OurContext context = new OurContext();
            using (context)
            {
                //List<Student> students = context.Students.ToList();
                return (from s in context.Students
                            .Include(x => x.Address.City.Country)
                            select s).ToList();
            }
        }
    }
}
