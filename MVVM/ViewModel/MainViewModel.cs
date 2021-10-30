using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModernDesign.Core;


namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel: ObservableObject
    {
        
        //Relay commands (on view)
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        //ViewModel properties
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrnetView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrnetView = HomeVM;

            //Set Home view
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrnetView = HomeVM;
            });

            //Set Discovery view
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrnetView = DiscoveryVM;
            });
        }
    }
}
