using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalProject;

namespace PersonalProject
{
    public class Pokedex
    {
        List<string> type {get; set;}
        List<Pokemon> pokemons { get; set; }

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
            pokemons.Add(new Pokemon("Bulbizarre", 0.7, 6.9, "Graine", "Engrais", "Plante & Poison", 1, "Herbizarre", "Au debut de sa vie, il se nourrit des nutriments accumules dans la graine de son dos. Cela lui permet de grandir", 1));
            pokemons.Add(new Pokemon("Herbizarre", 1.0, 13.0, "Graine", "Engrais", "Plante & Poison", 1, "Florizarre", "Plus il s'expose au soleil, plus il emmagasine d'energie, ce qui permet au bourgeon sur son dos de se develloper", 2));
            pokemons.Add(new Pokemon("Florizarre", 2.0, 100.0, "Graine", "Engrais", "Plante & Poison", 1, "None", "Ce pokemon est capable de transformer la lumiere du soleil en energie. Il est donc encore plus fort en ete", 3));
        }
    }
}
