namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {

        //Create an array that holds 3 integers
        int[] numbers = new int[3];

        //Ask the user for there input
        Console.WriteLine("Enter 3 integers: ");

        Program program = new Program();
        program.FillArray(numbers);

        int sum= CalculateSum(numbers);

        double average= CalculateAverage(numbers);

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.ReadKey();

    }

    // Fills array with number entered by user 
    void FillArray(int[] numbers)
    {
        for(int i  = 0; i < numbers.Length; i++)
        {
           numbers[i] = int.Parse(Console.ReadLine());
        }
    }

    //Calculate the sum 
    static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    //Avergae of the elements
    static double CalculateAverage(int[] numbers)
    {
        int sum = CalculateSum(numbers);
        return (double)sum / numbers.Length;
    }
} 

