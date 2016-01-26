using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Parts parts = new Parts();
            Computer com = new Computer();

            //Computer parts
            parts.Gcard = "Geforce GTX 970";
            parts.CPU = "Amd FX-8830";
            parts.Mboard = "ASUS M28476";
            parts.Ram = "8GB HyperX";

            //COM name
            com.Name = "Default Computer";
            com.AddParts(parts);
            

            Console.WriteLine(com.ToString());

        }
    }
}
