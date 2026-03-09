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
using static System.Net.Mime.MediaTypeNames;

namespace PersonalProject.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Pokedex2 : Window
    {
        public Pokedex pokedex;
        public int nowSeeing;
        public Pokemon Actual;
        public Pokedex2(Pokedex pokedex1)
        {
            pokedex = pokedex1;
            nowSeeing = pokedex.LastAsked;

            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;

            ShowPoke();
        }

        public void ShowPoke()
        {
            Actual = pokedex.pokemons[nowSeeing];
            
            string way = $"/Image/Pokemons/{Actual.Index}.png";
            imgPoke.Source = new BitmapImage(new Uri(way, UriKind.Relative));
            
            lblCate.Content = "Category : " + Actual.Category;
            lblEvo.Content = "Evolution : " + Actual.Evolution;
            lblGene.Content = "Generation : " + Actual.Generation;
            lblHeight.Content = "Height : " + Actual.Height;
            lblIndex.Content = "Index : " + Actual.Index;
            lblTalent.Content = "Talent : " + Actual.Talent;
            lblType.Content = "Type : " + Actual.Type;
            lblWeight.Content = "Weight : " + Actual.Weight;
            lblName.Content = "Name : " + Actual.Name;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(nowSeeing < pokedex.pokemons.Count)
            {
                nowSeeing++;
                ShowPoke();
            }
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (nowSeeing > 0)
            {
                nowSeeing--;
                ShowPoke();
            }
        }

        private void btnGuess_click(object sender, RoutedEventArgs e)
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
    }
}
