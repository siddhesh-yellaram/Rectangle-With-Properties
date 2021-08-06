using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleWithProperties.Model;

namespace RectangleWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(200, 30);
            Console.WriteLine("Default Border: "+r1.Border);
            r1.Border = BorderStyle.DOTTED;
            Console.WriteLine("New Border: " + r1.Border);

            Console.ReadLine();

        }
    }
}
