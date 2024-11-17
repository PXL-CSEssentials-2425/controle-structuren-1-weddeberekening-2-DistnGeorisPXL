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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace wisselgeldcalculator
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

        double amountToPayBack;
        double amountToPayBackTimes100;

        private void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(totalAmountToPayTextBox.Text) && double.TryParse(totalAmountToPayTextBox.Text, out double amountToPayInput) && !string.IsNullOrEmpty(totalAmountReceivedTextBox.Text) && double.TryParse(totalAmountReceivedTextBox.Text, out double amountReceivedInput))
            {
                amountToPayBack = amountReceivedInput - amountToPayInput;
                amountToPayBackTimes100 = amountToPayBack * 100;





            }
            else
            {
                MessageBox.Show("Het gegeven en/of gevraagde bedrag is verkeerd of niet ingevuld.", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}