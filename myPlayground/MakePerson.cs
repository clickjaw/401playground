using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Project
{
    class MakePerson
    {

         private string _firstName;
        private string _lastName;
        private int _age;

        public MakePerson(string firstName, string lastName, int age)
        {
            
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }



        public void SetName()
        {
            Console.WriteLine($"{_firstName} {_lastName}: age {_age} - created.");
        }


        static void Make(string[] args)
        {
            Console.WriteLine("What is your first name");
            string userFirst = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string userLast = Console.ReadLine();
            Console.WriteLine("What is your age");
            int userAge = int.Parse(Console.ReadLine());

            MakePerson tyler = new MakePerson(userFirst, userLast, userAge);
        }
    }
}