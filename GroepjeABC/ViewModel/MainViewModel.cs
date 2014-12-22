using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GroepjeABC.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;


namespace GroepjeABC.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IEenhoornRepository repo;

        public ObservableCollection<OnderdeelViewModel> Onderdelen { get; set; }

        public ObservableCollection<OnderdeelViewModel> Eenhoorn { get; set; }

        private OnderdeelViewModel _selectedOnderdeel;
        public OnderdeelViewModel SelectedOnderdeel
        {
            get { return _selectedOnderdeel; }
            set
            {
                _selectedOnderdeel = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddOnderdeelCommand { get; set; }

        public ICommand OpenPonyCommand { get; set; }
        
        public MainViewModel(IEenhoornRepository repo)
        {
            this.repo = repo;

            //1. Lijstje ophalen
            var lijstje = repo.GetAll();

            //2. Lijstje omzetten naar viewmodels
            var lijstjeVM = lijstje.Select(o => new OnderdeelViewModel(o));

            //3. voer het lijstje aan de collectie
            Onderdelen = new ObservableCollection<OnderdeelViewModel>(lijstjeVM);

            Eenhoorn = new ObservableCollection<OnderdeelViewModel>();

            AddOnderdeelCommand = new RelayCommand(AddOnderdeel);
            OpenPonyCommand = new RelayCommand(OpenPony);

        }

        private void OpenPony()
        {
            EenhoorWindow eenhoor = new EenhoorWindow();
            eenhoor.Show();
        }

        public void AddOnderdeel()
        {
            Eenhoorn.Add(SelectedOnderdeel);
        }


    }
}