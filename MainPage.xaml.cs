using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace smart_controller
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void tv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(views.TelevisionView));
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(views.MusicView));
        }

        private void lights_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(views.LightsView));
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(views.SettingsView));
        }
    }
}
