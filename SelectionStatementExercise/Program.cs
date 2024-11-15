namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int favNumber = x.Next(1, 11);
            int userInput = 0;


            while (userInput != favNumber)
            {

                Console.WriteLine("Guess my favorite number?");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                }
            }

        }
    }
}
