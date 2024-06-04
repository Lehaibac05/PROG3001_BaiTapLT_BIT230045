namespace BaitapLT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess;

            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

            while (true)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number correctly.");
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Your guess is too low. Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try a lower number.");
                }
            }
        }
    }
}
