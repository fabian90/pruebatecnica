using Data.Clima.Interface;
using Models.Clima;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Clima.Implementation
{
    public class CiudadData : IRepositoryBaseCiudad
    {
        public Ciudad Add(Ciudad obj)
        {
            throw new NotImplementedException();
        }

        public Ciudad Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ciudad> Get(long idDepartamento)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    return context.Ciudad.Include(x=>x.Departamento).Where(x => x.departamento_id == idDepartamento).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Ciudad> GetAll()
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {
                    return context.Ciudad.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Ciudad Update(Ciudad obj)
        {
            throw new NotImplementedException();
        }
    }
}
