using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Parts
    {
        public string Gcard { get; set; }
        public string Mboard { get; set; }
        public string Ram { get; set; }
        public string CPU { get; set; }

        public override string ToString()
        {
            return "\nGraphic card: " + Gcard + "\nMotherboard: " + Mboard + "\nRam: "
                + Ram + "\nCPU: " + CPU;
        }
    }
}
