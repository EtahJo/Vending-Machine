﻿using System;
using System.Collections.Generic;

namespace MenuSelection
{
    class Program
    {
            public static void Main()
        {
            decimal money=0;
            int menuSelection;
            bool hasEnteredMony = false;
            decimal minPrice = 0;
            decimal itemPrice=0;
            string itemName="";
            bool itemValide= false;
            List<string> productNames = new List<string>();
            List<decimal> productPrice = new List<decimal>();
            bool isEnteringProducts = true;
            bool hasEnteredItemPrice = false;
            


            while (isEnteringProducts)
            {
                Console.Write("Enter product name (or blank to stop entering product): ");
                itemName = Console.ReadLine();
                if (itemName == "") isEnteringProducts = false;
                else
                {
                    hasEnteredItemPrice = false;
                    while (!hasEnteredItemPrice)
                    {
                        Console.Write("Enter" + itemName + "'s price: ");
                        hasEnteredItemPrice = decimal.TryParse(Console.ReadLine(), out itemPrice);
                        if (itemPrice <= 0)
                        {
                            hasEnteredItemPrice = false;
                            Console.WriteLine(itemPrice + "Is not valid. Please enter a price larger than zero");
                        }
                    }

                    if (itemPrice < minPrice)
                    {
                        minPrice = itemPrice;
                    }

                    productNames.Add(itemName);
                    productPrice.Add(itemPrice);

                }
            }

            while (!hasEnteredMony)
            {
                Console.Write("Please enter how much you have : ");

                hasEnteredMony = decimal.TryParse(Console.ReadLine(),out money);

                if(!hasEnteredMony)
                {
                    Console.WriteLine("Please enter valid amount");
                }
                else if (money < minPrice)
                {
                    Console.WriteLine("You don't have enough to make any purchase");
                }
            }

           
            while (money >= minPrice )
            {
                Console.WriteLine("You have {0} frs", money);
                for(int i=0; i<=productNames.Count-1;i++)
                {
                    Console.WriteLine("[" + (i + 1) + "]" + productNames[i] + "- frs" + productPrice[i]);
                }

                Console.Write(": ");

                if(int.TryParse(Console.ReadLine(),out menuSelection))
                {
                    itemValide = false;
                    if (menuSelection > 0)
                    {
                        if (menuSelection <= productNames.Count)
                        {
                            itemPrice = productPrice[menuSelection - 1];
                            itemName = productNames[menuSelection - 1];
                            itemValide = true;
                        }
                    }

                }
               
               
                //if (menuSelection == "1")
                //    {
                //    itemValide = true;
                //    itemName = "Spinache";
                //    itemPrice = 200;
                      
                //    }
                //    else if (menuSelection == "2")
                //    {
                //    itemValide = true;
                //    itemName = "Kossam";
                //    itemPrice = 500;
                //}
                //    else if (menuSelection == "3")
                //    {
                //    itemValide = true;
                //    itemName = "Puff puff";
                //    itemPrice = 50;
                //}
               

                if (itemValide)
                {
                    if (itemPrice > money)
                    {
                        Console.WriteLine("You don't have enough money for this purchase");
                    }
                    else
                    {
                        money -= itemPrice;
                        Console.WriteLine("You bought {0}, you are now left with {1} frs ", itemName, money);
                    }
                }


                
               
            }
            Console.WriteLine("Sorry, You no longer have money to make any purchase");

        }
    }
}
