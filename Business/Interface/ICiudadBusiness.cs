using Common;
using Dto.Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface ICiudadBusiness
    {
        BusinessResultado<IEnumerable<CiudadDto>> Consultar();
        BusinessResultado<IEnumerable<CiudadDto>> ConsultarCuidadPorId(long Id);
    }
}
