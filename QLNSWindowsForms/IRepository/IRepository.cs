using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.IRepository
{
    public interface IRepository<T>
    {
        Task<List<T>> GetList();
        Task<T> Get(int id);
        void Delete(int id);
        void Add(T item);
    }
}
