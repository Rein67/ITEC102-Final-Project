/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int coins = 50;
        int seeds = 5;
        int crops = 0;
        int day = 1;
        string playerName = "";
        string play;
        int enterName = 0;

        bool gameOver = false;
        bool playAgain = false;
        
        do {
        Console.WriteLine("==================================");
        Console.WriteLine("       RANDOM FARM SURVIVAL");
        Console.WriteLine("==================================");
        Console.WriteLine("Manage your farm for 7 days!");
        Console.WriteLine("Earn at least 100 coins to win.");
        
        Console.WriteLine("\nGame Probabilities");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Weather Spawn Rate:");
        Console.WriteLine("Sunny: 50%");
        Console.WriteLine("Rainy: 30%");
        Console.WriteLine("Stormy: 20%");
  
        Console.WriteLine("\nFarm Event Spawn Rate:");
        Console.WriteLine("15 coins bonus: 10%");
        Console.WriteLine("Receiving a seed: 15%");
        Console.WriteLine("Pests: 15%");
        Console.WriteLine();
        
        if (enterName == 0)
        {
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Welcome, " + playerName + "!");
        
        while (day <= 7 && gameOver == false)
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("DAY " + day + " - " + playerName);
            Console.WriteLine("==================================");
            Console.WriteLine("PREVIOUS DAY");
            Console.WriteLine("Coins: " + coins);
            Console.WriteLine("Seeds: " + seeds);
            Console.WriteLine("Growing crops: " + crops);

            int weather = random.Next(1, 101);
         
                if (weather <= 50)
                {
                    Console.WriteLine("Weather: Sunny!");
                }
                else if (weather <= 80)
                {
                    Console.WriteLine("Weather: Rainy!");
                }
                else 
                {
                    Console.WriteLine("Weather: Stormy!");
                    if (crops > 0)
                    {
                        crops--;
                        Console.WriteLine("The storm damaged one crop!");
                    }
                    else 
                    {
                        Console.WriteLine("Luckily, you had no crops to lose.");
                    }
                }
        
            int farmEvent = random.Next(1, 101);

                if (farmEvent <= 10)
                {
                    Console.WriteLine("Farm event: You found 15 bonus coins!");
                    coins = coins + 15;
                }
                else if (farmEvent <= 25)
                {
                    Console.WriteLine("Farm event: A neighbor gave you a seed!");
                    seeds++;
                }
                else if (farmEvent <= 40)
                {
                    Console.WriteLine("Farm event: Pests damaged your farm!");
                    if (crops > 0)
                    {
                        crops--;
                    }
                }
                else
                {
                    Console.WriteLine("Farm event: Nothing unusual happened.");
                }
            
            if (coins <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("GAME OVER!");
                Console.WriteLine("You ran out of coins.");
                gameOver = true;
            }
            else
            {
                bool actionDone = false;

                while (actionDone == false && gameOver == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Plant a seed (-10 coins)");
                    Console.WriteLine("2. Harvest crops (+25 coins each plant)");
                    Console.WriteLine("3. Rest for the day");
                    Console.Write("Enter your choice (1-3): ");
                    int action = int.Parse(Console.ReadLine());
                    
                    if (action == 1)
                    {
                        if (seeds > 0 && coins >= 10)
                        {
                            seeds--;
                            coins = coins - 10;
                            crops++;

                            Console.WriteLine("\nYou planted a seed!");
                            Console.WriteLine("\nYour crop will be ready to harvest.");
                            actionDone = true;
                        }
                        else if (seeds == 0)
                        {
                            Console.WriteLine("\nYou have no seeds!");
                        }
                        else
                        {
                            Console.WriteLine("\nYou need at least 10 coins!");
                        }
                    }
                    else if (action == 2)
                    {
                        if (crops > 0)
                        {
                            int earnings = crops * 25;

                            coins = coins + earnings;

                            Console.WriteLine("You harvested " + crops + " crops!");
                            Console.WriteLine("You earned " + earnings + " coins!");

                            crops = 0;
                            actionDone = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou have no crops to harvest!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou rested for the day.");
                        actionDone = true;
                    }
                }

                if (coins <= 0 && gameOver == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("You ran out of coins.");
                    gameOver = true;
                }
            }

            if (gameOver == false)
            {
                Console.WriteLine();
                Console.WriteLine("End of Day " + day);
                Console.WriteLine("Coins remaining: " + coins);

                day++;

                if (day > 7)
                {
                    break;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("==================================");
        Console.WriteLine("           GAME RESULTS");
        Console.WriteLine("==================================");
        Console.WriteLine("Player: " + playerName);

        Console.WriteLine("Final coins: " + coins);
        Console.WriteLine("Unused seeds: " + seeds);
        Console.WriteLine("Unharvested crops: " + crops);

        if (gameOver == false && day > 7 && coins >= 100)
        {
            Console.WriteLine("\nCONGRATULATIONS!");
            Console.WriteLine("You Win!");
            Console.WriteLine("You met the goal.");
        }
        else if (gameOver == false && day > 7 && coins < 100)
        {
            Console.WriteLine("You Lose!");
            Console.WriteLine("You did not meet the winning goal.");
        }
        
        Console.Write("\nPlay Again (y/n)? ");
        play = Console.ReadLine().ToUpper();
        
        if (play == "Y")
        {
            playAgain = true;
            coins = 50;
            seeds = 5;
            crops = 0;
            day = 1;
            enterName++;
        }
        else
        {
            playAgain = false;
        }
        
        Console.WriteLine();
        
        } while (playAgain == true);
        
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("\n--------------------------------- ");
        Console.WriteLine("Credits to:");
        Console.WriteLine("Boss Reyn");
        Console.WriteLine("Jey");
        Console.WriteLine("Rynol");
    }
}
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
  }
}