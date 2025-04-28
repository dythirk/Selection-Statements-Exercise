using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 10);

            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < r)
            {
                Console.WriteLine($"Too low!\nYou guessed: {userInput}");
            }
            else if (userInput > r)
            {
                Console.WriteLine($"Too high!\nYou guessed: {userInput}");
            }
            else
                Console.WriteLine("Exactly!");
            
        }
    }
}
