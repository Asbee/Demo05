using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Tyres tyres = new Tyres();
            Vehicle vehicle = new Vehicle();


            //Nokia tyres
            tyres.Model = "HakkaPeliitta";
            tyres.Size = "205R16";
            tyres.Name = "Nokia";

            //MIC tyres
            tyres.Model = "Pilot ";
            tyres.Size = "160R17 ";
            tyres.Name = "MIC ";

            //create a car
            
            
            vehicle.Name = "Porsche";
            vehicle.Model = "911";
            vehicle.AddTyres(tyres);
            vehicle.AddTyres(tyres);
            vehicle.AddTyres(tyres);
            vehicle.AddTyres(tyres);
            

            Console.WriteLine(vehicle.ToString());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            
        }
    }
}
