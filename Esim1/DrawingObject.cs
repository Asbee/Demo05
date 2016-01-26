using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esim1
{
   abstract class DrawingObject
    {
        public string Name { get; set; }

        public DrawingObject()
        {

        }
        public DrawingObject(string name)
        {
            Name = name;
        }
        public void DoSomething()
        {
            Console.WriteLine("Do Something!");
        }
        public abstract void Draw();
        
    }

}
