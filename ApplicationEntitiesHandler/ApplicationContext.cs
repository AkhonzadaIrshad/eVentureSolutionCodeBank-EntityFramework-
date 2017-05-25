using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ApplicationEntities.Mobiles;
using ApplicationEntities.Products;

namespace ApplicationEntitiesHandler
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext():base("name=WebAppConnectionString")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasRequired(x => x.Mobile)
                .WithRequiredDependent(c => c.Product);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Mobile> Mobiles { get; set; }
        
    }
}
