using Data.Clima.Interface;
using Models.Clima;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Clima.Implementation
{
    public class UsuarioData : IRepositoryBase<Usuario>
    {
        //static string cadena = ConfigurationManager.ConnectionStrings["ClimaEntities2"].ConnectionString;
        public Usuario Add(Usuario obj)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {
                    context.Usuario.Add(obj);
                    context.SaveChanges();
                    return obj;
                }
                catch (Exception ex)
                {
                    //MensajeError.mensajePersonalizado(ex.Message, ex.InnerException.ToString(), ex.StackTrace);
                    throw ex;
                }
            }
        }

        public Usuario Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string nombre)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    return context.Usuario.Where(x => x.Correo == nombre).Any();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Usuario> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Login(Usuario usuario)
        {
            using (ModelContext context = new ModelContext())
            {
                try
                {

                    return context.Usuario.Where(x => x.Correo == usuario.Correo &&  x.Clave ==usuario.Clave ).Any();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
