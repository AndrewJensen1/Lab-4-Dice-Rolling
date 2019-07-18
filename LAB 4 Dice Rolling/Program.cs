using System;

namespace LAB_4_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
          
        {   //prompt
            Console.WriteLine("Welcome to the Random Casino would you like to roll the dice? y/n");
            string userInput = Console.ReadLine();



            //process

            bool go = true;
            while (go)
            {


                if (userInput == "y")
                {
                    Console.WriteLine("What sided dice would you like to roll?");
                    string numberOfSides = Console.ReadLine();
                    int userInput1 = int.Parse(numberOfSides);

                    int diceRoll = RandomRoll(userInput1);
                    int diceRoll2 = RandomRoll(userInput1);

                    Console.WriteLine($"Die One Rolled a {diceRoll}, Die Two Rolled a {diceRoll2}");
                    if (diceRoll + diceRoll2 == 7 || diceRoll + diceRoll2 == 11)
                    {
                        Console.WriteLine("You Rolled CRAPS!!!");
                    }
                    else if (diceRoll == 1 && diceRoll2 == 1)
                    {
                        Console.WriteLine("You got the snake eyes");
                    }
                    else if (diceRoll == 6 && diceRoll2 == 6)
                    {
                        Console.WriteLine("Boxcars!!!!!!");
                    } 
                  

                    Console.WriteLine("\nWould you like to roll again? y/n");
                    string userInput2 = Console.ReadLine();

                    if (userInput2 != "y")
                    {
                        Console.WriteLine("\nGood Bye!");
                        go = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nGood Bye!");
                    go = false;
                }
            }



        }
        public static int RandomRoll(int userInput)
        {
            Random random = new Random();
            return random.Next(1, userInput+1);

            

        }
    }
}
