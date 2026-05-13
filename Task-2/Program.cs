using System;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 50);
            int inputNumber = 0;
            int counter = 0;
            bool loopTerminator = false;

            Console.WriteLine("\n****** Number Guessing Game ******\n");
            Console.WriteLine("Rules:\n" +
                "If the input number is 10 numbers higher than the secret number, the program flags \"Too high!\"\n" +
                "If the input number is 10 numbers lower than the secret number, the program flags \"Too low!\"\n");

            Console.WriteLine("Guess the secret number.");
            Console.WriteLine("Hint: The number is between 0 and 50.");

            while (!loopTerminator)
            {
                inputNumber = GetInput();

                counter++;

                if (inputNumber == secretNumber)
                    loopTerminator = true;
                if (inputNumber > secretNumber + 10)
                    Console.WriteLine("Too high! Try again.");
                else if (inputNumber < secretNumber - 10)
                    Console.WriteLine("Too low! Try again.");

            }

            Console.WriteLine("\nCongratulations! You found the secret number!");

            Console.WriteLine($"The secret number was: {secretNumber}");

            Console.WriteLine($"You guessed the number in {counter} attempts.");
        }

        static int GetInput()
        {
            int inputNumber;

            Console.Write("\nPlease enter a number: ");

            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Write("Invalid input! Try again.\n\nPlease enter a number: ");
            }

            return inputNumber;
        }

    }

}

/*

    Research Question:
    In your last task, you looked at int.Parse(). 
    Now, explain: What is the out keyword used for in int.TryParse(input, out result)? 
    (Why can't we just say int result = int.TryParse(input);?)

    The out keyword is used to return an extra value from a method.

    In int.TryParse(input, out result):

    TryParse() returns true or false
    out result stores the converted integer value

    Example:
    bool success = int.TryParse("25", out int result);
    success → true
    result → 25

    We cannot write:
    int result = int.TryParse(input);

    because TryParse() returns a bool, not an int. The integer value is returned using the out parameter.
 
*/
