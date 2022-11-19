using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Data.Clima.Interface;
using Models.Clima;

namespace Data.Clima.Implementation
{
    public class PronosticoData : IRepositoryBase<Pronostico>
    {
        public Pronostico Add(Pronostico obj)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {
                    context.Pronostico.Add(obj);
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {                   
                    throw ex;
                }
            }

           
        }

        public Pronostico Delete(int Id)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {
                    var cliente = context.Pronostico.Find(Id);
                    context.Pronostico.Remove(cliente);
                    context.SaveChanges();
                    return cliente;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Pronostico> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pronostico> Get(int id)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    return context.Pronostico.Where(x => x.id == id).Include(d => d.Ciudad).Include(d => d.Ciudad.Departamento).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Pronostico> GetAll()
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {                  
                    return context.Pronostico.Include(d => d.Ciudad).Include(d => d.Ciudad.Departamento).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Pronostico Update(Pronostico obj)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    context.Entry(obj).State = EntityState.Modified;
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}