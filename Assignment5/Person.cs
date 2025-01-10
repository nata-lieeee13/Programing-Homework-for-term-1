using System;
namespace Assignment5
{
	public class Person
	{
		//Fields
		public string Name { get; set; }
		public int Age { get; set; }

		//Intialize 
		public Person(string name, int age )
		{
			Name = name;
			Age = age; 
		}

        //Display person information

		public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name} , Age: {Age}");
        }
    }
}

