using System;
namespace VirtualPet
{
    class Program

    {
        static void Main(string[] args)
        {
            int hunger = 5;
            int happiness = 5;
            int health = 8;
            string petType = "";
            string petName = "";

            //welcome message
            Console.WriteLine("Welcome to Virtual Pet Simulator!");

            //pet creation
            Console.WriteLine("Please choose your preferred type of pet");
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

            Console.WriteLine("Great!" + " " + "You have created a" + " " + petType + " "+ "named" + " " + petName);

            bool exit = false;

            while(!exit)
            {
                 //main menu options
                Console.WriteLine("\n Main menu:");
                Console.WriteLine("1. Feed" + " " + petName);
                Console.WriteLine("2. Play with" + " " + petName);
                Console.WriteLine("3. Let" + " " + petName + " " + "rest");
                Console.WriteLine("4. Check" + " " + petName + "'s" + " " + "status");
                Console.WriteLine("5. Exit");

                 //user choice
                string choice= Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        hunger -= 2;
                        //if (hunger < 0)hunger = 0;
                        health++;
                        Console.WriteLine("You fed" + " " + petName + "." + " " + "Hunger decreases, and health improves slightly.");
                        break;

                        case "2":
                        happiness += 2;
                        //if(happiness > 10)happiness = 10;
                        hunger++;
                        if (hunger > 10) hunger = 10;
                        Console.WriteLine("You played with" + " " + petName+ "." + "Happiness increases and" + " " + petName + " "+ "is bit hungry.");
                        break;

                        case "3":
                        health += 2;
                        //if (health > 10) health = 10;
                        happiness--;
                        if(happiness < 0)happiness=0;
                        Console.WriteLine("You let" + " " + petName + " " + "rest.");
                        break;

                        case "4":
                        Console.WriteLine(petName + "'s" + " " + "status is");
                        Console.WriteLine("Hunger:" + hunger);
                        Console.WriteLine("Happiness:" + happiness);
                        Console.WriteLine("Health:" + health);
                        break;
                        case "5":
                        exit=true;
                        break;
                        default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            Console.WriteLine("Thank You for playing with"+ " " + petName + "" + "!"); 
           
        }
    


            
    }
}

