using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeGit
{
    class Circle
    {
        public void Area()
        {
            Console.Write("Enter Radius of cricle: ");
            String value = Console.ReadLine();
            double area = 2 * Math.PI * Convert.ToInt32(value);
            Console.WriteLine(area);

        }
    }
}
