using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationEntities.Mobiles;
using ApplicationEntitiesHandler.Products;
using ApplicationEntities.Products;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            new ProductHandler().Add(new Product()
            {
                Name = "Mobile",
               Mobile = new Mobile()
               {
                   Model = "S6",
                   OperatingSystem = "iOs"
               },
               Price = 655
            });


            List<Product> prdts=new ProductHandler().GetAll();


            return View(prdts);
        }
    }
}