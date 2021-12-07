using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace HW8.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive]
        public CarsViewModel SelectedCar { get; set; }

        public ObservableCollection<CarsViewModel> Cars { get; set; }

        public MainWindowViewModel()
        {
            Cars = new ObservableCollection<CarsViewModel>
            {
                new CarsViewModel("Ford-FOCUS", 50000),
                new CarsViewModel("Honda-Civic", 160000)
            };

            SelectedCar = Cars.First();
        }
    }
}
