namespace assignment2
{
    internal class Program
    {
        const int numOfElements = 20;
        const int lowest = 1;
        const int highest = 101;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[] numbers = new int[numOfElements];
            FillArray(numbers);
            DisplayArray(numbers);
            Console.WriteLine();

            int smallest = GetSmallestNumber(numbers);
            Console.WriteLine($"Smallest number is: {smallest}");
        }

        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = random.Next(lowest, highest + 1);
                numbers[i] = number;
            }
        }
        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]} ");
            }
        }
        int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }
    }
}
