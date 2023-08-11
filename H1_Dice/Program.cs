namespace H1_Dice
{
    internal class Program
    {
        static void Main()
        {
            // Creates a Random variable and assigns the name "random"
            Random random = new Random();

            // Creates an infinite loop
            while (true)
            {
                // Creates a new variable called "dice" and assigns a random value, which is between 1 and 6
                int dice = random.Next(1, 7);

                // Changes the text color to any of the colors available, as well writing "Du slog {dice}" in the console.
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.Write($"Du slog {dice}");

                // Uses a ReadLine, to avoid spam in the console, as well as clearing the console.
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}