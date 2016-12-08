using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace smart_controller.views
{
    public sealed partial class LightsView : Page
    {
        public LightsView()
        {
            this.InitializeComponent();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeView));
        }
    }
}
