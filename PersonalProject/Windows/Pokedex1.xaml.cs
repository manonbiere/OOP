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
        int first = 0;
        int numPokes = 13;
        bool last = false;

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
                System.Windows.Controls.Label label = i == 0 ? lblpoke1 : i == 1 ? lblpoke2 : i == 2 ? lblpoke3 : i == 3 ? lblpoke4 : i == 4 ? lblpoke5 : i == 5 ? lblpoke6 : i == 6 ? lblpoke7 : i == 7 ? lblpoke8 : i == 8 ? lblpoke9 : i == 9 ? lblpoke10 : i == 10 ? lblpoke11 : i == 11 ? lblpoke12 : lblpoke13;
                label.Content = pokedex.pokemons[i].Name;

                System.Windows.Controls.Image image = i == 0 ? imgPoke1 : i == 1 ? imgPoke2 : i == 2 ? imgPoke3 : i == 3 ? imgPoke4 : i == 4 ? imgPoke5 : i == 5 ? imgPoke6 : i == 6 ? imgPoke7 : i == 7 ? imgPoke8 : i == 8 ? imgPoke9 : i == 9 ? imgPoke10 : i == 10 ? imgPoke11 : i == 11 ? imgPoke12 : imgPoke13;
                string way = $"/Image/pokemon/pokemon/{pokedex.pokemons[i].Index}.png";
                image.Source = new BitmapImage(new Uri(way, UriKind.Relative));
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
            if (first != 0)
            {
                if (last)
                {
                    for (int i = 0; i < numPokes; i++)
                    {
                        System.Windows.Controls.Button button = i == 0 ? btnPoke1 : i == 1 ? btnPoke2 : i == 2 ? btnPoke3 : i == 3 ? btnPoke4 : i == 4 ? btnPoke5 : i == 5 ? btnPoke6 : i == 6 ? btnPoke7 : i == 7 ? btnPoke8 : i == 8 ? btnPoke9 : i == 9 ? btnPoke10 : i == 10 ? btnPoke11 : i == 11 ? btnPoke12 : btnPoke13;
                        button.Opacity = 1;

                        System.Windows.Controls.Image image = i == 0 ? imgPoke1 : i == 1 ? imgPoke2 : i == 2 ? imgPoke3 : i == 3 ? imgPoke4 : i == 4 ? imgPoke5 : i == 5 ? imgPoke6 : i == 6 ? imgPoke7 : i == 7 ? imgPoke8 : i == 8 ? imgPoke9 : i == 9 ? imgPoke10 : i == 10 ? imgPoke11 : i == 11 ? imgPoke12 : imgPoke13;
                        image.Opacity = 1;
                    }
                    last = false;
                }

                first -= 13;
                list.Clear();

                for (int j = first; j < numPokes + first; j++)
                {
                    int i = j - first;
                    list.Add(pokedex.pokemons[j]);

                    System.Windows.Controls.Label label = i == 0 ? lblpoke1 : i == 1 ? lblpoke2 : i == 2 ? lblpoke3 : i == 3 ? lblpoke4 : i == 4 ? lblpoke5 : i == 5 ? lblpoke6 : i == 6 ? lblpoke7 : i == 7 ? lblpoke8 : i == 8 ? lblpoke9 : i == 9 ? lblpoke10 : i == 10 ? lblpoke11 : i == 11 ? lblpoke12 : lblpoke13; 
                    label.Content = pokedex.pokemons[j].Name;

                    System.Windows.Controls.Image image = i == 0 ? imgPoke1 : i == 1 ? imgPoke2 : i == 2 ? imgPoke3 : i == 3 ? imgPoke4 : i == 4 ? imgPoke5 : i == 5 ? imgPoke6 : i == 6 ? imgPoke7 : i == 7 ? imgPoke8 : i == 8 ? imgPoke9 : i == 9 ? imgPoke10 : i == 10 ? imgPoke11 : i == 11 ? imgPoke12 : imgPoke13;
                    
                    string way = $"/Image/pokemon/pokemon/{pokedex.pokemons[j].Index}.png";
                    image.Source = new BitmapImage(new Uri(way, UriKind.Relative));
                    
                }
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (first + 2 * numPokes < pokedex.pokemons.Count)
            {
                Console.WriteLine("first = " + first);
                last = false;
                first += 13;
                list.Clear();
                for (int j = first; j < numPokes + first && j < pokedex.pokemons.Count; j++)
                {
                    int i = j - first;
                    list.Add(pokedex.pokemons[j]);
                    
                    System.Windows.Controls.Label label = i == 0 ? lblpoke1 : i == 1 ? lblpoke2 : i == 2 ? lblpoke3 : i == 3 ? lblpoke4 : i == 4 ? lblpoke5 : i == 5 ? lblpoke6 : i == 6 ? lblpoke7 : i == 7 ? lblpoke8 : i == 8 ? lblpoke9 : i == 9 ? lblpoke10 : i == 10 ? lblpoke11 : i == 11 ? lblpoke12 : lblpoke13; 
                    label.Content = pokedex.pokemons[j].Name;

                    System.Windows.Controls.Image image = i == 0 ? imgPoke1 : i == 1 ? imgPoke2 : i == 2 ? imgPoke3 : i == 3 ? imgPoke4 : i == 4 ? imgPoke5 : i == 5 ? imgPoke6 : i == 6 ? imgPoke7 : i == 7 ? imgPoke8 : i == 8 ? imgPoke9 : i == 9 ? imgPoke10 : i == 10 ? imgPoke11 : i == 11 ? imgPoke12 : imgPoke13;
                    
                    string way = $"/Image/pokemon/pokemon/{pokedex.pokemons[j].Index}.png";
                    image.Source = new BitmapImage(new Uri(way, UriKind.Relative));
                    
                }
            }
            else
            {
                if (!last)
                {
                    Console.WriteLine("first = " + first);
                    first += 13;
                    list.Clear();
                    int j = first;
                    while(j < pokedex.pokemons.Count)
                    {
                        int i = j - first;
                        list.Add(pokedex.pokemons[j]);
                        System.Windows.Controls.Label label = i == 0 ? lblpoke1 : i == 1 ? lblpoke2 : i == 2 ? lblpoke3 : i == 3 ? lblpoke4 : i == 4 ? lblpoke5 : i == 5 ? lblpoke6 : i == 6 ? lblpoke7 : i == 7 ? lblpoke8 : i == 8 ? lblpoke9 : i == 9 ? lblpoke10 : i == 10 ? lblpoke11 : i == 11 ? lblpoke12 : lblpoke13; 
                        label.Content = pokedex.pokemons[j].Name;
                        j++;
                    }
                    Console.WriteLine("first = " + first);
                    while (j < first + numPokes)
                    {
                        int i = j - first;
                        //list.Add(pokedex.pokemons[j]);
                        System.Windows.Controls.Label label = i == 0 ? lblpoke1 : i == 1 ? lblpoke2 : i == 2 ? lblpoke3 : i == 3 ? lblpoke4 : i == 4 ? lblpoke5 : i == 5 ? lblpoke6 : i == 6 ? lblpoke7 : i == 7 ? lblpoke8 : i == 8 ? lblpoke9 : i == 9 ? lblpoke10 : i == 10 ? lblpoke11 : i == 11 ? lblpoke12 : lblpoke13; 
                        label.Content = "";
                        System.Windows.Controls.Button button = i == 0 ? btnPoke1 : i == 1 ? btnPoke2 : i == 2 ? btnPoke3 : i == 3 ? btnPoke4 : i == 4 ? btnPoke5 : i == 5 ? btnPoke6 : i == 6 ? btnPoke7 : i == 7 ? btnPoke8 : i == 8 ? btnPoke9 : i == 9 ? btnPoke10 : i == 10 ? btnPoke11 : i == 11 ? btnPoke12 : btnPoke13;
                        button.Opacity = 0;
                        System.Windows.Controls.Image image = i == 0 ? imgPoke1 : i == 1 ? imgPoke2 : i == 2 ? imgPoke3 : i == 3 ? imgPoke4 : i == 4 ? imgPoke5 : i == 5 ? imgPoke6 : i == 6 ? imgPoke7 : i == 7 ? imgPoke8 : i == 8 ? imgPoke9 : i == 9 ? imgPoke10 : i == 10 ? imgPoke11 : i == 11 ? imgPoke12 : imgPoke13;
                        image.Opacity = 0;
                        j++;
                    }
                    last = true;
                    Console.WriteLine("first = " + first);
                }
            }
        }
    }
}
