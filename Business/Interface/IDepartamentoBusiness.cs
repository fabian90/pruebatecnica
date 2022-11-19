using Common;
using Dto.Clima;
using Models.Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IDepartamentoBusiness
    {
        BusinessResultado<IEnumerable<DepartamentoDto>> Consultar();
    }
}
