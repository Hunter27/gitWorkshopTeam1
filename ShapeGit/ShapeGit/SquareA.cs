using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGit
{
    class SquareA
    {
        public void squareArea() {
            Console.Write("Enter side of square: ");
            String length = Console.ReadLine();
            double area = Convert.ToInt32(length) * Convert.ToInt32(length);
            Console.WriteLine(area);
        }
       
    }
}
