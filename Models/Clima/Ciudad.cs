namespace Models.Clima
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ciudad")]
    public partial class Ciudad
    {
        public Ciudad()
        {
            this.Pronostico = new HashSet<Pronostico>();
        }

        [StringLength(30)]
        public string id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        public long? departamento_id { get; set; }

        public bool? estado { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual ICollection<Pronostico> Pronostico { get; set; }
    }
}
