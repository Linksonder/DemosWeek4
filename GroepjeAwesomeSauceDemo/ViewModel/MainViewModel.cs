using GalaSoft.MvvmLight;
using GroepjeAwesomeSauceDemo.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace GroepjeAwesomeSauceDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IAppelRepository _repo;

        public ObservableCollection<AppelVM> AppeltjesVoorDeDorst { get; set; }

        public AppelVM SelectedAppel { get; set; }

        public MainViewModel(IAppelRepository repo)
        {
            this._repo = repo;

            var appeltjes = repo.GetAllAppels().Select(a => new AppelVM(a));

            this.AppeltjesVoorDeDorst = new ObservableCollection<AppelVM>(appeltjes);

            SelectedAppel = new AppelVM();
        }
    }
}