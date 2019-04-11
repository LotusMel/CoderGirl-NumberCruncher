using System;
using System.Collections.Generic;
using System.Linq;
using NumberUtility;


namespace NumberCruncher
{
    public static class Program
    {

        public static void Main()
        {
           
            List<int> myNumbers = new List<int> { 2, 5, 6, 9, 12, 13, 15, 16 };
            Console.WriteLine(NumberUtility.NumberCruncher.SumOfEvenNumbers(myNumbers));
            Console.ReadLine();
        }

       
    }
}
