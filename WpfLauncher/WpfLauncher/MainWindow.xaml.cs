using System.Diagnostics;

namespace WpfLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void LaunchVenomEventButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Process.Start(App.TheVenomEventExePath);
        }
    }
}
