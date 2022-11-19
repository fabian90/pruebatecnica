using Models.Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Clima.Interface
{
    public interface IRepositoryBaseCiudad
    {
        IEnumerable<Ciudad> Get(long id);
        IEnumerable<Ciudad> GetAll();
        Ciudad Add(Ciudad obj);
        Ciudad Update(Ciudad obj);
        Ciudad Delete(int id);
    }
}
