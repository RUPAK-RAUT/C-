using System;


interface ILength
{
    double Length { get; set; }
}


interface IWidth
{
    double Width { get; set; }
}


class Rectangle : ILength, IWidth
{
    public double Length { get; set; }
    public double Width { get; set; }


    public double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Rectangle rect = new Rectangle();

       
        Console.Write("Enter the length of the rectangle: ");
        rect.Length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        rect.Width = Convert.ToDouble(Console.ReadLine());

       
        double area = rect.CalculateArea();
        Console.WriteLine($"\nThe area of the rectangle is: {area}");
    }
}
