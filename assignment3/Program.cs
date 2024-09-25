using System.Diagnostics.Tracing;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[] numbers = new int[3];
            FillArray(numbers);
            int sum = CalculateSum(numbers);
            double avg = CalculateAVG(numbers);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");

        }
        void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i ++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        double CalculateAVG(int[] numbers) 
        {
            int sum = CalculateSum(numbers);
            double average = (double)sum / numbers.Length;  
            return average;
        }
    }
}
