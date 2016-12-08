using Windows.UI.Xaml.Controls;

namespace smart_controller.views
{
    public sealed partial class TelevisionView : Page
    {
        public TelevisionView()
        {
            this.InitializeComponent();
        }

        private void home_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeView));
        }
    }
}
