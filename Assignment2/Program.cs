namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Get the user to choose a day of week
        Console.Write("Enter a day of the week (e.g., Monday): ");
        string input = Console.ReadLine();

        try
        {
            //Convert it to enum day 
            Day day = (Day)Enum.Parse(typeof(Day), input, true);

            //Use switch to print message
            switch (day)
            {
                case Day.Monday: 
                    Console.WriteLine("It's the start of the week :( ");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("Weekend is loading..");
                    break;
                case Day.Wednesday:
                    Console.WriteLine(" You're halfway through.");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Almost there.");
                    break;
                case Day.Friday:
                    Console.WriteLine("The weekend is near.");
                    break;
                case Day.Saturday:
                    Console.WriteLine("Weekend is here ");
                    break;
                case Day.Sunday:
                    Console.WriteLine("Prepare for the week ahead.");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input. ");
        }

        Console.ReadKey();
    }
}

