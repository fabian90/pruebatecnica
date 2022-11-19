using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Clima.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> Get(int id);
        IEnumerable<T> GetAll();
        T Add(T obj);
        T Update(T obj);
        T Delete(int Id);
        IEnumerable<T> Exists(int id);
        bool Exists(string nombre);
    }
}
