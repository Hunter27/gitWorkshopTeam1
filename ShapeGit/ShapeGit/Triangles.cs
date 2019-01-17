using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGit
{
    public class Triangle
    {

        public Triangle()
        {
        }

        public void Area()
        {
            Console.Write("Enter side 1 of recatange: ");
            String height = Console.ReadLine();
            Console.Write("Enter side 2 of recatange: ");
            String bases = Console.ReadLine();
            double area = (0.5) * Convert.ToInt32(height) * Convert.ToInt32(bases);
            Console.WriteLine(area);

        }
    }
}
