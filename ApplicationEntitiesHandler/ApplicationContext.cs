using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ApplicationEntities.Books;
using ApplicationEntities.Mobiles;
using ApplicationEntities.Products;

namespace ApplicationEntitiesHandler
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext():base("name=WebAppConnectionString")
        {
            
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Mobile> Mobiles { get; set; }
        
    }
}
