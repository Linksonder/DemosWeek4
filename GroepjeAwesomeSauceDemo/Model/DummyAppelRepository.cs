using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepjeAwesomeSauceDemo.Model
{
    public class DummyAppelRepository : IAppelRepository
    {
        public IEnumerable<Appel> GetAllAppels()
        {
            return new List<Appel>()
            {
                new Appel{ AantalPitjes = 3, AppelSoort = AppelSoort.Grenny_Smith, HeeftStengel = false },
                new Appel{ AantalPitjes = 2, AppelSoort = AppelSoort.Pink_Lady, HeeftStengel = false },
                new Appel{ AantalPitjes = 5, AppelSoort = AppelSoort.Golden_Delicious, HeeftStengel = true },
            };
        }
    }
}
