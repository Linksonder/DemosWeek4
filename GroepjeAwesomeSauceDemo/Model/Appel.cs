using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepjeAwesomeSauceDemo.Model
{
    public enum AppelSoort{

        Grenny_Smith, 
        Pink_Lady, 
        Golden_Delicious
    }

    public class Appel
    {
        public int AantalPitjes { get; set; }

        public AppelSoort AppelSoort { get; set; }

        public bool HeeftStengel { get; set; }

    }
}
