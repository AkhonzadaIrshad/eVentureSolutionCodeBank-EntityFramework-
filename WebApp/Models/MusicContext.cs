using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MusicContext:DbContext
    {
        public MusicContext():base("name=MusicConn")
        {
            
        }

        public DbSet<Artist> Artists { get; set; }

    }
}
