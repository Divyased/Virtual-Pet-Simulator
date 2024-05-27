using System;
namespace Virtualpet
{
    class Program

    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Virtual Pet Simulator!");
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("Cat");
            Console.WriteLine("Dog");
            Console.WriteLine("Rabbit");

            string petType = Console.ReadLine();

            Console.WriteLine("You have choosen a" + " " + petType + "." + " " + "What would you like to name your pet?");

            string petName = Console.ReadLine();

            Console.WriteLine("Welcome," + " " + petName + "!");
            int hunger = 5;
            int happiness = 5;
            int health = 5;

            bool exit = false;

            while(!exit)
            {
                Console.WriteLine("\n Main menu:");
                Console.WriteLine("1. Feed" + " " + petName);
                Console.WriteLine("2. Play with" + " " + petName);
                Console.WriteLine("3. Let" + " " + petName + " " + "rest");
                Console.WriteLine("4. Check" + " " + petName + "'s" + " " + "status");
                Console.WriteLine("5. Exit");
                string choice= Console.ReadLine();
            }
           
        }
    


            
    }
}

