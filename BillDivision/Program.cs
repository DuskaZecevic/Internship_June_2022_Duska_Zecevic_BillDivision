using BillDivision.BusinessLogic;
using System;

namespace BillDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter meals prices");
            var arr = Console.ReadLine().Split(' ');
            var arrayOfPrices = Array.ConvertAll(arr, int.Parse);
            Console.WriteLine("Enter the index of meal that Anna did not eat");
            var indexOfItemThatAnnaDidNotEat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total amount");
            var amountCalculatedByTom = int.Parse(Console.ReadLine());

            Console.WriteLine(DivisionLogic.BonAppetit(arrayOfPrices, indexOfItemThatAnnaDidNotEat, amountCalculatedByTom));
        }
    }
}
