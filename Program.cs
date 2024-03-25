namespace constructors
{
    class Program
    {

        static void Main(string[] args)
        {
            //Object
            Car Ford = new Car("Mustang", "Black", "1969");

            Console.WriteLine(Ford.model + " " + Ford.color + " " + Ford.yearOfProfuction);
            Ford.Honk();
        }
    }
    class Car : Vehicle
    {
        public string model;
        public string color;
        public string yearOfProfuction;

        //Constructor 
        public Car(string modelName, string modelColor, string modelYearOfProduction)
        {
            model = modelName;
            color = modelColor;
            yearOfProfuction = modelYearOfProduction;

        }
    }

    class Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Tuu tuuu");
        }
    }

    
 

    
}
