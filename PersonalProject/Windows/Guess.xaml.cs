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
    public partial class Guess : Window
    {
        public Pokemon toGuess;
        public int nbClues;
        public int streak;
        public int totalWin;
        public List<int> clues = new List<int>();
        public Guess()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;
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

        public void RandomClue(int num)
        {
            Random rand = new Random();
            int random = rand.Next(1, num);
            foreach (int i in clues) 
            { 
                if (i == random)
                {
                    random = rand.Next(1, num);
                }
            }
        }

        public void NextClue(int clue)
        {
            if (clue == 0)
            {
                lblType.Content = "Type : " + toGuess.Type;
            }
            if (clue == 1)
            {
                lblGeneration.Content = "Generation :" + toGuess.Generation;
            }
            if (clue == 2)
            {
                lblCategory.Content = "Category : " + toGuess.Category;
            }
            if (clue == 3)
            {
                lblEvolution.Content = "Evolution :" + toGuess.Evolution;
            }
            else
            {                
                if (clue == 4)
                {
                    RandomClue(5);
                }
                if (clue == 5)
                {
                    lblClue2.Content = "Clue 2 : " + toGuess.Category;
                }
                if (clue == 6)
                {
                    lblClue3.Content = "Clue 3 :" + toGuess.Evolution;
                }
            }
            
        }
    }
}
