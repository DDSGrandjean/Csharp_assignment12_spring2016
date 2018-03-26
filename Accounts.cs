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
    class Accounts
    {
        //Varibale instantiation
        private string[] nameArray;
        private double[] payableArray;
        private string table;
        private string company;
        private double total;
        private bool found;
        private double payableResult;

        //Default constructor
        public Accounts(){}

        //Get values from client
        public string[] Names { set { nameArray = value; } }
        public double[] Payables { set { payableArray = value; } }
        public string Company { set { company = value.ToUpper(); } }

        public string Table()
        {
            //Reset values everytime the method is called
            table = string.Empty;
            total = 0;
            //Display titles
            table += "Name\tPayable\n";
            //Assign each company's name and their respective payable to the table
            for (int i = 0; i < nameArray.Length; i++)
            {
                table += nameArray[i] + "\t" + payableArray[i].ToString("c") + "\n";
                total += payableArray[i];
            }
            //Add the total to the table string
            table += "Total\t" + total.ToString("c");
            //Return the table
            return table;
        }

        private void FindPayable()
        {
            int position;
            //Locate the index of a search
            position = Array.IndexOf(nameArray, company);
            if (position != -1)
            {
                found = true;
                payableResult = payableArray[position];
            }
        }

        public override string ToString()
        {
            FindPayable();
            //Return formatted result to the player
            if (found)
                return company + "\nAccount Payable is " + payableResult.ToString("c");
            else
                return "Company not found";
        }
    }
}
