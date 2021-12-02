using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace HW6.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        [Reactive]
        public int Num1 { get; set; }
        [Reactive]
        public int Num2 { get; set; }

        public MainWindowViewModel()
        {
            Num1 = 2;
            Num2 = 3;

            _result = this.WhenAnyValue(x => x.Num1, x => x.Num2, (a, b) => a + b).ToProperty(this, x => x.Result);
        }

        private readonly ObservableAsPropertyHelper<int> _result;
        public int Result => _result.Value;
    }
}
