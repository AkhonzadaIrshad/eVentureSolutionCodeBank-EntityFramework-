using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationEntities.Books;
using ApplicationEntitiesHandler.Common;

namespace ApplicationEntitiesHandler.Books
{
    public class BookHandler:IHandlerFunctions<Book>
    {
        public void Add(Book t)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book t)
        {
            throw new NotImplementedException();
        }
    }
}
