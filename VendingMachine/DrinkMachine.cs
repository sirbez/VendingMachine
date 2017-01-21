using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VendingMachine
{
    class DrinkMachine
    {
        private int amount = 0;       

        private int change=0;
                    
        public int Change
        {
            get { return change; }
            set { change = value; }
        }

        public int Amount{ get { return amount; } private set {; } }      
        
        internal void ValidateEntry()
        {
          
            string coin = ReadLine();
            int userCoin = 0;

            if (!int.TryParse(coin, out userCoin))
            { 
                WriteLine("Fake coin detected!");
                amount = 0;
                Console.Clear();
            }
            if (userCoin == 5 || userCoin == 10 || userCoin == 25 || userCoin == 100)
                
                DepositCoin(userCoin);
            else
            { 
                WriteLine("Please enter valid coin");
                ValidateEntry();
            }
        }

        void DepositCoin(int coin){

            amount += coin;
            while (amount<=150)
            {                                                           
                ValidateEntry();              
            }
            if(amount>150)
                change = amount - 150;
            amount = 0;
            DisplayDrinkSelections();                     
        }
        void DisplayDrinkSelections(){

            WriteLine("*****************");
            WriteLine("*C - Coke *");
            WriteLine("*P - Pepsi *");
            WriteLine("*D - Diet Coke *");
            WriteLine("*****************");

            string pressedKey = (string)ReadLine().ToUpper();

            MakeDrinkSelection(pressedKey);
           
        }       
        void OrderAdditionalDrink()
        {
            WriteLine("To order another dirnk please enter coin:\n");           
            ValidateEntry();
        }
        void MakeDrinkSelection(string seletion)
        {
            
            if (seletion == "C")
            {
                WriteLine("Thank you for choosing a Coke\n");
                if (change > 0)
                {
                    WriteLine("Please take your change  {0}\n", change);                   
                    OrderAdditionalDrink();                    
                }
                OrderAdditionalDrink();
            }

            else if (seletion == "P")
            {
                WriteLine("Thank you for choosing a Pepsi\n");
                if (change > 0)
                {
                    WriteLine("Please take your change  {0}\n", change);
                    OrderAdditionalDrink();
                }
                OrderAdditionalDrink();
            }
            else if (seletion == "D")
            {
                WriteLine("Thank you for choosing a Diet Coke\n");
                if (change > 0)
                {
                    WriteLine("Please take your change  {0}\n", change);
                    OrderAdditionalDrink();

                }
                OrderAdditionalDrink();

            }
            else
            {
                WriteLine("Please Choose form the list:\n");
                OrderAdditionalDrink();
                
            }
        }
    }
}
