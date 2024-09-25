namespace assignment7
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
            bool[] seats = new bool[10];
            InitializeSeats(seats);
            
            Console.WriteLine("Initial seating arrengement: ");
            DisplaySeatingArrangement(seats);

           Console.WriteLine("Enter a seat number to book: (1-10)");
            int seatNym = int.Parse(Console.ReadLine());

            BookSeat(seats, seatNym);
            Console.WriteLine("Current seating arrengement: ");
            DisplaySeatingArrangement(seats);
        }
        void InitializeSeats(bool[] seats)
        {
            Random rnd = new Random(); //methodo hace que se llene la array con disponibilidad random. 
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = rnd.Next(2) == 0;
            }
        }
        void DisplaySeatingArrangement(bool[] seats)
        {
            for (int i = 0;i < seats.Length;i++)
            {
                string status; 
                if (seats[i])
                {
                    status = "Available";
                }
                else
                {
                    status = "Occupied";
                }
                Console.WriteLine($"Seat {i + 1}: {status}");
            }
           
        }
        void BookSeat(bool[] seats, int seatNumber)
        {
            int index = seatNumber -1;

            if (index < 0 || index >= seats.Length)
            {
                Console.WriteLine("Invalid seat number. ");
                return;
            }
            
            if (seats[index])
            {
                seats[index] = false;
                Console.WriteLine($"Seat {seatNumber} has been succesfully booked. ");
            }
            else
            {
                Console.WriteLine($"Seat {seatNumber} is already occupied. ");
            }
        }
    }
}
