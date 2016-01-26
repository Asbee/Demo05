using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esim1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DrawingObject drawingobject = new DrawingObject
            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();

            // Create a list collection or drawing object
            List<DrawingObject> drawingobjects = new List<DrawingObject>();
            // Add few objects to collection
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Square());

            //loop collection and draw object
            Console.WriteLine("Drawing object in a list");
            foreach(DrawingObject drawvingObject in drawingobjects)
            {
                drawvingObject.Draw();
            }


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
