using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Computer
    {
        public string Name { get; set; }

        public List<Parts> Parts { get; }

        public Computer()
        {
            Parts = new List<Parts>();
        }
        public void AddParts(Parts parts1)
        {
            Parts.Add(parts1);
        }
        public override string ToString()
        {
            string parts2 = "Computer name: " + Name + "\nComputer Parts:";
            foreach(Parts parts1 in Parts)
            {
                parts2 += parts1.ToString() + "\n";
            }
            return parts2;
        }
    }
}
