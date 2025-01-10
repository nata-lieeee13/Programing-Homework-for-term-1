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
        //create an array
        Person[] persons = new Person[3];

        for (int i = 0; i < persons.Length; i++)
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the age of person {i + 1}: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Invalid input.");
                Console.Write($"Enter the age of person {i + 1}: ");
            }

            persons[i] = new Person(name, age);
        }
            PrintPersonArray(persons);

        Console.ReadKey();
    }

    void PrintPersonArray(Person[] persons)
    {
        Console.WriteLine("\nDisplaying all persons:");
        foreach (Person person in persons)
        {
            person.DisplayPersonInfo();
        }
    }
}

