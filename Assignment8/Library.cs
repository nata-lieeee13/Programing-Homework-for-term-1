using System;
namespace Assignment8
{
	public class Library
	{
		//Fields
		private Book[] books;
		private int currentBookIndex;

		//Constructors to initialize library
		public Library (int capacity)
		{
			books = new Book[capacity];
			currentBookIndex = 0;
		}

		//Methods to add the book to the library
		public void AddBook(Book book)
		{
			if (currentBookIndex < books.Length)
			{
				books[currentBookIndex] = book;
				currentBookIndex++;
			}
			else
			{
				Console.WriteLine("The library is full");
			}
		}

		//Method to display all the books in the library
		public void DisplayBooks()
		{
			Console.WriteLine("Books in Library: ");
			if(currentBookIndex == 0)
			{
				Console.WriteLine("The library is empty");
				return;
			}

			foreach (var book in books)
			{
				if (book != null)
				{
					book.DisplayInfo();
				}
			}
		}
	}
}

