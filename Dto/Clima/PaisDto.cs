namespace Dto.Clima
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PaisDto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaisDto()
        {
            Departamento = new HashSet<DepartamentoDto>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(60)]
        public string nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartamentoDto> Departamento { get; set; }
    }
}
