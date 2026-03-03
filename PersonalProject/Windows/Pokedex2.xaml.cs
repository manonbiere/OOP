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


        }
    }
}
