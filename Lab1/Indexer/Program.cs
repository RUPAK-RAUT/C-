using System;

public class StudentCollection
{
    private string[] studentNames = new string[5];

    // Indexer to get or set student names
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < studentNames.Length)
            {
                return studentNames[index];
            }
            else
            {
                return "Invalid Index";
            }
        }
        set
        {
            if (index >= 0 && index < studentNames.Length)
            {
                studentNames[index] = value;
            }
            else
            {
                Console.WriteLine("Invalid Index. Cannot set value.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentCollection students = new StudentCollection();

        students[0] = "Kalyan";
        students[1] = "Hehe";
        students[2] = "Huhu";
        students[3] = "phirrrr";
        students[4] = "hahaha";
        Console.WriteLine("Student Names:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student {i + 1}: {students[i]}");
        }
    }
}
