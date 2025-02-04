namespace ConsoleUtils.Utils
{
    public class Lottery
    {
        private static Random random = new Random();

        // Method for generating draw numbers based on uniqueness flag
        public List<int> GetMeDrawNumbers(int count, int rangeStart, int rangeEnd, bool isUnique)
        {
            List<int> numbers = new List<int>();

            if (isUnique)
            {
                // Generate unique numbers using a HashSet to ensure no duplicates
                HashSet<int> uniqueNumbers = new HashSet<int>();

                while (uniqueNumbers.Count < count)
                {
                    int number = random.Next(rangeStart, rangeEnd + 1);
                    uniqueNumbers.Add(number);
                }

                numbers.AddRange(uniqueNumbers);  // Convert HashSet to List
            }
            else
            {
                // Generate numbers with duplicates allowed
                for (int i = 0; i < count; i++)
                {
                    int number = random.Next(rangeStart, rangeEnd + 1);
                    numbers.Add(number);
                }
            }

            return numbers;
        }
    }
}
