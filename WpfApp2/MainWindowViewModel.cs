using System.Windows.Input;

namespace WpfApp2
{
    internal class MainWindowViewModel
    {
        public ICommand ToggleCommand { get; } = new ToggleCommand();
    }
}