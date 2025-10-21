using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarConsoleApp._6kyu
{
    public class Unique_In_Order
    {

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            var smth =  iterable.ToArray();
            for(int i = 0; i < smth.Length; i++)
            {
                if(i == 0 || !smth[i].Equals(smth[i - 1]))
                {
                    result.Add(smth[i]);
                }
                
            }
            
            return result;
        }

        public static IEnumerable<T> UniqueInOrderYield<T>(IEnumerable<T> iterable) { 
            T previous = default(T);

            foreach(T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                   yield return current;
                     
                }
                
            }
        }

        public static IEnumerable<T> UniqueInOrderLinq<T>(IEnumerable<T> iterable)
        {
            return iterable.Where((x, i) => i== 0 ||  !Equals(x,iterable.ElementAt(i-1)) );
        }
    }
}
