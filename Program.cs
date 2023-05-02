using System;

class Program
{
    static void Main(string[] args)
    {
        int numStudents;
        do
        {
            Console.Write("Enter number of students: ");
        } while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0);

        string[] studentIDs = new string[numStudents];
        double[] studentScores = new double[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter student ID for student {i + 1}: ");
            string id = Console.ReadLine();
            studentIDs[i] = id;

            double score;
            do
            {
                Console.Write($"Enter score for student {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100);
            studentScores[i] = score;
        }

        char input;
        do
        {
            Console.Write("Exit? (Y/N): ");
            input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (input != 'Y' && input != 'N');

        if (input == 'Y')
        {
            Console.WriteLine("Student Data:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student ID: {studentIDs[i]}, Score: {studentScores[i]}");
            }
        }
        else
        {
            Main(args);
        }
    }
}