using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ProjectDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a piggy bank counter
            //ask user for pennies nickels dimes quarters half dollars and dollar coins
            //print the total of the money
            //bonus if the bank holds over $20 tell the user how many $20 bills
            int dollar = 0;
            int twenty = 0;
            int penny = 0;
            int dime = 0;
            int nickel = 0;
            int quarter = 0;
            int fifty = 0;
            //initialized all the money 
            //maybe "ask "do you have any money to put in the ePiggy Bank?"
            //while answer is not "N"
            //ask - go through the list
            //how many X
            //after you ask each
            //give the total
            //then ask if they have any more money
            //and if the answer is not N you go again
            string moreMoney = "Y";
            Console.WriteLine("*********************************************");
            Console.WriteLine("*         THE FANTASITC EPIGGY BANK         *");
            Console.WriteLine("*********************************************");

            while (moreMoney == "Y" || moreMoney == "y")
            {
                Console.WriteLine("How many golden dollars do you want to add?");
                int newDollar = int.Parse(Console.ReadLine());
                dollar = dollar + newDollar;
                Console.WriteLine("How many fifty cent pieces do you want to add?");
                int newFifty = int.Parse(Console.ReadLine());
                fifty = fifty + newFifty;
                penny = penny + (fifty * 50);
                fifty = 0;//converted to pennies and reset to 0
                //Console.WriteLine("current penny " + penny);//checking
                Console.WriteLine("How many quarters do you want to add?");
                int newQuarter = int.Parse(Console.ReadLine());
                quarter = quarter + newQuarter;
                penny = penny + (quarter * 25);
                quarter = 0; //converted to pennies and reset to 0
                //Console.WriteLine("current penny " + penny); //checking
                Console.WriteLine("How many dimes do you want to add?");
                int newDime = int.Parse(Console.ReadLine());
                dime = dime + newDime;
                penny = penny + (dime * 10);
                dime = 0; //converted to pennies, reset to 0
                Console.WriteLine("How many nickels do you really want to add?");
                int newNickel = int.Parse(Console.ReadLine());
                nickel = nickel + newNickel;
                penny = penny + (nickel * 10);
                nickel = 0; //converted to pennies, reset to 0
                Console.WriteLine("Ok finally.. got any pennies?");
                int newPenny = int.Parse(Console.ReadLine());
                penny = penny + newPenny;
                while (penny >= 100)
                {
                    penny = penny - 100;
                    dollar = dollar + 1;
                   // Console.WriteLine("current penny " + penny);//checking
                   // Console.WriteLine("current dollar " + dollar);//checking
                }
                if (dollar >= 20)
                {
                    twenty = (dollar / 20);
                }
                Console.WriteLine("Your ePiggy Bank holds " + dollar + " dollars and " + penny + " cents"); //write total
                if (twenty >= 1)
                {
                    Console.WriteLine("That's " + twenty + " twenty dollar bills!");
                }
                
            Console.WriteLine("Do you have any money to put in the ePiggy Bank? (Y/N)");
            moreMoney = Console.ReadLine();
            }

        }
    }
}
