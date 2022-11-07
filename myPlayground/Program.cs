using System;

namespace Project
{

    class Person
    {
        private string _firstName;
        private string _lastName;


        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }



        public void SetName()
        {
            Console.WriteLine($"{_firstName} {_lastName}: age {_age} - created.");
        }


    }

    class Car
    {

        private string _model;
        private string _make;
        public Car(string model, string make)
        {
            _model = model;
            _make = make;
        }
        public void CallCar()
        {
            Console.WriteLine($"His car is a {_model} {_make}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparing to make a person.");

            Person tyler = new Person("Tyler", "Morgan", 33);
            Car myCar = new Car("Honda", "Fit");

            tyler.SetName();
            myCar.CallCar();


        }//main
    }//program
}//namespace