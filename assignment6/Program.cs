using System;

namespace assignment6
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
            int[] faces = new int [6];
            ThrowDice(faces, 6000);
            for (int i = 0; i < faces.Length; i++)
            {
                Console.WriteLine($"Number of throws of value {i + 1} = {faces[i]}");
            }

        }
        void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberOfThrows; i++)
            {
                int diceValue = rnd.Next(1, 7);
                diceCounts [diceValue - 1]++;
            }
            
        }

    }
}
