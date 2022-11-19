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
    public class DepartamentoBusiness : IDepartamentoBusiness
    {
        public BusinessResultado<IEnumerable<DepartamentoDto>> Consultar()
        {
            IEnumerable<DepartamentoDto> obj = new List<DepartamentoDto>();
            try
            {
                var departamentoBusiness = new DepartamentoData();
                var mapp = ConfiguracionMapper<Departamento, DepartamentoDto>.ConvertList(departamentoBusiness.GetAll().ToList());
                return BusinessResultado<IEnumerable<DepartamentoDto>>.Success(mapp, Constants.SUCCESS);
            }
            catch (Exception ex)
            {
                return BusinessResultado<IEnumerable<DepartamentoDto>>.Error(obj, ex.Message, ex);
            }
        }
    }
}
