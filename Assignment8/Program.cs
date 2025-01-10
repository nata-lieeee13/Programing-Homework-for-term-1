using System;
namespace Assignment8;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Get the user to put in the library capacity
        Console.Write("How many books should there be in the library: ");
        int capacity;
        while (!int.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
        {
            Console.WriteLine("Invalid,enter a number higher than 0");
        }

        //Initialize the library
        Library library = new Library(capacity);

        //Add books to the library
        Console.WriteLine($"Add the books to the library: ");

        for (int i = 0; i < capacity; i++)
        {
            Console.Write($"Enter title for book {i + 1}: ");
            string title = Console.ReadLine();

            Console.Write($"Enter author for book {i + 1}: ");
            string author = Console.ReadLine();

            Book book = new Book(title, author);
            library.AddBook(book);

           
        }

        library.DisplayBooks();
        Console.ReadKey();
    }

}