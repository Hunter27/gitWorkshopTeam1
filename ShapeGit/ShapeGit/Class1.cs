using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGit
{
    class Rhombus
    {
        public void Area()
        {
            double side, area;
            Console.WriteLine("Enter the Length of Side : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }

    }
}
