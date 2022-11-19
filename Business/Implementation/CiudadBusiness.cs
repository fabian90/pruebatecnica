using Business.Interface;
using Common;
using Common.Helper;
using Data.Clima.Implementation;
using Dto.Clima;
using Models.Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public class CiudadBusiness : ICiudadBusiness
    {
        public BusinessResultado<IEnumerable<CiudadDto>> Consultar()
        {
            IEnumerable<CiudadDto> obj = new List<CiudadDto>();
            try
            {
                var ciudadBusiness = new CiudadData();
                var all = ciudadBusiness.GetAll();
                var mapp = ConfiguracionMapper<Ciudad, CiudadDto>.ConvertList(all.ToList());
                return BusinessResultado<IEnumerable<CiudadDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<CiudadDto>>.Error(obj, ex.Message, ex);
            }
        }

        public BusinessResultado<IEnumerable<CiudadDto>> ConsultarCuidadPorId(long Id)
        {
            IEnumerable<CiudadDto> obj = new List<CiudadDto>();
            try
            {
                var pronosticoBusiness = new CiudadData();
                var all = pronosticoBusiness.Get(Id);
                var mapp = ConfiguracionMapper<Ciudad, CiudadDto>.ConvertList(all.ToList());
                return BusinessResultado<IEnumerable<CiudadDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<CiudadDto>.Error(obj, ex.Message, ex);
            }
        }
    }
}
