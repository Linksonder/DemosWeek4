using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tPleintje.Model;

namespace tPleintje.ViewModel
{
    public class SnackBarItemVM : ViewModelBase
    {
        private SnackBarItem _snack;

        public String Naam
        {
            get { return _snack.Naam; }
        }

        public double Prijs
        {
            get { return _snack.Prijs;  }
        }

        public SnackBarItemVM(SnackBarItem item)
        {
            _snack = item;
        }
    }
}
