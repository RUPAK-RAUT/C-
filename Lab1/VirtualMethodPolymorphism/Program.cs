using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Some animal sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{

    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Animal myAnimal;  

        myAnimal = new Dog();
        myAnimal.Sound(); 

        myAnimal = new Cat();
        myAnimal.Sound();  

        Console.ReadLine();
    }
}
