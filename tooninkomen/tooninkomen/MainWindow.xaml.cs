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

namespace tooninkomen
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

        private void showIncomeBtn_Click(object sender, RoutedEventArgs e)
        {

            int.TryParse(yearSalaryTextBox.Text, out int yearSalary);
            int.TryParse(yearsTextBox.Text, out int years);

            int totalIncome = ShowIncome(yearSalary, years);

            totalIncomeTextBox.Text = totalIncome.ToString();

        }

        int ShowIncome(int yearSalary, int years)
        {
            return yearSalary * years;
        }
    }
}