// See https://aka.ms/new-console-template for more information
namespace projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(20);
            bool keepGoing = true;

            Console.WriteLine("Guessing Game");
            Console.WriteLine("Number between 1-10");
            Console.WriteLine("Enter your guess or exit to give up");
            int guessNum;
            int continuoso;
            int guesses = 0;
            do
            {
                Console.WriteLine("Whats your guess");
                string guess = Console.ReadLine();
                guessNum = Int32.Parse(guess);

                if (number == guessNum)
                {
                    Console.WriteLine("Nice brotha");
                    Console.WriteLine("Again ");
                    Console.WriteLine("1 yes , 0 no ");
                    string con = Console.ReadLine();
                    continuoso = Int32.Parse(con);
                    if (continuoso == 0)
                    {
                        keepGoing = false;
                    }
                    else if (continuoso == 1) { }
                    else
                    {
                        Console.WriteLine("Couldn't recognize command, try again");
                        con = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine($"Try again, guess number {guesses}");
                    guesses++;
                }
            } while (keepGoing);
        }
    }
}
