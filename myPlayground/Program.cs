using System;

namespace Hello{
    class Program{
        static void Main(string[] args){
        
        Console.Clear();
        
        Computer comp = new Computer{
            Brand = "Apple",
            Year = 2022,
            Model = "M2 MacBook Air"
        };

        Console.WriteLine($"My new computer is a {comp.Year} {comp.Brand} {comp.Model}.");


        }//Main

        class Computer{
            public string Brand;
            public int Year;
            public string Model;
        }
    }
}