using Data.Clima.Interface;
using Models.Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Clima.Implementation
{
    public class DepartamentoData : IRepositoryBase<Departamento>
    {
        public Departamento Add(Departamento obj)
        {
            throw new NotImplementedException();
        }

        public Departamento Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> GetAll()
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    return context.Departamento.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Departamento Update(Departamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
