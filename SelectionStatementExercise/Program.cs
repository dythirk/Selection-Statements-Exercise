using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 11);
            int response = 0;


            while (response != favNumber)
            {

                Console.WriteLine("Please choose a number between 1 and 10:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too low!\nYou guessed: {response}.\n");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too high!\nYou guessed: {response}.\n");
                }
                else
                    Console.WriteLine($"Exactly!\nThe number was {favNumber}.");

            }




            
        }
    }
}
