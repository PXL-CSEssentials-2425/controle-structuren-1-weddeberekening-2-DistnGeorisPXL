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

namespace h4rekenmachine
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

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {

            //controleer als beide input velden zijn ingevuld en benoem de input voor verdere berekening:
            if (!string.IsNullOrEmpty(number1TextBox.Text) && double.TryParse(number1TextBox.Text, out double number1input) && !string.IsNullOrEmpty(number2TextBox.Text) && double.TryParse(number2TextBox.Text, out double number2input))
            {
                //berekening van beide inputs
                double plusresult = number1input + number2input;
                //resultaat sturen naar de resultTextBox
                resultTextBox.Text = plusresult.ToString("F2");
            }
            else
            {
                MessageBox.Show("De data die ingevoerd is is ongeldig of onvolledig.", "FOUT", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            //controleer als beide input velden zijn ingevuld en benoem de input voor verdere berekening:
            if (!string.IsNullOrEmpty(number1TextBox.Text) && double.TryParse(number1TextBox.Text, out double number1input) && !string.IsNullOrEmpty(number2TextBox.Text) && double.TryParse(number2TextBox.Text, out double number2input))
            {
                //berekening van beide inputs
                double plusresult = number1input - number2input;
                //resultaat sturen naar de resultTextBox
                resultTextBox.Text = plusresult.ToString("F2");
            }
            else
            {
                MessageBox.Show("De data die ingevoerd is is ongeldig of onvolledig.", "FOUT", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void xBtn_Click(object sender, RoutedEventArgs e)
        {
            //controleer als beide input velden zijn ingevuld en benoem de input voor verdere berekening:
            if (!string.IsNullOrEmpty(number1TextBox.Text) && double.TryParse(number1TextBox.Text, out double number1input) && !string.IsNullOrEmpty(number2TextBox.Text) && double.TryParse(number2TextBox.Text, out double number2input))
            {
                //berekening van beide inputs
                double plusresult = number1input * number2input;
                //resultaat sturen naar de resultTextBox
                resultTextBox.Text = plusresult.ToString("F2");
            }
            else
            {
                MessageBox.Show("De data die ingevoerd is is ongeldig of onvolledig.", "FOUT", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void devideBtn_Click(object sender, RoutedEventArgs e)
        {
            //controleer als beide input velden zijn ingevuld en benoem de input voor verdere berekening:
            if (!string.IsNullOrEmpty(number1TextBox.Text) && double.TryParse(number1TextBox.Text, out double number1input) && !string.IsNullOrEmpty(number2TextBox.Text) && double.TryParse(number2TextBox.Text, out double number2input))
            {
                //berekening van beide inputs
                double plusresult = number1input / number2input;
                //resultaat sturen naar de resultTextBox
                resultTextBox.Text = plusresult.ToString("F2");
            }
            else
            {
                MessageBox.Show("De data die ingevoerd is is ongeldig of onvolledig.", "FOUT", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {               
            number1TextBox.Clear();
            number2TextBox.Clear();
            resultTextBox.Clear();
            number1TextBox.Focus();

        }
    }
}