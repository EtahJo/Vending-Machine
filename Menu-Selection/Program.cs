using System;

namespace MenuSelection
{
    class Program
    {
            public static void Main()
        {
            decimal money=0;
            string menuSelection;
            bool hasEnteredMony = false;
            int minPrice = 50;
            decimal itemPrice=0;
            string itemName="";
            bool itemValide= false;

            while (!hasEnteredMony)
            {
                Console.Write("Please enter how much you have : ");

                hasEnteredMony = decimal.TryParse(Console.ReadLine(),out money);

                if(hasEnteredMony== false)
                {
                    Console.WriteLine("Please enter valied amount");
                }
                else if (money < minPrice)
                {
                    Console.WriteLine("You don't have enough to make any purchase");
                }
            }

           
            while (money > minPrice )
            {
               
                Console.WriteLine("1. Spinache for 200 frs");
                Console.WriteLine("2. Kossam for 500 frs");
                Console.WriteLine("3. Puff puff for 50 frs");
                Console.Write("Please enter your selection: ");

                menuSelection = Console.ReadLine();
                itemValide = false;
                Console.WriteLine("You have {0} frs", money);
                if (menuSelection == "1")
                    {
                    itemValide = true;
                    itemName = "Spinache";
                    itemPrice = 200;
                      
                    }
                    else if (menuSelection == "2")
                    {
                    itemValide = true;
                    itemName = "Kossam";
                    itemPrice = 500;
                }
                    else if (menuSelection == "3")
                    {
                    itemValide = true;
                    itemName = "Puff puff";
                    itemPrice = 50;
                }
               

                if (itemValide)
                {
                    if (itemPrice > money)
                    {
                        Console.WriteLine("You don't have enough money for this purchase");
                    }
                    else
                    {
                        money -= itemPrice;
                        Console.WriteLine("You bought {0}, you are now left with {1} frs ",itemName, money);
                    }
                }


                
               
            }
            Console.WriteLine("Sorry, You no longer have money to make any purchase");

        }
    }
}
