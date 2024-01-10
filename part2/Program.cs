using System.Diagnostics;

namespace lab2
{
    public class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle(1,1,1);
            Plane plane = new Plane(2,2,2,2,2);
            Car car = new Car(3, 3, 3);
            Ship ship = new Ship(4, 4, 4, 4, 4);

            Console.WriteLine($"Vehicle");
            vehicle.About();

            Console.WriteLine($"\nPlane");
            plane.About();

            Console.WriteLine($"\nCar");
            car.About();

            Console.WriteLine($"\nShip");
            ship.About();
        }
    }

    public class Ship : Vehicle
    {
        int passegners, port;

        public Ship(int price, int speed, int year, int passegners, int port) : base(price, speed, year)
        {
            this.passegners = passegners;
            this.port = port;
        }

        public override void About()
        {
            base.About();
            Console.WriteLine($"Number of passegners {passegners}, Home port: {port}");
        }
    }
    public class Car : Vehicle
    {
        public Car(int price, int speed, int year) : base(price, speed, year) { }

        public override void About()
        {
            base.About();
        }
    }
    public class Plane : Vehicle
    {
        int height, passengers;

        public Plane(int price, int speed, int year, int height, int passengers) : base(price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }
        public override void About()
        {
            base.About();
            Console.WriteLine($"Height: {height}, Number of passegners {passengers}");
        }
    }
    public class Vehicle
    {
        protected int price, speed, year;

        public Vehicle(int price, int speed, int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void About() { Console.WriteLine($"Price: {price}, Speed: {speed}, Year: {year}"); }
    }
}