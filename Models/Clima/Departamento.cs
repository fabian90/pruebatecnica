namespace Models.Clima
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Departamento")]
    public partial class Departamento
    {
        public Departamento()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        public long? pais_id { get; set; }

        public bool? estado { get; set; }
     
        public virtual ICollection<Ciudad> Ciudad { get; set; }

        public virtual Pais Pais { get; set; }
    }
}
