using System;
using System.Windows;

namespace WpfApp1
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

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            string rez = String.Format("Nakup {0} kart za kupca {1}\n za dogodek {2}",
                sldKarte.Value, txtKupec.Text, cboDogodek.Text);
            MessageBox.Show(rez);
        }
    }
}
