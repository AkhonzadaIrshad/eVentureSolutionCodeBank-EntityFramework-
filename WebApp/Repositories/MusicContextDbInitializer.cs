using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repositories
{
    public class MusicContextDbInitializer:DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            Artist artist=new Artist()
            {
                Name = "First Artist"
            };
            context.Artists.Add(artist);
            context.Artists.Add(new Artist()
            {
                Name = "Second Artist"
            });
            context.SaveChanges();
        }
    }
}
