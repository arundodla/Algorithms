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
            //int p = 20 % 10;
            Console.WriteLine(GreatestCommonDivisor(10,20));
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
