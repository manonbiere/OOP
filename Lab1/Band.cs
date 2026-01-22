using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Sheet_1
{
    public abstract class Band : IComparable
    {
        //Proprietes
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }

        //Constructor
        public Band(string bandname, int yearFormed, string members)
        {
            BandName = bandname;
            YearFormed = yearFormed;
            Members = members;
        }

        public Band() { }

        //Methods
        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band otherband = obj as Band;
            return BandName.CompareTo(otherband.BandName);
        }
    }

    public class RockBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }

    public class PopBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop Band";
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie Band";
        }
    }
}
