# PROJETO LP1

Pedro Silva 22001798
Nuno Matias 22104821

Pedro Silva
- Criou o repositório
- Criou as variáveis 
- Fez o código dos métodos
    - Main
    - PlayGame
    - PrintCurrentGame

Nuno Matias
- Fez o código dos métodos
     - ChooseLamp
     - ChooseOption

- Organizou o código
- Comentou o código
- Escreveu o relatório


- Our project solution called ( Projeto LP1 ), contains our Program called ( Program )

Inside the coding of our program we start by declaring the class and initializing 3 variables

    - a bool in False for every lamp so they start turned off
    - a int = 6 to represent the maximum amount of available plays
    - a int that stores how many plays we have left
   
These are initialized outside of any method so they are stored on the Heap
and their reference can be called by any method of the program

-------------------------------------------------------------------------------------------------------------------------------------------------
After that we have our first method ( Main ) 
This method starts as soon as the program is ran
It starts by printing some welcoming messages to the user as well as 3 available options and the game instructions

    - Option 1 Starts the Game
    - Option 2 Reprints the main menu with the game instructions
    - Option 3 Quits the game

The user input on the console is than red by the program and stores it inside a string variable called ( option )

After that we have a sequence of conditions where the code executes the action related to the user input

We start with an "if" for our !ChooseOption method that will be explained more in dept later on
For now it´s only important to now that this method checks if the input of the user is valid or not
which means that only 1, 2 or 3 are the valid inputs

If the user input is not valid, the code won´t do anything and will continue to ask for a valid one
We than have a "else" were the program goes to in case the input is valid

If the user input is 1, the program prints "The game is starting. Good luck!" message into the console
2 other methods also take place here the PrintCurrentGame and PlayGame ones

These will also be explained in more dept later on but for now it´s important to know that the 
PrintCurrentGame method prints onto the console the current state of the game ( map ) so the user
has a visual representation of it

The PlayGame method is the one rsponsable for controling the buttons of the lamps as well has checking
if the player has meet the conditions for winning or losing

If the user choose option 2 on his input, than the program will once again print the main menu options
fromt he very start of the program as well as the instructions for the game

If the user input == 3 than a "Goodbye!" message will be printed onto the console and the program will return 0 ending it

-------------------------------------------------------------------------------------------------------------------------------------------------
Next we have our more in dept explanation of the PlayGame method
This method runs while the number of moves available to the player ( numPlays variable ) is > 6

The program than prints "Type,first,second or third to press the respective button" to inform the player
on how to input each button
An input is than asked by the program reading and storing it inside a string variable named ( button )

We than call for our ChooseLamp method that checks if the input is valid or not, more details on how
it´s done later on
If the user input is not valid than the code will continue to ask for a valid one

Otherwise our PlayGame method will continue and check which button was inputted

If the first button was the players choise, the firstLamp will switch it´s bool state
If the firstLamp was on ( True ) it will turn off ( False ) and vice-versa

If the second buton was the players choise, the firstLamp and secondLamp will switch their  bool state
If the firstLamp was on ( True ) it will turn off ( False ) and vice-versa
The same will happen to the secondLamp

If the third button was the players choise, the secondLamp and the thirdlamp will switch their bool state
If the secondlamp was on ( True ) it will turn off ( False ) and vice-versa
The same will happen to the thirdLamp

Each time we exit this "else" and go back to the start of our "while" loop we subtract 1 ( -- ) from our numPlays variable
This is to take out 1 play everytime an input for a button is done by the player in order to have the variable eventually reach
0 where the "while" loop would no longer occour and the game would be over with the player losing

Than we once again call for our PrintCurrentGame method to print the current state of the game onto the console for the player to see

The PlayGame method than finishes with a win and lose condition for the player

Win condition:
If firstLamp, secondLamp and thirdLamp are all on ( == true ) than the player wins the game and a message is printed onto th console
informing the player that we won and how many moves ( numPlays ) he had left before losing

Lose consdition:
If numPlays == 0 than the player has no more available moves and loses the game
A message is than printed onto the console informing him of such

-------------------------------------------------------------------------------------------------------------------------------------------------
We than have our PrintCurrentGame method code and explanation

We have a Console.WriteLine function in the begining and end of the method with "-------------------------"
in order to have a seperation of the printed map from the rest of the terminal text to help him visualize
the map better

The first part of map constains a print onto the console "First Lamp - Second Lamp - Third Lamp" so the user
can see the different lamps representation
The rest of the method contains conditions for the lamps that control what the representation of their state looks like

If the firstLamp is on ( True ) the console will print "     *O*     " below the firstLamp
If the firstLamp is off ( False ) the console will print "      O      " below the firstlamp

If the secondLamp is on ( True ) the console will print "     *O*     " below the secondLamp
If the secondLamp is off ( False ) the console will print "      O      " below the secondlamp

If the thirdLamp is on ( True ) the console will print "     *O*     " below the thirdLamp
If the thirdLamp is off ( False ) the console will print "      O      " below the thirdlamp

--------------------------------------------------------------------------------------------------------------------------------------------------
Our ChooseOption method is next
Quick reminder, this method checks the input of the user when it´s called in the the main menu during the Main method

First condition:
If the string input is Null (0) or Empty, the program prints
"Invalid option. Please choose between 1, 2 or 3." onto the console to inform the user of his invalid input ( return False )

Second condition:
If the input is different than 1, 2 or 3 and is also not Null or Empty, than the program prints
"Invalid option. Please choose between 1, 2 or 3." onto the console to inform the user of his invalid input ( return False )

Third condition:
If the input is valid, meaning it was 1, 2 or 3, the program will return True and the Main method will execute the function 
related to whatever input was done

---------------------------------------------------------------------------------------------------------------------------------------------------
The last method of our code is the ChooseLamp method
Quick reminder, this method checks the input of the user when it´s called in the PlayGame method

First condition:
If the string input is Null (0) or Empty, the program prints
"Invalid option. Choose between first, second or third." onto the console to inform the user of his invalid input ( return False )

Second condition:
If the input is different than first, second or third and is also not Null or Empty, than the program prints
"Invalid option. Choose between first, second or third." onto the console to inform the user of his invalid input ( return False )

Third condition:
If the input is valid, meaning it was first, second or third, the program will return True and the PlayGame method will execute the function 
related to whatever input was done

-----------------------------------------------------------------------------------------------------------------------------------------------------
