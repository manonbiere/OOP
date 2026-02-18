using PersonalProject;
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

namespace PersonalProject.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Guess : Window
    {
        public Random rand = new Random();
        public Pokedex pokedex = new Pokedex();
        public Pokemon toGuess;
        public int nbClues;
        public int streak;
        public int totalWin;
        public List<int> clues;
        public int higheststreak;
        public string guessed;
        public bool found;
        public bool opac = true;
        public Guess()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;

            List<Pokemon> poke = pokedex.pokemons;
            for (int i = 0; i < poke.Count; i++)
            {
                lbxPokemon.Items.Add(poke[i].Name);
            }

            Start();
            streak = 0;
            totalWin = 0;
            higheststreak = 0;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            Guess next = new Guess();
            next.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            History next = new History();
            next.Show();
            this.Close();
        }

        private void btnPokedex_Click(object sender, RoutedEventArgs e)
        {
            Pokedex1 next = new Pokedex1();
            next.Show();
            this.Close();
        }

        public void RandomClue(int index)
        {
            System.Windows.Controls.TextBlock label = index == 1 ? lblClue1 : index == 2 ? lblClue2 : lblClue3;
            int random = rand.Next(1, 5);

            
            while (clues.Any(x => x == random))
            {
                random = rand.Next(1, 5);
            }

            clues.Add(random);

            switch (random)
            {
                case 0:
                    label.Text = $"Clue {index} : The height of this pokemon is {toGuess.Height} cm";
                    break;
                case 1:
                    label.Text = $"Clue {index} : The Weight of this pokemon is {toGuess.Weight} kg";
                    break;
                case 2:
                    label.Text = $"Clue {index} : {toGuess.Talent} is the talent of this pokemon";
                    break;
                case 3:
                    label.Text = $"Clue {index} : {toGuess.Story}";
                    break;
                case 4:
                    label.Text = $"Clue {index} : This pokemon's index is {toGuess.Index}";
                    break;
            }

        }

        public void NextClue(int clue)
        {
            switch (clue)
            {
                case 0:
                    lblType.Content = "Type : " + toGuess.Type;
                    break;
                case 1:
                    lblGeneration.Content = "Generation : " + toGuess.Generation;
                    break;
                case 2:
                    lblCategory.Content = "Category : " + toGuess.Category;
                    break;
                case 3:
                    lblEvolution.Content = "Evolution : " + toGuess.Evolution;
                    break;
                case 4:
                    RandomClue(1);
                    break;
                case 5:
                    RandomClue(2);
                    break;
                case 6:
                    RandomClue(3);
                    break;
            }
        }
        public void Start()
        {
            btnNext.Opacity = 0;
            opac = true;
            found = false;
            lbxPokemon.Text = ""; 
            lblType.Content = $"Type :";
            lblGeneration.Content = $"Generation :";
            lblCategory.Content = $"Category :";
            lblEvolution.Content = $"Evolution :";
            lblClue1.Text = $"Clue 1 :";
            lblClue2.Text = $"Clue 2 :";
            lblClue3.Text = $"Clue 3 :";
            txbResult.Text = $"";

            nbClues = 0; 
            List<Pokemon> poke = pokedex.pokemons;
            int randomPoke = rand.Next(1, poke.Count + 1);
            toGuess = poke[randomPoke - 1];
            clues = new List<int>();
            NextClue(nbClues);
            nbClues++;
        }

        private void lbxPokemon_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            guessed = combo.SelectedItem as string;
            if(guessed == toGuess.Name)
            {
                btnNext.Opacity = 1;
                txbResult.Text = $"SUCESS";
                opac = false;
                found = true;
            }
            else
            {
                if(nbClues == 7)
                {
                    btnNext.Opacity = 1;
                    txbResult.Text = $"THE POKEMON TO GUESS WAS {toGuess.Name}";
                    opac = false;
                }
                else
                {
                    NextClue(nbClues);
                    nbClues++;
                }
            }
        }

        private void btnSkip_Click(object sender, RoutedEventArgs e)
        {
            if (streak > higheststreak)
            {
                higheststreak = streak;
                lblHighestStrike.Content = $"Highest Streak Count = {higheststreak}";
            }
            streak = 0;
            lblStrike.Content = $"Streak = {streak}";
            Start();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (!opac)
            {
                if (found)
                {
                    streak += 1;
                    lblStrike.Content = $"Streak = {streak}";
                    totalWin += 1;
                    lblTotalWin.Content = $"Total Win = {totalWin}";
                    if (streak > higheststreak)
                    {
                        higheststreak = streak;
                        lblHighestStrike.Content = $"Highest Streak Count = {higheststreak}";
                    }
                    Start();
                }
                else
                {
                    streak = 0;
                    lblStrike.Content = $"Streak = {streak}";
                    Start();
                }
            }
        }
    }
}
