using System;

namespace Playground
{
    class Glass
    {
        public int LiquidLevel;

        public void Drink(int milliliters)
        {
            LiquidLevel -= milliliters;
        }

        public void Refill()
        {
            if (LiquidLevel < 100)
            {
                LiquidLevel = 200;
            }
        }

    }//Glass


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Glass glass = new Glass();
            glass.LiquidLevel = 200;
            bool stopped = false;

            while (!stopped)
            {
                // Console.WriteLine("drink, print, exit");
                string command = Console.ReadLine();

                string[] divide = command.Split(' ');

                switch (divide[0])
                {

                    case "drink":

                        string number = divide[1];
                        int milliliters = Convert.ToInt32(number);

                        glass.Drink(milliliters);
                        if (glass.LiquidLevel < 100)
                            glass.Refill();
                        break;

                    case "print":

                        if (glass.LiquidLevel >= 151 && glass.LiquidLevel < 200)
                        {
                            Console.WriteLine(@"
|  |
|##|
|##|
|##|


                                ");
                        }
                        else if (glass.LiquidLevel <= 150 && glass.LiquidLevel >= 100)
                        {
                            Console.WriteLine(@"
|  |
|  |
|##|
|##|                   
                                                    
                                ");
                        }
                        else
                        {
                            Console.WriteLine(@"
|##|
|##|
|##|
|##|

                            ");
                        }

                        // Console.WriteLine($"This glass contains {glass.LiquidLevel} milliliters of liquid.");
                        break;

                    case "stop":

                        stopped = true;
                        break;

                }//switch
            }//while
        }//Main
    }//Program
}
