namespace Dto.Clima
{
    using Models.Clima;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Departamento")]
    public partial class DepartamentoDto
    {     
        public long id { get; set; }
        [StringLength(100)]
        public string nombre { get; set; }
        public long? pais_id { get; set; }
        public bool? estado { get; set; }    
    }
}
