using ConsoleUtils.Utils;

namespace ConsoleUtils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Lottery lottery = new Lottery();
            var draws = lottery.GetMeDrawNumbers(5, 0, 9, false);
            Console.WriteLine("Draw Numbers (0-9): {0}", string.Join(", ", draws));

        }
    }
}
