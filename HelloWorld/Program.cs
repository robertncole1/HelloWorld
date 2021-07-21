using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, please choose from one of these following greetings: southern, midwestern, northeastern");
            var greetings = Console.ReadLine();
            switch (greetings)
            {
                case "midwestern":
                    Console.WriteLine("Welcome, take a cassarole!");
                    break;
                default:
                case "southern":
                    Console.WriteLine("Howdy, yall!");
                    break;
                case "northeastern":
                    Console.WriteLine("Stay in your lane!");
                    break;
            }
            Console.WriteLine("What's your favorite color?");
            var faveColor = Console.ReadLine();
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
            }
            Random rand = new Random();
            var randomCreature = rand.Next(animals.Length);
            var creature = animals[randomCreature];
            Console.WriteLine($"{name}, would you like a {faveColor} {creature}?");
            // randomCreature
            Console.ReadKey();
        }
    }
}
s