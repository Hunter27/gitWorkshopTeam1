using System;

public class Circle
{
    public void Area()
    {
        Console.Write("Enter Radius of cricle: ");
        String value = Console.ReadLine();
        double area = 2 * Math.PI * Convert.ToInt32(value);
        Console.WriteLine(area);

    }
}
