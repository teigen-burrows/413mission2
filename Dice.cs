public class Dice
{
    public int Roll()
    {
        // generate random rolls and store total of rolls
        Random random = new Random();
        int rollOne = random.Next(1, 7);
        int rollTwo = random.Next(1, 7);
        int rollTotal = rollOne + rollTwo;
        return rollTotal;
    }
}
