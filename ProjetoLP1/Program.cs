using System;

    class Program
    {
        // Initializing the variables that are going to be used in the program

        /* here we have a bool data type for each one of the tree lamps
        if the lamp is false than it´s turned off and if it´s true it´s on
        all lamps start turned off (false)*/
        static bool firstLamp = false, secondLamp = false, thirdLamp = false;

        /* This variable represents the maximum amount of moves
        the player is allowed to make during 1 game*/
        static int maxPlays = 6;

        /* This variable stores the current number of plays the player has
        left */
        static int numPlays = maxPlays;

        // This is our main method that will start as soon as the program is run
        static void Main(string[] args)
        {
            /* Here we are printing 2 strings to welcome the player to the game
            These will also appear as soon as the program is run*/
            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to the lamps game.");

            /* Here we have a while lop that stays true as soon as the program
            starts. It´s used to navigate throughout the main menu*/
            while(true)
            {
                /* These are also printed as soon as the program starts and
                they present the main menu options and how to use each one*/
                Console.WriteLine("Available options:");

                /* Writes a string that informs the player that he must click 1
                If he intends to start playing the game*/
                Console.WriteLine("1 - Start Game");

                /* Writes a string that informs the player that he must click 2
                If he desires for the main menu instructions for appear again*/
                Console.WriteLine("2 - Instructions");

                // Separation to make intructions easier to read
                Console.WriteLine("------------------------------------------");

                // Writes the instructions to play the game
                Console.WriteLine("In this game there are 3 lamps initially turned off");
                Console.WriteLine("There are also 3 buttons, first, second and third");
                Console.WriteLine("First button turns on/off the first lamp");
                Console.WriteLine("Second button turns on/off the first and second lamps");
                Console.WriteLine("Third button turns on/off the second and third lamps");
                Console.WriteLine("Win the game by turning all lamps on");
                Console.WriteLine("You have a total of 6 button presses");

                // Separation to make intructions easier to read
                Console.WriteLine("------------------------------------------");

                /* Writes a string that informs the player that he must click 3
                if he desires to quit the game and exit the program*/
                Console.WriteLine("3 - Quit");

                /* Writes a string that tells the player to choose his option
                and also a space after : for the option to be placed in*/
                Console.Write("Choose your option: ");

                // Reads the input of the user
                string option = Console.ReadLine();

                /* Here we have our method that makes sure that the player entered
                a valid option*/
                if(!ChooseOption(option))
                {
                    /* If the option is not valid than we continue to look
                    for a valid one*/
                    continue;
                }
                // This is where the program will go in case the option is valid
                else
                {
                    // Here we have what happens if the player enters option 1
                    if(option == "1")
                    {
                        // The warning message below will be printed onto the console
                        Console.WriteLine("The game is starting. Good luck!");

                        /* Here we have our method that controls the presentation
                        of the current game state onto the console*/
                        PrintCurrentGame();

                        /* Here we have our method that controls when the game
                        is being played*/
                        PlayGame();
                        break;                        
                    }
                    // Here we have what happens if the player enters option 2
                    else if(option == "2")
                    {
                        /* The instructions from the main menu will be printed
                        on the console*/
                        Console.WriteLine("Instructions");
                    }
                    // Here we have what happens if the player enter option 3
                    else if(option == "3")
                    {
                        // The message below will be printed onto the console
                        Console.WriteLine("Goodbye!");
                        // This return function exits the program
                        return;                        
                    }
                }
            }
        }

        // Our PlayGame method that controls the game
        static void PlayGame()
        {
            /* Here we have a while lop that states that, while the number of
            moves available to the player is bigger than 0, the code below
            will be active
            Quick reminder that the player starts the game with 6 moves*/
            while(numPlays > 0)
            {
                // Here we ask the player which button he wants to press
                Console.WriteLine("Type,first,second or third to press the respective button");

                // Reads player´s input
                string button = Console.ReadLine();

                // Our ChooseLamp method that controls the buttons
                if(!ChooseLamp(button))
                {
                    // If not the program will continue and ask for another input
                    continue;
                }
                // This runs if the input was a valid button
                else
                {
                    // This runs if user inputs the first button
                    if(button.ToLower() == "first")
                    {
                        /* The first lamp will turn on if it was turned off
                        or will turn off if it was turned one*/
                        firstLamp = !firstLamp;
                    }
                    // This runs if user inputs the second button
                    else if(button.ToLower() == "second")
                    {
                        /* The first lamp will turn on if it was turned off
                        or it will turn off if it was turned on
                        The second lamp will turn of if it was turned off
                        or will turn off if it was turned on*/
                        firstLamp = !firstLamp;
                        secondLamp = !secondLamp;
                    }
                    // This runs if user inputs the third button
                    else if(button.ToLower() == "third")
                    {
                        /* The second lamp will turn on if it was turned off
                        or it will turn off if it was turned on
                        The third lamp will turn on if it was turned off
                        or it will turn off if it was turned on*/ 
                        secondLamp = !secondLamp;
                        thirdLamp = !thirdLamp;
                    }
                    // Every time a button is used numPlays goes down by 1
                    numPlays--;

                    /* This function prints the current map of the game
                    with the different lamps as well as which one are turned
                    on or off*/ 
                    PrintCurrentGame();                    
                }
                /* Here we have the game win condition where if all 3 lamps
                are turned on (True), the player wins the game*/
                if(firstLamp == true && secondLamp == true && thirdLamp == true)
                {
                    /* Write a message telling the player he won as well as 
                    how many moves he still had left before he lost*/
                    Console.WriteLine("You Won with " + numPlays + " moves left!");
                    break;
                }
            }
            // This runs if the player has used all his 6 moves and has not won yet
            if(numPlays == 0)
            {
                // Writes a message telling the player that he lost
                Console.WriteLine("You lost the game.");
            }
        }

        /* Method that controls the printing of the current game state onto the
        console*/
        static void PrintCurrentGame()
        {
            // Writes a division to make it easier to separate
            Console.WriteLine("------------------------------------------");
            // Writes the 3 different lamps and their position
            Console.WriteLine("First Lamp - Second Lamp - Third Lamp");

            // Condition if first lamp is on
            if(firstLamp)
            {
                // Prints *0* to inform that first lamp is on (True)
                Console.Write("     *O*     ");
            }
            // Condition if first lamp is off
            else
            {
                // Prints 0 to inform that first lamp is off (False)
                Console.Write("      O      ");
            }
            // Condition if second lamp is on
            if(secondLamp)
            {
                // Prints *0* to inform that second lamp is on(True)
                Console.Write("     *O*     ");
            }
            // Condition if second lamp is off
            else
            {
                // Prints 0 to inform that second lamp is off(False)
                Console.Write("      O      ");
            }
            // Condition if third lamp is on
            if(thirdLamp)
            {
                // Prints *0* to inform that third lamp is on (True)
                Console.Write("     *O*     ");
            }
            // Condition if third lamp is off
            else
            {
                // Prints 0 to inform that third lamp if off(False)
                Console.Write("      O      ");
            }
            // Prints to create a separation and help better visualize the map
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
        }

        // Method that controls the options available on the main menu
        static bool ChooseOption (string newOption)
        {
            // Condition if the input is null or empty
            if(string.IsNullOrEmpty(newOption))
            {
                // Prints the message telling the user to choose between 1, 2 or 3
                Console.WriteLine("Invalid option. Please choose between 1, 2 or 3.");

                // Return function is false since the input was invalid
                return false;
            }
            // Condition if user input is != than 1, 2 or 3 and is not null or empty
            else if(newOption != "1" && newOption != "2" && newOption != "3")
            {
                // Prints the message telling the user to choose between 1,2 or 3
                Console.WriteLine("Invalid option. Please choose between 1, 2 or 3.");

                // Return function is false since the input was invalid
                return false;
            }
            // Condition if the input is valid, between 1, 2 or 3
            else
            {
                // Returns a valid option and executes the respective action
                return true;
            }
        }

        // Method that controls the buttons
        static bool ChooseLamp (string newLamp)
        {
            // Condition if input is null or empty
            if(string.IsNullOrEmpty(newLamp))
            {
                /* Prints the message telling the player his input is not valid
                and to choose between first, second or third*/
                Console.WriteLine("Invalid option. Choose between first, second or third.");

                // Return function is false since input is invalid
                return false;
            }
            /* Condition if input is different than first, second or third but
            is also not null or empty*/
            else if(newLamp != "first" && newLamp != "second" && newLamp != "third")
            {
                /* Prints the message telling the player his input is not valid
                and to choose between first, second or third*/
                Console.WriteLine("Invalid option. Choose between first, second or third.");
                
                // Return function is false since input is invalid
                return false;
            }
            // Condition if input is valid, between first, second or third
            else
            {
                // Returns a valid option and executes the respective action
                return true;
            }
        }
    }