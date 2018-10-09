using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInheritance
{
    public delegate string Blah();
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bike bike1 = new Bike();
            car1.SetSpeedAndPassengers(50, 4);
            bike1.SetSpeedAndPassengers(30, 1);

            Blah message = new Blah(car1.Message);

            string delegateMessage = message();

            Console.WriteLine(delegateMessage);

            Console.ReadLine();
        }

        class Vehicle
        {
            private double speed;
            private int passengers;
            private string vehicleName;
            private string fuelType;
            public Vehicle() { }
            public void SetSpeed(double s) { speed = s; }
            public void SetPassengers(int p) { passengers = p; }
            public double GetSpeed() { return speed; }
            public int GetPassengers() { return passengers; }
            public string GetFuel() { return fuelType; }
            public string GetName() { return vehicleName; }
            public void SetFuel(string f) { fuelType = f; }
            public void SetName(string n) { vehicleName = n; }
            public string Message()
            {
                string message = String.Format("A {0} uses {1} as fuel and can travel at {2} mph.", GetName(), GetFuel(), GetSpeed());
                return message;
            }
        }

        class Car : Vehicle
        {
            public Car()
            {
                SetFuel("Gas");
                SetName("Car");
            }
            public void SetSpeedAndPassengers(double s, int p)
            {
                SetPassengers(p);
                SetSpeed(s);
            }
        }
        class Bike : Vehicle
        {
            public Bike()
            {
                SetFuel( "Pizza" );
                SetName("Bike");
            }
            public void SetSpeedAndPassengers(double s, int p)
            {
                SetPassengers(p);
                SetSpeed(s);
            }
        }
    }
}
