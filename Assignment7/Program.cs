using System;
namespace Assignment7;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Get the user to put the student's name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        //Get the user to put the number of grades
        Console.Write("Enter amount of grades to process: ");
        int gradeCount;
        while (!int.TryParse(Console.ReadLine(), out gradeCount) || gradeCount <= 0)
            {
            Console.WriteLine("Invalid");
            }

        //Initialize the array
        int[] grades = new int[gradeCount];
        Console.WriteLine($"Enter grade {gradeCount}: ");

        for (int i = 0; i < gradeCount; i++)
        {
            Console.Write($"Grade {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(),out grades[i]) || grades[i] < 0 || grades[i] > 100)
            {
                Console.WriteLine("Invalid");
            }
        }

        //Studen object
        student student = new student(studentName, grades);

        //Display the grades
        student.DisplayGrades();

        //Calculate and then show the average
        double average = student.CalcualeAverage();
        Console.Write($"Average Grade: {average:F2}");

        Console.ReadKey();
    }
}