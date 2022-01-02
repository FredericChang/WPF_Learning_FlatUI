using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Learning_FlatUI.Core;

namespace WPF_Learning_FlatUI.MVVM.ViewModel
{
    class MainViewModel : ObservbleObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }


        public HomeViewModel HomeVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVm;
            });
        }
    }
}
