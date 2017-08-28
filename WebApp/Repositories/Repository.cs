using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repositories
{
    public class Repository<T> where T:class
    {
        private MusicContext context = null;

        protected DbSet<T> DbSet { get; set; }
        public Repository()
        {
            this.context=new MusicContext();
            context.Set<T>(); 
        }

        public Repository(MusicContext context)
        {
            this.context = context;
            context.Set<T>();

        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }



    }
}
