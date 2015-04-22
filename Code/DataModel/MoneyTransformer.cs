using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    // This utility class was created in order to transform a string into an integer.
    // We have to use the transformation of string input into an integer in serveral places 
    // in our application so we decided to create a class here with static method
    // that we can use where we need.

    public class MoneyTransformer
    {
        /*
         * This method takes in a string amount and converts it to an int for ease of communitcation with the DataBase.
         * There are 4 options for input: option 1: 5, option 2: 5.1, option 3: 5.01 and option 4: 5.123 - this is taken care of by Regex
         */
        public static int TransformMoney(string amount)
        {
            // first we need to remove the period
            if (amount.IndexOf(".") != -1) 
            {
                string[] divideAmt = amount.Split('.');
                // getting the length of the characters on the right side of the period - the cents
                int count = divideAmt[1].Length;
                // option 2: if string = 5.1
                if (count == 1) 
                {
                    amount = amount + "0"; // concatinate with an additional "0", so the string becomes 5.10
                }
                // if the user entered option 3: 5.01, then we just move straight to the next step 
                // of removing the period
                amount = amount.Replace(".", "");
                amount = amount.Replace(",", "");//if the ammount is larger need to make sure that comas are removed
            }
            // If the user enters whole denominations, this is option 1: if just "X" amount, eg 5
            else 
            {
                amount = amount + "00"; // concatinate with an additional "00", so the string becomes 500
            }

            // then we convert this amount to an int
            int moneyInInt;
            moneyInInt = Convert.ToInt32(amount);

            return moneyInInt;

        }


    }
}
