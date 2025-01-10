namespace Assignment4;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Get the user to input the course name and number of students

        Console.WriteLine("Enter coure name: ");
        string courseName = Console.ReadLine();

        Console.WriteLine("Enter the number of students: ");
        int studentAmount = int.Parse(Console.ReadLine());

        //Create arrays for storing grades and names
        string[] names = new string[studentAmount];
        int[] grades = new int[studentAmount];

        //Read the names and grades of users
        ReadNames(names);
        ReadGrades(grades);

        //Find the highest grade
        int highestGradeIndex = GetHighestGradeIndex(grades);

        //Display the name and grade of the student with the highest grade
        Console.WriteLine($"Student {names[highestGradeIndex]} has the highest grade: {grades[highestGradeIndex]}");

        Console.ReadKey();
    }

    //Get the user to enter the name for each student 
    void ReadNames(string[] names)
    {
        for(int i=0; i < names.Length; i++)
        {
            Console.WriteLine($"Enter the name of student {i + 1}: ");
            names[i] = Console.ReadLine();
        }
    }

    //Get the user to enter the grades of each student 
    void ReadGrades(int[] grades)
    {
        for (int i=0; i < grades.Length; i++)
        {
            Console.WriteLine($"Enter the grade for {i +1}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
    }

    //Find the highest grade out of all the students
    int GetHighestGradeIndex(int[] grades)
    {
        int highestIndex = 0;

        for(int i=1; i < grades.Length; i++)
        {
            if (grades[i] > grades[highestIndex])
            {
                highestIndex = i;
            }
        }

        return highestIndex;
    }
}

