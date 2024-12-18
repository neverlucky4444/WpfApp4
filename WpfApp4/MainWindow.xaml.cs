using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenRegistrationWindow(object sender, RoutedEventArgs e)
        {
            RegistrationWindow regWindow = new RegistrationWindow();
            regWindow.Show();
        }

        private void OpenTrackSelectionWindow(object sender, RoutedEventArgs e)
        {
            TrackSelectionWindow trackWindow = new TrackSelectionWindow();
            trackWindow.Show();
        }

        private void OpenBookingWindow(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
        }

        private void OpenPaymentWindow(object sender, RoutedEventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow();
            paymentWindow.Show();
        }
    }
}