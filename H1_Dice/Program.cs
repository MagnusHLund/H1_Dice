namespace H1_Dice
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();

            while (true)
            {
                int dice = random.Next(1, 7);
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.Write("Du slog ");
                switch (dice)
                {
                    case 1:
                        Console.Write(dice);
                        break;
                    case 2:
                        Console.Write(dice);
                        break;
                    case 3:
                        Console.Write(dice);
                        break;
                    case 4:
                        Console.Write(dice);
                        break;
                    case 5:
                        Console.Write(dice);
                        break;
                    default:
                        Console.Write(dice);
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}