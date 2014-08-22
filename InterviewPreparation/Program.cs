using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greatest Common Divisor
            //Console.WriteLine(GreatestCommonDivisor(10,20));

            //Max Value from an array.
            //int [] a = {3,5,2,4,1,8};
            // Console.WriteLine(Arrays.MaxArrayValue(a));

            //Average of My array values
            //double[] b = { 3, 5, 2, 4, 1, 8 };
            //Console.WriteLine(Arrays.AvgArrayValue(a));

            //Copy elements to a new array
            //int [] c = {3,5,2,4,1,8};
            //Console.WriteLine(Arrays.CopyArray(c)[1]);


            //Reverse Array
            //int[] d = { 1,2,3,4,5,6 };
            //Arrays.ReverseArray(d);

            


            //d = Arrays.ReverseArrayEff(d);
            //for (int i = 0; i < d.Length; i++)
            //    Console.WriteLine(d[i]);
            //    Console.ReadLine();

            Console.WriteLine(Arrays.isPrime(2));
            Console.ReadLine();
        }





        public static  int GreatestCommonDivisor(int p, int q)
        {
            if (q == 0)
                return p;
            int r = p % q;
            return GreatestCommonDivisor(q, r);

        }



       
    }
}
