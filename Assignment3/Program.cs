namespace Assignment3
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
            //Ask the user for the car details
            Console.Write("Enter the car make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the car year: ");
            int year = int.Parse(Console.ReadLine());

            //Car Object
            Car car = new Car(make, model, year);

            //Display the car information
            Console.WriteLine("Car Details: ");
            Console.WriteLine($"Make: {car.Make} ");
            Console.WriteLine($"Model: {car.Model} ");
            Console.WriteLine($"Year: {car.Year} ");

            Console.ReadKey();
        }
    }

    class Car
    {
        //Private firelds
        private string _make;
        private string _model;
        private int _year;

        //Constructo to intialize the fields
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year; 
        }

        //Public property for make 
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //Public property for model
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //Public property for year
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}