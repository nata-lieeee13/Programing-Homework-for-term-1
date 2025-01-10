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
        //create an array that holds 20 integer elements 

        int[] numbers = new int[20];

        FillArray(numbers);

        DisplayArray(numbers);

        int smallestNumber = GetSmallestNumber(numbers);

        Console.WriteLine($"Smallest number is: {smallestNumber}");

        Console.ReadKey();

    }

    // Create a method that fills the array with random numbers
    void FillArray(int[] numbers)
    {
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

    }

    //Display the array with random numbers
    void DisplayArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]}");
        }
    }

    //Return the smallest number in array
    int GetSmallestNumber(int[] numbers)
    {
        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++ )
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        return smallest; 
    }

}


