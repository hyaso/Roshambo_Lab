ROSHAMBO: ROCK PAPER SCISSORS;
Objectives: Enumerations, Abstract Classes;

Task: Create a rock, paper, scissors game.

What will the application do?
The application prompts the player to enter a name and select an opponent.
The application prompts the player to select rock, paper, or scissors. Then, the application displays the player’s choice, the opponent’s choice, and the result of the match.
The application continues until the user doesn’t want to play anymore.
If the user makes an invalid selection, the application should display an appropriate error message and prompt the user again until the user makes a valid selection.

Build Specifications:
Create an enumeration called Roshambo that has three values: rock, paper, and scissors.
Create an abstract class named Player that stores a name and a Roshambo value. This class should include a method named GenerateRoshambo that allows an inheriting class to generate and return a Roshambo value.
Create and name three player subclasses:
RockPlayer - Always throws Rock 
RandomPlayer - Picks and throws a value at random 
HumanPlayer - Allows the user to select and throw a value. Upon creating an instance of this class, allow the user to input their name.
Create a main where you create a HumanPlayer and then allow them to choose their opponent: either RockPlayer or RandomPlayer.
Validate your user inputs throughout your app. Try catch blocks, if statements, or any other method of validation is good.
