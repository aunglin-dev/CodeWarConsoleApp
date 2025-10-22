using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarConsoleApp._7kyu
{
    public class Sum_of_two_lowest_positive_integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            
            int smallest = numbers.Min();
            
            numbers = numbers.Where(x => x != smallest).ToArray();
            int secsmallest = numbers[0];
            foreach (int i in numbers)
            {
                if(secsmallest > i)
                {
                    secsmallest = i;
                }
            }
            
            return smallest + secsmallest;
        }

        public static int sumTwoSmallestNumbersV2(int[] numbers)
        {

            return numbers.OrderBy(x=>x).Take(2).Sum();
        }

    }
}
