using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine drinkMachine = new DrinkMachine();

            
            string welcomeMessage = "Welcome to the Vending Machine!\nPlease enter coin";
            WriteLine(welcomeMessage);
            
            drinkMachine.ValidateEntry();          
            
        }
    }
}
