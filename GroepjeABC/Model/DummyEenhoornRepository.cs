using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroepjeABC.Model
{
    class DummyEenhoornRepository : IEenhoornRepository
    {
        public IEnumerable<EenhoornOnderdeel> GetAll()
        {
            return new List<EenhoornOnderdeel>()
            {
                new EenhoornOnderdeel
                {
                    Aantal = 15, 
                    Naam = "Hoorn",
                    Lengte = 23,
                },
                new EenhoornOnderdeel
                {
                    Naam = "Hoofd",
                    Aantal = 3, Lengte = 22, 
                },
                new EenhoornOnderdeel
                {
                    Naam = "Pote",
                    Aantal = 5 ,
                    Lengte = 15,
                }
            };
        }
    }
}
