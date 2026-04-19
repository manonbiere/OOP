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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;

            txb_OverallInfo.Text = "Here is the use of this app :\n\n" +
                "How to use the guessing game ? It is quit easy, you have some clues and " +
                "you must chose the right pokemon in the combo bar in order to win. Once you have the right pokemon you may try to guess the next one." +
                "If you don't find the right pokemon it is still okay only your streak will fail. You can also skip for the next pokemon to guess.\n\n" +
                "Then there is also a pokedex fonction. In the pokedex you may find every pokemons realesed. If you click on a pokemon you may have more information" +
                "about it. looking a bit the same as the pokedex fonction is the history part. you chose a pokemon in the combo box and a picture of it with it's " +
                "story will appear.";

            txb_QuickNews.Text = "Quick News of the mounth : As of early March 2026, the Pokémon world is celebrating its 30th anniversary " +
                "with major announcements, including a new generation of games, a new console release, and several new titles. ";

            txb_PokemonInfo.Text = "Here is some general information on Pokemon :\n\n" +
                "Pokémon is a globally beloved franchise that began in the 1990s and has since become a cultural phenomenon." +
                " It takes place in a world where humans coexist with" +
                " mysterious creatures called Pokémon, each possessing unique abilities and characteristics. Trainers travel across various " +
                "regions, capturing and training Pokémon to battle, grow stronger, and form deep bonds with them. Beyond just competition, " +
                "Pokémon emphasizes friendship, exploration, and adventure, making it a timeless experience enjoyed by people of all ages.";
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

        private void btnHistory_CLick(object sender, RoutedEventArgs e)
        {
            History next = new History();
            next.Show();
            this.Close();
        }

    }
}

