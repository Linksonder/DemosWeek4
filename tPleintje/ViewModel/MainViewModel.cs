using GalaSoft.MvvmLight;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using tPleintje.Model;

using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace tPleintje.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<SnackBarItemVM> Snacks { get; set; }

        private SnackBarItemVM _selectedSnack;
        public SnackBarItemVM SelectedSnack
        {
            get { return _selectedSnack; }
            set
            {
                _selectedSnack = value;
                RaisePropertyChanged("SelectedSnack");
            }
        }

        public ObservableCollection<SnackBarItemVM> Bestelling { get; set; }
        
        private ISnackRepository repo;

        public ICommand AddSnackCommand { get; set; }

        public ICommand AddWindowCommand { get; set; }
     
        public MainViewModel(ISnackRepository repo)
        {
            this.repo = repo;

            //Stap 1. Ophalen van onze data
            List<SnackBarItem> snacks = repo.GetAll();

            //stap 2. omzetten van model naar viewmodel
            List<SnackBarItemVM> snacksVM = snacks.Select(s => new SnackBarItemVM(s)).ToList();

            //Stap 3. Toevoegen van del ijst aan de observable collectie
            Snacks = new ObservableCollection<SnackBarItemVM>(snacksVM);
            Bestelling = new ObservableCollection<SnackBarItemVM>();

            AddSnackCommand = new RelayCommand(AddSnack);
            AddWindowCommand = new RelayCommand(AddWindow);
        }

        private void AddWindow()
        {
            SnackWindow sn = new SnackWindow();
            sn.Show();
        }

        private void AddSnack()
        {
            Bestelling.Add(SelectedSnack);
        }
    }
}