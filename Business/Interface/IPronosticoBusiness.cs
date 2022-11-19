using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Dto.Clima;

namespace Business.Interface
{
    public interface IPronosticoBusiness
    {
        BusinessResultado<PronosticoDto> Guardar(PronosticoDto pronostico);
        BusinessResultado<IEnumerable<PronosticoDto>> Consultar();
        BusinessResultado<IEnumerable<PronosticoDto>> ConsultarPronosticoPorId(int Id);
        BusinessResultado<PronosticoDto> Eliminar(int idpronostico);
        BusinessResultado<PronosticoDto> Actualizar(PronosticoDto pronostico);
    }
}
