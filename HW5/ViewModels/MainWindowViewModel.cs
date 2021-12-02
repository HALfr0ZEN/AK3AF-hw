using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace HW5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _number;
        public int Number 
        { 
            get => _number;
            set => this.RaiseAndSetIfChanged(ref _number, value);
        }

        public ReactiveCommand<Unit, Unit> IncrementCommand { get; }

        public MainWindowViewModel()
        {
            IncrementCommand = ReactiveCommand.Create(Increment);
        }
        private void Increment() => Number++;
    }
}
