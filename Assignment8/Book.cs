using System;
namespace Assignment8
{
	public class Book
	{
		public string Title { get; private set; }
		public string Author { get; private set; }

		//constructor
		public Book(string title, string author)
		{
			Title = title;
			Author = author;
		}

		//Method to display the details of book
		public void DisplayInfo()
		{
			Console.WriteLine($"{Title} by {Author}");
		}
	}
}

