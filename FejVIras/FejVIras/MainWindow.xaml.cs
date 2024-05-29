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

namespace FejVIras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string nv;
        public int penz;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void be_Click(object sender, RoutedEventArgs e)
        {
            nv = nev.Text;
            penz = int.Parse(egy.Text);
            nh.Text = nv;
            eh.Text = "Egyenleged: " + penz+"ft";
            be.IsEnabled = false;
            nev.IsEnabled = false;
            egy.IsEnabled = false;
            tet.IsEnabled = true;
            tipp.IsEnabled = true;
            game.IsEnabled = true;

        }

        private void game_Click(object sender, RoutedEventArgs e)
        {
            if (penz >= 1)
            {
                Random r = new Random();
                int a = r.Next(1, 3);
                string enemy = "";
                if (a == 1)
                    enemy = "fej";
                else
                    enemy = "írás";
                fin.Text = enemy;
                if (enemy == tipp.Text)
                {
                    MessageBox.Show("Win");
                    penz += int.Parse(tet.Text);
                }
                else
                {
                    MessageBox.Show("Lose");
                    penz-= int.Parse(tet.Text);
                }
                eh.Text = "Egyenleged: " + penz + "ft";
            }
            else
            {
                MessageBox.Show("Nincs pénzed!");
                this.Close();
            }
        }
    }
}
