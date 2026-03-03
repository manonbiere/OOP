using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public List<Pokemon> list;
        public Pokedex pokedex;
        int first = 1;
        int numPokes = 13;

        public Pokedex1()
        {
            pokedex = new Pokedex();
            list = new List<Pokemon>();
            
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;

            for(int i = 0; i < numPokes; i++)
            {
                list.Add(pokedex.pokemons[i]);
                System.Windows.Controls.Label label = i == 1 ? lblpoke1 : i == 2 ? lblpoke2 : i == 3 ? lblpoke3 : i == 4 ? lblpoke4 : i == 5 ? lblpoke5 : i == 6 ? lblpoke6 : label = i == 7 ? lblpoke7 : i == 7 ? lblpoke7 : i == 8 ? lblpoke8 : i == 9 ? lblpoke9 : i == 10 ? lblpoke10 : i == 11 ? lblpoke11 : i == 12 ? lblpoke12 : lblpoke13;
                label.Content = pokedex.pokemons[i].Name;
            }
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
            pokedex.LastAsked = first;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke2_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+1;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke3_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first +2;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke4_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first + 3;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke5_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+4;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke6_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+5;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke7_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+6;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke8_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+7;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke9_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first +8;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke10_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first +9;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke11_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+10;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke12_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+11;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPoke13_Click(object sender, RoutedEventArgs e)
        {
            pokedex.LastAsked = first+12;
            Pokedex2 next = new Pokedex2(pokedex);
            next.Show();
            this.Close();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (first != 1)
            {
                first -= 13;
                list.Clear();
                for (int j = first; j < numPokes + first; j++)
                {
                    int i = j - first + 1;
                    list.Add(pokedex.pokemons[j]);
                    System.Windows.Controls.Label label = i == 1 ? lblpoke1 : i == 2 ? lblpoke2 : i == 3 ? lblpoke3 : i == 4 ? lblpoke4 : i == 5 ? lblpoke5 : i == 6 ? lblpoke6 : label = i == 7 ? lblpoke1 : i == 7 ? lblpoke7 : i == 8 ? lblpoke8 : i == 9 ? lblpoke9 : i == 10 ? lblpoke10 : i == 11 ? lblpoke11 : i == 12 ? lblpoke12 : lblpoke13;
                    label.Content = pokedex.pokemons[j].Name;
                }
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (first + numPokes < pokedex.pokemons.Count)
            {
                first += 13;
                list.Clear();
                for (int j = first; j < numPokes + first && j < pokedex.pokemons.Count; j++)
                {
                    int i = j - first + 1;
                    list.Add(pokedex.pokemons[j]);
                    System.Windows.Controls.Label label = i == 1 ? lblpoke1 : i == 2 ? lblpoke2 : i == 3 ? lblpoke3 : i == 4 ? lblpoke4 : i == 5 ? lblpoke5 : i == 6 ? lblpoke6 : label = i == 7 ? lblpoke7 : i == 7 ? lblpoke7 : i == 8 ? lblpoke8 : i == 9 ? lblpoke9 : i == 10 ? lblpoke10 : i == 11 ? lblpoke11 : i == 12 ? lblpoke12 : lblpoke13;
                    label.Content = pokedex.pokemons[j].Name;
                }
            }
        }
    }
}
