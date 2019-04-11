using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberUtility
{
    public class NumberCruncher
    {
        public static int SumOfEvenNumbers(List<int> myNumbers)
        {
            int sum = 0;
            foreach (int number in myNumbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
           
            return sum;    
        }
    }
}
