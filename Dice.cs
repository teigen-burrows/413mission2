using static System.Runtime.InteropServices.JavaScript.JSType;

public class Dice
{
    public int[] Roll(int number)
    {
        // generate random rolls and store total of rolls
        Random random = new Random();

        // create an array to store roll totals (my friend Burke wanted to be honored here)
        int[] Burke = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // for loop to load array using the Dice class/method
        for (int i = 0; i < number; i++)
        {
            int rollOne = random.Next(1, 7);
            int rollTwo = random.Next(1, 7);
            int rollTotal = rollOne + rollTwo;
            Burke[rollTotal - 2]++;
        }
        return Burke;
    }
}
