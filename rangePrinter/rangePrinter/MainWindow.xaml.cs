using System;
using System.Windows;

namespace rangePrinter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int startNumber = int.Parse(txtStart.Text);
                int endNumber = int.Parse(txtEnd.Text);

                // Bevestigingsvenster met Yes/No
                MessageBoxResult result = MessageBox.Show("Wil je de getallen printen?", "Bevestiging", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    // Exit als 'No' wordt gekozen
                    return;
                }

                // Clear de TextBlock voor het resultaat
                txtResult.Text = "";

                // Loop door de range en print de getallen
                for (int i = startNumber; i <= endNumber; i++)
                {
                    if (i % 2 == 0)  // Als het getal even is
                    {
                        txtResult.Text += $"{i} ";  // Voeg het even getal toe
                    }
                    else  // Als het getal oneven is
                    {
                        txtResult.Text += $"{i}\n";  // Voeg het oneven getal toe en begin een nieuwe regel
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Voer geldige getallen in.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}