using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { -4, 3, -9, 0, 4, 1 };
            plusMinus(list);
        }

        public static void plusMinus(List<int> arr)
        {
            int countp = 0;
            int countz = 0;
            int countn = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    countz++;
                }
                else if(arr[i] >= 1)
                {
                    countp++;
                }
                else
                {
                    countn++;
                }
            }
            Console.WriteLine("{0:0.000000}",(double)countp / arr.Count);
            Console.WriteLine("{0:0.000000}",(double)countn / arr.Count);
            Console.WriteLine("{0:0.000000}",(double)countz / arr.Count);
        }
    }
}
