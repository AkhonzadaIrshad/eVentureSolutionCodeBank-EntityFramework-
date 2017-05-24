using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Products;

namespace ApplicationEntities.Books
{
    public class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private int eddition;

        public int Eddtion
        {
            get { return eddition; }
            set { eddition = value; }
        }
        private Product product;

        public virtual Product Product
        {
            get { return product; }
            set { product = value; }
        }

    }
}
