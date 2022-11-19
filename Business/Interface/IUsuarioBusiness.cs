using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Dto.Clima;
using Models.Clima;

namespace Business.Interface
{
    public interface IUsuarioBusiness
    {
        BusinessResultado<UsuarioDto> Guardar(UsuarioDto usuario);
        BusinessResultado<IEnumerable<UsuarioDto>> Consultar();
        BusinessResultado<bool> ConsultarUsuarioPorEmail(string nombre);
        BusinessResultado<bool> ValidaLogin(UsuarioDto usuario);
        BusinessResultado<UsuarioDto> Eliminar(long idusuario);
        BusinessResultado<UsuarioDto> Actualizar(UsuarioDto usuario);
    }
}
