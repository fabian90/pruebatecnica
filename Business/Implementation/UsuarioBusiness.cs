using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using Common;
using Dto.Clima;
using Models.Clima;
using Data.Clima;
using Data.Clima.Implementation;
using Common.Helper;

namespace Business.Implementation
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        public BusinessResultado<UsuarioDto> Actualizar(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public BusinessResultado<IEnumerable<UsuarioDto>> Consultar()
        {
            throw new NotImplementedException();
        }

        public BusinessResultado<bool> ConsultarUsuarioPorEmail(string nombre)
        {
            bool obj = false;
            try
            {
                var usuarioBusiness = new UsuarioData();
                bool respuesta= usuarioBusiness.Exists(nombre);              
                return BusinessResultado<bool>.Success(respuesta, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<bool>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<bool> ValidaLogin(UsuarioDto usuario)
        {
            bool obj = false;
            try
            {
                var usuarioBusiness = new UsuarioData();
                bool respuesta = usuarioBusiness.Login(ConfiguracionMapper<UsuarioDto, Usuario>.Convert(usuario));
                return BusinessResultado<bool>.Success(respuesta, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<bool>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<UsuarioDto> Eliminar(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public BusinessResultado<UsuarioDto> Guardar(UsuarioDto usuario)
        {
            try
            {
                var usuarioBusiness = new UsuarioData();
                var all = usuarioBusiness.Add(ConfiguracionMapper<UsuarioDto, Usuario>.Convert(usuario));
                return BusinessResultado<UsuarioDto>.Success(usuario, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<UsuarioDto>.Error(usuario, ex.Message, ex);
            }
        }
    }
}
