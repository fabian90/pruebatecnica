
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Dto.Clima
{
    public class PronosticoDto
    {
        public int id { get; set; }

        //[StringLength(100)]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "La nombre debe ser minimo de 3 caracteres")]
        [MaxLength(100, ErrorMessage = "La nombre debe ser maximo de 100 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es obligatorio")]
        [MinLength(3, ErrorMessage = "La descripción debe ser minimo de 3 caracteres")]
        [MaxLength(300, ErrorMessage = "La descripción debe ser maximo de 300 caracteres")]
        public string Descripcion { get; set; }  
        public DateTime Fecha { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "El municipio es obligatorio")]
        [MinLength(3, ErrorMessage = "El municipio es obligatorio")]
        public string municipio_id { get; set; }
        [Required(ErrorMessage = "El departamento es obligatorio")]
        public long? departamento_id { get; set; }
        public virtual CiudadDto Ciudad { get; set; }
    }
}
