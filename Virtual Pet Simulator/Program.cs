using System;
namespace VirtualPet
{
    class Program

    {
        static void Main(string[] args)
        {
            int hunger = 5;
            int happiness = 5;
            int health = 5;
            string petType = "";
            string petName = "";

            Console.WriteLine("Welcome to Virtual Pet Simulator!");
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    petType = "Cat";
                    break;
                    case "2":
                    petType = "Dog";
                    break;
                    case "3":
                    petType = "Rabbit";
                    break;
                    default:
                    Console.WriteLine("Invalid Option.");
                    return;
            }

            Console.WriteLine("You have choosen a" + " " + petType + "." + " " + "What would you like to name your pet?");

             petName = Console.ReadLine();

            Console.WriteLine("Welcome," + " " + petName + "!");

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
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You fed" + " " + petName + ".");

                }
            }
           
        }
    


            
    }
}

