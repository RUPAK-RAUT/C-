using System;

public class AddNumbers
{
    private int number1;
    private int number2;
    private int sum;

    public AddNumbers(int num1, int num2)
    {
        number1 = num1;
        number2 = num2;
        sum = number1 + number2;
    }

    public void DisplaySum()
    {
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        AddNumbers addition = new AddNumbers(num1, num2);

        addition.DisplaySum();
    }
}
