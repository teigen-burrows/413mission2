using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {
        // create variables
        string input = "";
        int number = 0;

        // print string and read user input
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate? ");
        input = Console.ReadLine();

        // convert user input string to an integer
        number = Convert.ToInt32(input);

        // print string based on user input
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal number of rolls = " + number + ".\n");

        // create an array to store roll totals (my friend Burke wanted to be honored here)
        int[] Burke = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        // for loop to load array using the Dice class/method
        for (int i = 0; i < number; i++)
        {
            Dice dice = new Dice();
            int roll = dice.Roll();
            Burke[roll - 2]++;
        }

        // nested for loop to determine percents and print asterisks
        for (int i = 0; i < 11; i++)
        {
            double count = (double)Burke[i] / number * 100;
            int roundedCount = (int)Math.Round(count);
            string Asterisk = "";
            for (int j = 0; j < roundedCount; j++)
            {
                Asterisk += "*";
            }
            Console.WriteLine((i+2) + ": " + Asterisk);
        }

        // print final line
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}