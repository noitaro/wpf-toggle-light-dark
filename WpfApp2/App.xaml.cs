using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Color primaryColor = SwatchHelper.Lookup[MaterialDesignColor.Pink];
            Color accentColor = SwatchHelper.Lookup[MaterialDesignColor.Pink];
            ITheme theme = Theme.Create(new MaterialDesignLightTheme(), primaryColor, accentColor);
            Resources.SetTheme(theme);

            base.OnStartup(e);
        }
    }
}
