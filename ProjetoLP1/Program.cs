using System;

    class Program
    {
        static bool firstLamp = false, secondLamp = false, thirdLamp = false;

        static int maxPlays = 6;
        static int numPlays = maxPlays;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to the lamps game.");

            while(true)
            {
                Console.WriteLine("Available options:");
                Console.WriteLine("1 - Start Game");
                Console.WriteLine("2 - Instructions");
                Console.WriteLine("3 - Quit");

                Console.Write("Choose your option: ");
                string? option = Console.ReadLine();

                if(string.IsNullOrEmpty(option))
                {
                    Console.WriteLine("Invalid option. Please choose between 1, 2 or 3.");
                }
                else if(option == "1")
                {
                    Console.WriteLine("The game is starting. Good luck!");
                    PrintCurrentGame();
                    PlayGame();
                    break;
                }
                else if(option == "2")
                {
                    Console.WriteLine("Instructions");
                }
                else if(option == "3")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose between 1, 2 or 3.");
                }
            }
        }

        static void PlayGame()
        {
            while(numPlays > 0)
            {
                Console.WriteLine("Which button do you want to press?");
                string? button = Console.ReadLine();

                if(string.IsNullOrEmpty(button))
                {
                    Console.WriteLine("Invalid option. Choose between first, second or third.");
                }
                else if(button.ToLower() == "first" || button.ToLower() == "second" || button.ToLower() == "third")
                {
                    if(button.ToLower() == "first")
                    {
                        firstLamp = !firstLamp;
                    }
                    else if(button.ToLower() == "second")
                    {
                        firstLamp = !firstLamp;
                        secondLamp = !secondLamp;
                    }
                    else if(button.ToLower() == "third")
                    {
                        secondLamp = !secondLamp;
                        thirdLamp = !thirdLamp;
                    }
                    numPlays--;
                    PrintCurrentGame();
                }
                else
                {
                    Console.WriteLine("Invalid option. Choose between first, second or third.");
                }
                if(firstLamp == true && secondLamp == true && thirdLamp == true)
                {
                    Console.WriteLine("teste");
                    break;
                }
            }
            if(numPlays == 0)
            {
                Console.WriteLine("You have lost the game.");
            }
        }

        static void PrintCurrentGame()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("First Lamp - Second Lamp - Third Lamp");
            if(firstLamp)
            {
                Console.Write("     *O*     ");
            }
            else
            {
                Console.Write("      O      ");
            }
            if(secondLamp)
            {
                Console.Write("     *O*     ");
            }
            else
            {
                Console.Write("      O      ");
            }
            if(thirdLamp)
            {
                Console.Write("     *O*     ");
            }
            else
            {
                Console.Write("      O      ");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
        }
    }