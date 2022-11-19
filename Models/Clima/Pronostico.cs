namespace Models.Clima
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pronostico")]
    public partial class Pronostico
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        [StringLength(30)]
        public string municipio_id { get; set; }

        public DateTime fecha { get; set; }

        public virtual Ciudad Ciudad { get; set; }
    }
}
