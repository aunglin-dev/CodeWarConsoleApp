using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarConsoleApp._6kyu
{
    public class Find_The_Parity_Outlier
    {
        public static int Find(int[] integers)
        {
           int [] positivenumber =   integers.Where(el => el % 2 == 0).ToArray();
            if(positivenumber.Length >1)
            {
                int sldd= integers.Where(el => el % 2 != 0).FirstOrDefault();
                return sldd;
            }

            return positivenumber.FirstOrDefault();
        }
    }
}
