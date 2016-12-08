using smart_controller.views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace smart_controller
{
    public sealed partial class HomeView : Page
    {
        public HomeView()
        {
            this.InitializeComponent();
        }

        private void tv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TelevisionView));
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MusicView));
        }

        private void lights_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LightsView));
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsView));
        }
    }
}
