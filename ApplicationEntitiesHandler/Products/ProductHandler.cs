using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Products;
using ApplicationEntitiesHandler.Common;
using System.Data.Entity;
namespace ApplicationEntitiesHandler.Products
{
   public class ProductHandler:IHandlerFunctions<Product>
    {
        public void Add(Product t)
        {
            ApplicationContext context=new ApplicationContext();
            using (context)
            {
                context.Products.Add(t);
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            ApplicationContext context = new ApplicationContext();
            using (context)
            {
                return (from p in context.Products
                        .Include(x=>x.Mobile)
                        select p).ToList();
            }
        }

        public Product GetById(int id)
        {
            ApplicationContext context = new ApplicationContext();
            using (context)
            {
                return (from p in context.Products
                        where p.Id==id
                        select p).FirstOrDefault();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
