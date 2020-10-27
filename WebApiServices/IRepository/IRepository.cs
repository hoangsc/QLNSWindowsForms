using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiServices.IRepository
{
    public interface IRepository<T>
    {
        List<T> List();
        T Get(int id);
        void Add(T item);
        void Update(T item, int id);
        void Delete(int id);

    }
}
