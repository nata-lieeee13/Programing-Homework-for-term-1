using System;
namespace Assignment7
{
	public class student
	{
		//fields for stdents names and int arrray for grades
		public string Name { get; private set; }
		private int[] Grades { get; set; }

		//constructors
		public student(string name, int[] grades)
		{
			Name = name;
			Grades = grades;
		}

		//Method to calculate average of the grades
		public double CalcualeAverage()
		{
			int total = 0;
			foreach (int grade in Grades)
			{
				total += grade;
			}

			return (double)total / Grades.Length;
		}

		//Methods to display all the grades
		public void DisplayGrades()
		{
			Console.WriteLine($"\nGrades for{Name}:");
			foreach (int grade in Grades)
			{
				Console.WriteLine(grade);
			}
		}
	}
}

