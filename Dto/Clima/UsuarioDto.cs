using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Dto.Clima
{
    public  class UsuarioDto
    {
        public int IdUsuario { get; set; }
        [StringLength(100)]
        public string Correo { get; set; }
        public string Clave { get; set; }


        public string ConfirmarClave { get; set; }
    }
}
