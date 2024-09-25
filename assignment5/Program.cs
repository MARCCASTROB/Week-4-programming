namespace assignment5
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
            int[] numbers = new int[100];

            Console.WriteLine("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            ReadNumbers(numbers);
            int times = CountSearchValue(numbers, searchValue);
            Console.WriteLine($"Number of occurrences of search value ({searchValue}) is: {times}");
            

        }
        void ReadNumbers(int[] numbers)
        {
            int index = 0;  
            while (index < numbers.Length)
            {
                Console.WriteLine("Enter a number, (0 = stop)");
                int nym = int.Parse(Console.ReadLine());

                if (nym == 0)
                {
                    break;
                }   

                numbers[index] = nym;
                index++;
            }
        }
        int CountSearchValue(int[] numbers, int searchValue)
        {
           int count = 0;
            foreach (var nym in numbers)
            {
                if (nym == searchValue) count++;
            }
            return count;
        }
    }
}
