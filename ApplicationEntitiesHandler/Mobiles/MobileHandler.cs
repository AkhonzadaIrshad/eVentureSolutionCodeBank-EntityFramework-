using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Mobiles;
using ApplicationEntitiesHandler.Common;

namespace ApplicationEntitiesHandler.Mobiles
{
    public class MobileHandler:IHandlerFunctions<Mobile>
    {
        public void Add(Mobile t)
        {
            ApplicationContext context = new ApplicationContext();
            using (context)
            {
                context.Mobiles.Add(t);
                context.SaveChanges();
            }
        }

        public List<Mobile> GetAll()
        {
            ApplicationContext context = new ApplicationContext();
            using (context)
            {
                return (from p in context.Mobiles select p).ToList();
            }
        }

        public Mobile GetById(int id)
        {
            ApplicationContext context = new ApplicationContext();
            using (context)
            {
                return (from p in context.Mobiles
                        where p.Id == id
                    select p).FirstOrDefault();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Mobile t)
        {
            throw new NotImplementedException();
        }
    }
}
