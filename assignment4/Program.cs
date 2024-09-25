namespace assignment4
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
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            int[] grade = new int[numberOfStudents];
            string[] students = new string[numberOfStudents];

            ReadNames(students);
            ReadGrades(grade);
            int highestgradeIndex = GetHighestGradeIndex(grade);

            Console.WriteLine($"Student {students[highestgradeIndex]} has the highest grade: {grade[highestgradeIndex]}.");

        }
        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter the name of the Student {i + 1 } ");
                names[i] = Console.ReadLine();
            }
        }
        void ReadGrades(int[] grades)
        {
            for (int i = 0;i < grades.Length; i++)
            {
                Console.WriteLine($"Enter the grades of the Students:  {i + 1 }");
                grades[i] = int.Parse(Console.ReadLine());
            }
           
        }
        int GetHighestGradeIndex(int[] grades)
        {
            int highIndex = 0;
            for (int i = 1; i < grades.Length; i++)  
            {
                if (grades[i] > grades[highIndex])  
                {
                    highIndex = i;  
                }
            }
            return highIndex;
        }

    }
}
