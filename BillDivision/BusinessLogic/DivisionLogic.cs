using System;
using System.Collections.Generic;
using System.Text;

namespace BillDivision.BusinessLogic
{
    public class DivisionLogic
    {
        public static string BonAppetit(int[] arrayOfPrices, int indexOfItemThatAnnaDidNotEat, int amountCalculatedByTom)
        {
            int totalAmountForAnnasMeals = 0;
            string message = "Bon Appetit";
            for (int i = 0; i < arrayOfPrices.Length; i++)
            
                if (i != indexOfItemThatAnnaDidNotEat)
                    totalAmountForAnnasMeals += arrayOfPrices[i];
                
            if(totalAmountForAnnasMeals == amountCalculatedByTom)
                return message;
            else return Math.Abs(totalAmountForAnnasMeals-amountCalculatedByTom).ToString();
               

            
        }
    }
}
