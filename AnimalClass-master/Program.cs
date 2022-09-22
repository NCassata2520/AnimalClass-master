using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?");
            Console.WriteLine("Pig [1]  , Dog [2]  , Bird [3] , Cat [4]");
            var choice = Console.ReadLine();

            Animal animal = null;

            if (choice == "1")
            {
                animal = new Pig();
            }
            else if (choice == "2")
            {
                animal = new Dog();
            }
            else if (choice == "3")
            {
                animal = new Bird();
                animal 
            }
             else if (choice == "4")
            {
                animal = new Cat();
            }

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
