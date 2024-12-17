using System;


class Animal
{
    public void Eat()
    {
        Console.WriteLine("I can eat!");
    }
}

class Dog : Animal  
{
    public void Bark()
    {
        Console.WriteLine("I can bark!");
    }
}


interface IFly
{
    void Fly();
}

interface ISwim
{
    void Swim();
}

class Duck : IFly, ISwim  
{
    public void Fly()
    {
        Console.WriteLine("I can fly!");
    }

    public void Swim()
    {
        Console.WriteLine("I can swim!");
    }
}

// Multilevel Inheritance
class BabyDog : Dog
{
    public void Weep()
    {
        Console.WriteLine("I can weep!");
    }
}

// Hierarchical Inheritance
class Cat : Animal 
{
    public void Meow()
    {
        Console.WriteLine("I can meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single Inheritance
        Dog dog = new Dog();
        Console.WriteLine("Single Inheritance:");
        dog.Eat();
        dog.Bark();
        Console.WriteLine();

        // Multiple Inheritance (using interfaces)
        Duck duck = new Duck();
        Console.WriteLine("Multiple Inheritance:");
        duck.Fly();
        duck.Swim();
        Console.WriteLine();

        // Multilevel Inheritance
        BabyDog babyDog = new BabyDog();
        Console.WriteLine("Multilevel Inheritance:");
        babyDog.Eat();
        babyDog.Bark();
        babyDog.Weep();
        Console.WriteLine();

        // Hierarchical Inheritance
        Cat cat = new Cat();
        Console.WriteLine("Hierarchical Inheritance:");
        cat.Eat();
        cat.Meow();
    }
}
