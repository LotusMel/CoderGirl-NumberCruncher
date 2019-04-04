using System;
using System.Collections.Generic;


namespace NumberCruncher
{
    public static class Program
    {
        List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static void Main()
        {
            NumberUtility numberUtility = new NumberUtility();

            
            Console.WriteLine(numberUtility.SumOfEvenNumbers(sum, myNumbers));
            Console.ReadLine();
        }

       
    }
}
