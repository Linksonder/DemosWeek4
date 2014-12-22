using GalaSoft.MvvmLight;
using GroepjeAwesomeSauceDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroepjeAwesomeSauceDemo.ViewModel
{
    public class AppelVM : ViewModelBase
    {
        private Appel _appel;

        public int AantalPitjes
        {
            get { return _appel.AantalPitjes; }
            set
            {
                _appel.AantalPitjes = value;
                RaisePropertyChanged("AantalPitjes");
            }
        }

        public AppelSoort AppelSoort
        {
            get { return _appel.AppelSoort; }
            set
            {
                _appel.AppelSoort = value;
                RaisePropertyChanged("AppelSoort");
            }
        }


        public bool HeeftStengel
        {
            get { return _appel.HeeftStengel; }
            set
            {
                _appel.HeeftStengel = value;
                RaisePropertyChanged("HeeftStengel");
            }
        }

        public AppelVM()
        {
            this._appel = new Appel();
        }


        public AppelVM(Appel appel)
        {
            this._appel = appel;
        }
    }
}
