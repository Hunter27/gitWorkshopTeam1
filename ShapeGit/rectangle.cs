using System;

public class rectangle
{
    public void Area()
    {
        Console.Write("Enter side 1 of recatange: ");
        String side1 = Console.ReadLine();
        Console.Write("Enter side 2 of recatange: ");
        String side2 = Console.ReadLine();
        double area = Convert.ToInt32(side1) * Convert.ToInt32(side2);
        Console.WriteLine(area);
    }
}
