using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    public class Pokemon
    {
        // Properties
        public int Index { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Category { get; set; }
        public string Talent { get; set; }
        public string Type { get; set; }
        public int Generation { get; set; }
        public string Evolution { get; set; }
        public string Story { get; set; }
        public string History {  get; set; }


        // Constructor
        public Pokemon(string name, double height, double weight, string category, string talent, string type, int generation, string evolution, string story, int index, string history)
        {
            Name = name;
            Type = type;
            Generation = generation;
            Evolution = evolution;
            Story = story;
            Index = index;
            Height = height;
            Weight = weight;
            Category = category;
            Talent = talent;
            History = history;
        }

        public Pokemon(){ }

        public override string ToString()
        {
            return string.Format($"Name: {Name}, Type: {Type}, Generation: {Generation}, Evolution: {Evolution}, Story: {Story}, Index: {Index}");
        }
    }
}
