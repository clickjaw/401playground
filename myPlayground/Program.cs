using System;
using System.Threading;
namespace Tic_Tac_Toe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int user = 1;
        static int userName; 
   
        static int scoreCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name user1: ");
            string userNameSelection1 = Console.ReadLine();
            Console.WriteLine("Enter name user2: ");
            string userNameSelection2 = Console.ReadLine();
            Console.WriteLine($"{userNameSelection1}: X\n{userNameSelection2}: O");
            do
            {

                Console.Clear(); // this calls a fresh window. love it.

                Console.WriteLine("\n");
                if (user % 2 == 0)// when user is called if modulus=0 then it's user1
                {
                    Console.WriteLine($"{userNameSelection2}'s Chance");
                }
                else
                {
                    Console.WriteLine($"{userNameSelection1}'s Chance");
                }
                Console.WriteLine("\n");

                Board();

                userName = int.Parse(Console.ReadLine());
                //if arr[userName] == both X&O then it returns a "sorry"
                if (arr[userName] != 'X' && arr[userName] != 'O')
                {
                    if (user % 2 == 0) //marks O
                    {
                        arr[userName] = 'O';
                        user++;
                    }
                    else
                    {
                        arr[userName] = 'X'; //marks X
                        user++;
                    }
                }
                else

                {
                    Console.WriteLine("{0} is already taken by {1}.\nSelect again.", userName, arr[userName]);
                    Thread.Sleep(1500);
                }

                scoreCount = win();// calling win
            }
            while (scoreCount != 1 && scoreCount != -1);
            Console.Clear();// clearing the console
            Board();
            if (scoreCount == 1)
            {
                if(userName == 1){
                    Console.Clear();
                    Console.WriteLine($"{userNameSelection1} wins!");
                }else{
                    Console.Clear();
                    Console.WriteLine($"{userNameSelection1} wins!");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Board method which creats board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[1]}  |  {arr[2]}  |  {arr[3]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[4]}  |  {arr[5]}  |  {arr[6]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[7]}  |  {arr[8]}  |  {arr[9]}");
            Console.WriteLine($"     |     |      ");
        }


        private static int win()
        {
            #region Horzontal Win
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Win
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Win
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}