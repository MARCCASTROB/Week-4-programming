using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        const int ArraySize = 20;
        const int lowest = 1;
        const int highest = 100;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[] numbers = new int [ArraySize];
            fillArray(numbers);
            displayArray(numbers);
        }

        void fillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = random.Next(lowest, highest + 1);
                numbers[i] = number;
            }
        }
        void displayArray(int[] numbers)
        {
            
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine($"Element {i + 1} is: {numbers[i]} ");
            }
        }
    }
}
