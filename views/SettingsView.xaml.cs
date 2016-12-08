using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace smart_controller.views
{
    public sealed partial class SettingsView : Page
    {
        public SettingsView()
        {
            this.InitializeComponent();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeView));
        }
    }
}
