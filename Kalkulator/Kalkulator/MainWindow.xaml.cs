using System.Windows;
using System.Windows.Controls;

namespace Kalkulator
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Sestej_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Prvo.Text);
            int b = int.Parse(Drugo.Text);
            int v = 0;
            v = a + b;
            Rezultat.Text = v + " ";
        }

        private void Pocisti_Click(object sender, RoutedEventArgs e)
        {
            Prvo.Text = "";
            Drugo.Text = "";
            Rezultat.Text = "";
        }
    }
}
