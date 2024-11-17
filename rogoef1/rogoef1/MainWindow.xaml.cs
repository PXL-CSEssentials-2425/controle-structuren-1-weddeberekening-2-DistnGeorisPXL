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

namespace rogoef1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redBtn_Click(object sender, RoutedEventArgs e)
        {
            redImage.Visibility = Visibility.Visible;


        }

        private void orangeBtn_Click(object sender, RoutedEventArgs e)
        {
            orangeImage.Visibility = Visibility.Visible;
        }

        private void greenBtn_Click(object sender, RoutedEventArgs e)
        {
            greenImage.Visibility=Visibility.Visible;
        }
    }
}