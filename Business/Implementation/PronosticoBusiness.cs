using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using Common;
using Dto.Clima;
using Models.Clima;
using Data.Clima;
using Data.Clima.Implementation;
using Common.Helper;

namespace Business.Implementation
{
    public class PronosticoBusiness : IPronosticoBusiness
    {
        public BusinessResultado<PronosticoDto> Actualizar(PronosticoDto pronostico)
        {
            try
            {
                var pronosticoBusiness = new PronosticoData();
                pronosticoBusiness.Update(ConfiguracionMapper<PronosticoDto, Pronostico>.Convert(pronostico));
                return BusinessResultado<PronosticoDto>.Success(pronostico, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<PronosticoDto>.Error(pronostico, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<PronosticoDto>> Consultar()
        {
            IEnumerable<PronosticoDto> obj = new List<PronosticoDto>();
            try
            {
                var pronosticoBusiness = new PronosticoData();
                var mapp = ConfiguracionMapper<Pronostico, PronosticoDto>.ConvertList(pronosticoBusiness.GetAll().ToList());
                return BusinessResultado<IEnumerable<PronosticoDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<PronosticoDto>>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<PronosticoDto>> ConsultarPronosticoPorId(int Id)
        {
            IEnumerable<PronosticoDto> obj = new List<PronosticoDto>();
            try
            {
                var pronosticoBusiness = new PronosticoData();
                var all = pronosticoBusiness.Get(Id);
                var mapp = ConfiguracionMapper<Pronostico, PronosticoDto>.ConvertList(all.ToList());
                return BusinessResultado<IEnumerable<PronosticoDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<PronosticoDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<PronosticoDto> Eliminar(int idpronostico)
        {
            var obj = new PronosticoDto();
            try
            {
                var pronosticoBusiness = new PronosticoData();
                var all = pronosticoBusiness.Delete(idpronostico);
                var mapp = (ConfiguracionMapper<Pronostico, PronosticoDto>.Convert(all));
                return BusinessResultado<PronosticoDto>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<PronosticoDto>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<PronosticoDto> Guardar(PronosticoDto pronostico)
        {
            try
            {
                var pronosticoBusiness = new PronosticoData();
                var all = pronosticoBusiness.Add(ConfiguracionMapper<PronosticoDto, Pronostico>.Convert(pronostico));
                return BusinessResultado<PronosticoDto>.Success(pronostico, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<PronosticoDto>.Error(pronostico, ex.Message, ex);
            }
        }
    }
}
