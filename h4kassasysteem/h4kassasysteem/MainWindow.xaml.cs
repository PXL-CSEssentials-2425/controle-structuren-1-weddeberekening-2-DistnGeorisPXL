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

namespace h4kassasysteem
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
        bool vatNumberCheck = false;

        private void checkNumberBtn_Click(object sender, RoutedEventArgs e)
        {
            if (vatNumberTextBox.Text.Length == 8) {
                if (!string.IsNullOrEmpty(vatNumberTextBox.Text) && int.TryParse(vatNumberTextBox.Text, out int vatNumberCheckinput))
                {
                    //berekening van controlenummer:
                    //het nummer delen door 97
                    int calculateNumber1 = vatNumberCheckinput / 97;
                    int calulateNumber2 = calculateNumber1 * 97;
                    int calculateNumber3 = vatNumberCheckinput - calulateNumber2;
                    int vatNummerCheckOutput = 97 - calculateNumber3;

                    vatNumberCheckTextBox.Text = vatNummerCheckOutput.ToString("F0");
                    vatNumberCheck = true;
                }
                else
                {
                    MessageBox.Show("Het ondernemmingsnummer die is ingevoerd is ongeldig, Controleer op fouten!", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Het ondernemmingsnummer die is ingevoerd is ongeldig, missende nummers mogelijk!", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(amountTextBox.Text) && int.TryParse(amountTextBox.Text, out int amountInput))
            {
                if (!string.IsNullOrEmpty(priceTextBox.Text) && double.TryParse(priceTextBox.Text, out double priceInput))
                {
                    if(vatNumberCheck == true)
                    {
                        //berekening van prijs * product
                        double amountToPayOutput = priceInput * amountInput;
                        amountToPayTextBox.Text = amountToPayOutput.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Het ondernemersnummer dat u hebt ingevoerd is ongeldig of nog niet gecontroleerd. Zorg er voor dat het nummer correct is en dat u het laat checken door de controle nummer knop.", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Er is een fout bij het prijsgetal. Zorg dat het een getal is en dat er geen andere symbolen of letters zijn.", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            else
            {
                MessageBox.Show("Er is een fout bij het aantal producten. Zorg dat het een getal is en dat er geen komma's worden gebruikt", "FOUT!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            vatNumberTextBox.Clear();
            vatNumberCheckTextBox.Clear();
            amountToPayTextBox.Clear();
            amountTextBox.Text = "0";
            priceTextBox.Text = "0";
            vatNumberTextBox.Focus();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}