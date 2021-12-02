using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace HW7.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        [Reactive]
        public int Num1 { get; set; }
        [Reactive]
        public int Num2 { get; set; }
        [ObservableAsProperty]
        public int Result { get; set; }
        public MainWindowViewModel()
        {
            Num1 = 2;
            Num2 = 3;

            _ = this.WhenAnyValue(x => x.Num1, x => x.Num2, (a, b) => a + b).ToPropertyEx(this, x => x.Result);
        }

    }
}
