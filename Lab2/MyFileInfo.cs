using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    public class MyFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }

        /*public MyFileInfo(string name, long length, DateTime creationTime)
        {
            Name = name;
            Length = length;
            CreationTime = creationTime;
        }*/

        public override string ToString()
        {
            return string.Format("{0,-40}{1,6:F0} MB {2}", Name, Length / 1000, CreationTime.ToShortDateString());
        }
    }
}
