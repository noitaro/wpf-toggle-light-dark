using MaterialDesignThemes.Wpf;
using System;
using System.Windows.Input;

namespace WpfApp2
{
    internal class ToggleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PaletteHelper paletteHelper = new PaletteHelper();
            ITheme theme = paletteHelper.GetTheme();

            theme.SetBaseTheme((bool)parameter ? Theme.Dark : Theme.Light);

            paletteHelper.SetTheme(theme);
        }
    }
}