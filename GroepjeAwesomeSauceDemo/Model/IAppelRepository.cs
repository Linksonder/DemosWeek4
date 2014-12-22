using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroepjeAwesomeSauceDemo.Model
{
    public interface IAppelRepository
    {
        IEnumerable<Appel> GetAllAppels();
    }
}
