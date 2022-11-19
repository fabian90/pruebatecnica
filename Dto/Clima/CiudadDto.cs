namespace Dto.Clima
{
    using Models.Clima;
    //using Models.Clima;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CiudadDto
    {
        [StringLength(30)]
        public string id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        public long? departamento_id { get; set; }

        public bool? estado { get; set; }

        public virtual DepartamentoDto Departamento { get; set; }

    }
}
