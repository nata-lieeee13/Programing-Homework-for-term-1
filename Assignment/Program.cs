namespace Assignment1;

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
            Console.WriteLine($"Element {i + 1} is: {numbers[i]}");
        }
    }

}



