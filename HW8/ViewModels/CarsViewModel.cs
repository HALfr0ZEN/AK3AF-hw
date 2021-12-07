using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.ViewModels
{
    public class CarsViewModel:ViewModelBase
    {
        
        [Reactive]
        public string Name { get; set; }

        [Reactive]
        public int Cost { get; set; }


        public CarsViewModel(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
