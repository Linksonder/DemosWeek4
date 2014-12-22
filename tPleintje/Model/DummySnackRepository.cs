using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tPleintje.Model
{
    public class DummySnackRepository : ISnackRepository
    {
        public List<SnackBarItem> GetAll()
        {
            return new List<SnackBarItem>()
            {
                new SnackBarItem{Naam="Kaassoeflee", Prijs=1.20},
                new SnackBarItem{Naam="Broodje Bakpauw", Prijs=1.60},
                new SnackBarItem{Naam="Bounty gefrituurd", Prijs=1},
                new SnackBarItem{Naam="Frikadel", Prijs=0.90},
            };
        }
    }
}
