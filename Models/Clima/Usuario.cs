namespace Models.Clima
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(500)]
        public string Clave { get; set; }
    }
}
