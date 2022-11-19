using Dto.Clima;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PageList
    {
        public IPagedList<PronosticoDto> pronosticos { get; set; }
    }
}
