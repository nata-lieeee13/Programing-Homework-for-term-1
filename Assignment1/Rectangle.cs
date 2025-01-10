using System;
namespace Assignment1
{
	public class Rectangle
	{
		//Two fields
		public double Width { get; set; }
		public double Height { get; set; }

		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}

        //Calcutale the area of the rectangle
        public double CalculateArea()
		{
			return Width * Height;
		}

        //Calculate the perimeter of the rectangle
        public double CalculatePerimeter()
		{
			return 2 * (Width + Height);
		}

    }
}

