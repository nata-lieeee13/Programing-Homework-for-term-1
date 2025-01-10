namespace Assignment5;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Get the array size 
        const int arraySize = 1000;
        int[] numbers = new int[arraySize];

        //Read the number given
        ReadNumbers(numbers);

        //User choose the search value
        Console.Write("Enter a search number: ");
        int searchValue;

        while (!int.TryParse(Console.ReadLine(), out searchValue))
        {
            Console.Write("Invalid input");
        }

        // Count the number of occurrences of the search value
        int count = CountSearchValue(numbers, searchValue);

        // Display the result
        Console.WriteLine($"The number of occurences of a search value {searchValue} is: {count} ");

        Console.ReadKey();
    }


    //Read the numbers and stop at 0
    void ReadNumbers(int[] numbers)
    {
        int index = 0;

        while (index < numbers.Length)
        {
            Console.Write("Enter a number (0=stop): ");
            int input = int.Parse(Console.ReadLine ());

                if ( input == 0)
                {
                    break;
                }

            numbers[index] = input;
            index++;
        }
    }

    //Search for the value to tell the count
    int CountSearchValue(int[] numbers, int searchValue)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchValue)
            {
                count++;
            }
        }

        return count;
    }

}



