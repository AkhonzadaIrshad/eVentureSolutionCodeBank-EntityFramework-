using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repositories
{
    public class ArtistRepository:Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }
        
    }
}
