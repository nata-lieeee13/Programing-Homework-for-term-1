namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        void start()
        {
            //Ask the user for the name of the book and the author
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the book author: ");
            string author = Console.ReadLine();

            //Create a book Object
            Book book = new Book(title, author);

            //Display the book details
            Console.WriteLine("Book Details: ");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");

            Console.ReadKey();
        }
    }

    class Book
    {
        //Properties
        public string Title { get; set; }
        public string Author { get; set; }

        //Intialize the properties
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}