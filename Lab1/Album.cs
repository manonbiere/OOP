using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Sheet_1
{
    public class Album
    {
        //Proprietes
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public int Sales { get; set; }

        //Constructor
        public Album(string name, int yearOfRelease, int sales)
        {
            Name = name;
            YearOfRelease = yearOfRelease;
            Sales = sales;
        }
        public Album() { }

        //Methods
        public override string ToString()
        {
            return string.Format($"{Name} {YearOfRelease} {Sales}");
        }


    }
}
