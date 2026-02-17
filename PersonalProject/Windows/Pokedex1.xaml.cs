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

namespace PersonalProject.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Pokedex1 : Window
    {
        public Pokemon Clicked { get; set; }
        public Pokedex1()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow next = new MainWindow();
            next.Show();
            this.Close();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            Guess next = new Guess();
            next.Show();
            this.Close();
        }

        private void btnPokedex_Click(object sender, RoutedEventArgs e)
        {
            Pokedex1 next = new Pokedex1();
            next.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            History next = new History();
            next.Show();
            this.Close();
        }

        private void btnPoke1_Click(object sender, RoutedEventArgs e)
        {
            Pokedex2 next = new Pokedex2();
            next.Show();
            this.Close();
        }
    }
}
