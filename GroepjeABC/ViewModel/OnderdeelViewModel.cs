using GalaSoft.MvvmLight;
using GroepjeABC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepjeABC.ViewModel
{
    public class OnderdeelViewModel : ViewModelBase
    {
        EenhoornOnderdeel _onderdeel;

        public string Naam
        {
            get { return _onderdeel.Naam;}
            set
            {
                _onderdeel.Naam = value;
                RaisePropertyChanged("Naam");
            }
        }

        public int Aantal 
        {
            get { return _onderdeel.Aantal;}
            set
            {
                _onderdeel.Aantal = value;
                RaisePropertyChanged("Aantal");
            }
        }
        public long Lengte
        {
            get { return _onderdeel.Lengte; }
            set
            {
                _onderdeel.Lengte = value;
                RaisePropertyChanged("Lengte");
            }
        }

        public OnderdeelViewModel(EenhoornOnderdeel onderdeel)
        {
            _onderdeel = onderdeel;
        }

        
    }
}
