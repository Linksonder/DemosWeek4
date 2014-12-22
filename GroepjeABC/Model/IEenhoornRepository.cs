using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepjeABC.Model
{
    public  interface IEenhoornRepository
    {
        IEnumerable<EenhoornOnderdeel> GetAll();
    }
}
