// Random number generator app

/*
 --- Has a user guess a random number between 1-10 and
lets them know if they got it correct, are too low,
or are too high 
 */

// Welcome Text
Console.WriteLine("Welcome to the random number guessing game! " +
    "\n Here we are going to have you try to guess " +
    "\n what number we have picked!");

//variables
string userGuess;
double userGuessNum;
double answer;

// Generate a random number
Random rnd = new Random();
answer = rnd.Next(1, 10);

// Get user number
Console.WriteLine("Alright! What number do you think it is? " +
    "\n Hint: It is between 1 and 10!");
userGuess = Console.ReadLine();
userGuessNum = Convert.ToDouble(userGuess);

//makes sure num is between 1 and 10
do
{
    Console.WriteLine("Thats not between 1 and 10 retard!");
    userGuess = Console.ReadLine();
    userGuessNum = Convert.ToDouble(userGuess);
} while (userGuessNum <= 0 || userGuessNum >= 11);

// if the number is wrong
do
{
    Console.WriteLine("Okay! Lets check that number!");
    Console.WriteLine("Wrong number sorry! Try again!");
    userGuess = Console.ReadLine();
    userGuessNum = Convert.ToDouble(userGuess);
}
while (userGuessNum != answer);

// if the number is correct
if ( userGuessNum == answer)
{
    Console.WriteLine("Okay! Lets check that number!");
    Console.WriteLine("You are correct! Lucky bastard!");
    Console.WriteLine("Thank you for playing!");
}





