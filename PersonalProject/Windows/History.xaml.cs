using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
using static System.Net.Mime.MediaTypeNames;

namespace PersonalProject.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class History : Window
    {
        public Pokedex pokedex = new Pokedex();
        public History()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;

            List<Pokemon> poke = pokedex.pokemons;
            for (int i = 0; i < poke.Count; i++)
            {
                lbxPoke.Items.Add(poke[i].Name);
            }
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            Guess next = new Guess();
            next.Show();
            this.Close();
        }

        private void btnPokedex_Click(object sender, RoutedEventArgs e)
        {
            Pokedex1 pokedex1 = new Pokedex1();
            pokedex1.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            history.Show();
            this.Close();
        }

        private void btnHome_Clck(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void lbxPoke_SlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            string pokemon = combo.SelectedItem as string;
            Pokemon poke = new Pokemon();

            int i = 0;
            while (pokemon != pokedex.pokemons[i].Name)
            {
                i++;
            }
            poke = pokedex.pokemons[i];

            if (pokedex.pokemons[i].Index < 90)
            {
                string way = $"/Image/Pokemons/{poke.Index}.png";
                imgPoke.Source = new BitmapImage(new Uri(way, UriKind.Relative));
            }
            else
            {
                string way = $"/Image/Pokemons/{poke.Index}.png";
                imgPoke.Source = new BitmapImage(new Uri(way, UriKind.Relative));
            }
            

            txbQuickInfo.Text = $"Generic information : {poke.Name} is a {poke.Type} pokemon (index {poke.Index}). It's height is of {poke.Height} cm for {poke.Weight} kg. It's from the {poke.Category} category and {poke.Talent} is it's talent. When it evolves it becomes {poke.Evolution}";
            txbHistory.Text = $"Behaviour : {poke.History}";
        }
    }
}
