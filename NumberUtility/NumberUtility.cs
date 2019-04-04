using System;
using System.Collections.Generic;
using System.Text;

namespace NumberCruncher
{
    public class NumberUtility
    {
        List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int SumOfEvenNumbers(int sum, List<int> myNumbers)
        {


            foreach (int number in myNumbers)
                
            if (number % 2 == 0)
            
                    sum += number;
                    sum++;
                return sum;
                     
                
            
        }

        public void SumOfEvenNumbers(object sum, object myNumbers)
        {
            throw new NotImplementedException();
        }

        
        





        //create a 
        //it should take a list of ints and returns the sum of all even number in that list
    }
}
