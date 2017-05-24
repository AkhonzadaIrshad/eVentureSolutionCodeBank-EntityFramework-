using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEntitiesHandler.Common
{
    public interface IHandlerFunctions<T>
    {
        void Add(T t);
        List<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T t);
    }
}
