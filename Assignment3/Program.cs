namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Create an array 
        int[] numbers = new int[3];

        //Prompt the user to enter the 3 integers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter integer {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input.");
                Console.Write($"Enter integer {i + 1}: ");
            }
        }

        //Display the sum and average
        int sum = CalculateSum(numbers);
        double average = CalculateAverage(numbers);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");

        Console.ReadKey();
    }

    int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return (double)CalculateSum(numbers) / numbers.Length;
    }
}

