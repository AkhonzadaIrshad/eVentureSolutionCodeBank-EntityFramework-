using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OurClassLibrary;
using System.Data.Entity;
using FirstDayWithEF.Models;

namespace FirstDayWithEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student std = new Student()
            {
                Name = "Asif",
                FatherName = "Bashir Ahmed",
                RollNumber = 123,
                Address = new Address()
                {
                    StreeAddress = "ABC 123",
                    City = new City()
                    {
                        Code = 42,
                        Name = "Lahore",
                        Country = new Country()
                        {
                            Code = 92,
                            Name = "Pakistan"
                        }
                    }
                }
            };

            new StudentHandler().Add(std);



            ////Read

            List<Student> students = new StudentHandler().GetAll();


            //Update
            //using (context)
            //{
            //    Student std = (from s in context.Students
            //                   .Include(x => x.Address.City)
            //                   where s.Address.City.Name.Equals("Lahore")
            //                   select s).FirstOrDefault();
            //    if (std != null)
            //    {
            //        std.Name = "Irshad";
            //        std.FatherName = "Ahmed";
            //        context.Entry(std).State = EntityState.Modified;
            //        context.SaveChanges();
            //    }
            //}
            //Delete
            //using (context)
            //{
            //    Student std = (from s in context.Students
            //                   .Include(x => x.Address.City)
            //                   where s.Address.City.Name.Equals("Lahore")
            //                   select s).FirstOrDefault();
            //    if (std != null)
            //    {
            //        context.Students.Remove(std);
            //        context.SaveChanges();
            //    }
            //}



            return View();
        }

        [HttpGet]
        public ActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddForm(StudentModel student)
        {


            // Request["ImageUrl"];


            string pI = string.Empty;

            HttpPostedFileBase file = Request.Files["ImageUrl"];

            file.SaveAs(Request.MapPath("~/Content/Images/"+file.FileName));
            pI = file.FileName;


            Student std = new Student()
            {
                Name = student.Name,
                FatherName = student.FatherName,
                RollNumber = 123 + DateTime.Now.Second,
                ImageUrl = pI,
                Address = new Address()
                {
                    StreeAddress = student.StreetAddress,
                    City = new City()
                    {
                        Code = 42,
                        Name = student.City,
                        Country = new Country()
                        {
                            Code = 92,
                            Name = student.Country
                        }
                    }
                }
            };
            new StudentHandler().Add(std);





            ViewBag.Message = "Student SuccessFully Added";

            ViewBag.Students=new StudentHandler().GetAll();

            return View();
        }


    }
}