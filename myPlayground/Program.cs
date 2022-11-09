using System;

namespace Family{

    class Children{
        public string name;
        public int age;

        public string hairColor;

        public void Intro(){
            Console.WriteLine(name + " is " + age + " years old.");
        }

        public Children(string name, int age, string hairColor){
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
        }
    }//children

    class Wife{
        public string name;
        public int age;

        public bool beautiful;

        public void Intro(){
            Console.WriteLine(name + " is my wife.");
        }
        public Wife(string name, int age, bool beautiful){
            this.name = name;
            this.age = age;
            this.beautiful = beautiful;
        }
    }


    class Program{

        static void Main(string[] args){

            Console.Clear();

            Children Waylon = new Children("Waylon", 4, "blonde");
            Children Fletcher = new Children("Fletcher", 0, "brunette");

            Wife Hillary = new Wife("Hillary", 31, true);

            Waylon.Intro();
            Fletcher.Intro();

            Hillary.Intro();


        }


    }
}