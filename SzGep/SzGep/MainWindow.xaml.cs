using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzGep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double fin = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            ere.Text=fin + "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int a = int.Parse(szam.Text);
            }
            catch {
                MessageBox.Show("Nem szám!");
                szam.Clear();
            }
        }

        public void Muv(string mv)
        {
            if (mv == "+")
            {
                fin += double.Parse(szam.Text);
                ere.Text = fin + "";
            }else if (mv == "-")
            {
                fin -= double.Parse(szam.Text);
                ere.Text = fin + "";
            }
            else if (mv == "*")
            {
                fin *= double.Parse(szam.Text);
                ere.Text = fin + "";
            }
            else if (mv == "/")
            {
                fin /= double.Parse(szam.Text);
                ere.Text = fin + "";
            }
            else if (mv == "%")
            {
                fin %= double.Parse(szam.Text);
                ere.Text = fin + "";
            }
            else if (mv == "C")
            {
                fin = 0;
                ere.Text = fin + "";
                szam.Clear();
            }

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            Muv("+");
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            Muv("-");
        }

        private void szor_Click(object sender, RoutedEventArgs e)
        {
            Muv("*");
        }

        private void oszt_Click(object sender, RoutedEventArgs e)
        {
            Muv("/");
        }

        private void mar_Click(object sender, RoutedEventArgs e)
        {
            Muv("%");
        }

        private void res_Click(object sender, RoutedEventArgs e)
        {
            Muv("C");
        }
    }
}
