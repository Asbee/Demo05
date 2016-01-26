using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Tyres> Tyres { get; }

        public Vehicle()
        {
            Tyres = new List<Tyres>();
        }
        public void AddTyres(Tyres tyre)
        {
            Tyres.Add(tyre);
        }
        public override string ToString()
        {
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + "\nTyres: \n";
            foreach (Tyres tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n";
            }
            return sVehicle;
        }
    }
}
