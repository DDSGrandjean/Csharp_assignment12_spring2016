//DYLAN GRANDJEAN
//Assignment 12 - Account Payable
//This program is designed to display company's name and payable and allows
//the user to look for a specific company's payable in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Main
    {
        static void Main(string[] args)
        {
            //Array declaration
            string[] names = { "OXONY", "CORE", "ITECH", "APPLE" };
            double[] payable = { 25000, 37000, 10000, -500 };

            //Class object creation
            Accounts accounts = new Accounts();
            //Send arrays over to the class
            accounts.Names = names;
            accounts.Payables = payable;

            //Display the header and the instructions
            Header();
            Instruction();

            //Display table of companies' name and payables
            Console.WriteLine(accounts.Table());
            //Get user's input
            Console.WriteLine("*******************************************************");
            Console.Write("Enter name of company: ");
            accounts.Company = Console.ReadLine();

            //Display result
            Console.WriteLine("\n*******************************************************\n" + accounts.ToString());
            Console.Read();
        }

        //Program's header
        private static void Header()
        {
            Console.WriteLine("\tAccount Payable\n" +
                              "\tList accounts payable with total money owed.\n" +
                              "\tand determine money owed by a specific company\n" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString());
        }

        //Instruction for the user
        private static void Instruction()
        {
            Console.WriteLine("*******************************************************\n" +
                              "This program will display a list of accounts payable and\n" +
                              "\ttotal money owed.\n" +
                              "\tIt will also find money owed for a specific account.\n" +
                              "\tWhen prompted, enter company's name to determine\n" +
                              "\tmoney owed by that company.\n" +
                              "*******************************************************");
        }
    }
}
