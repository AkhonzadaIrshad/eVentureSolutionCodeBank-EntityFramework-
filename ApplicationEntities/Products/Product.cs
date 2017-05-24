using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Books;
using ApplicationEntities.Mobiles;

namespace ApplicationEntities.Products
{
    public class Product
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private Mobile mobile;

        public virtual Mobile Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private Book book;

        public virtual Book Book
        {
            get { return book; }
            set { book = value; }
        }


    }
}
