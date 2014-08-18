using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
   public static class Arrays
    {

        /// <summary>
        /// Max Value of an array
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        public static int MaxArrayValue(int[] myArray)
        {
            int max = 0;
            if (myArray != null)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > max)
                        max = myArray[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Average of Array values
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        public static double AvgArrayValue(double[] myArray)
        {
            double total = 0;
            if (myArray != null)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    total += myArray[i];
                }
                return total / myArray.Length;
            }

            return total;
        }


        /// <summary>
        /// Copy elements to a new array
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        public static int[] CopyArray(int[] myArray)
        {
            int[] newarray = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
                newarray[i] = myArray[i];
            return newarray;
        }


        /// <summary>
        /// Reverse the array elements
        /// </summary>
        /// <param name="myarray"></param>
        /// <returns></returns>
        public static int[] ReverseArray(int[] myarray)
        {
            int[] temp = new int[myarray.Length];
            for (int i = 0; i < myarray.Length; i++)
            {

                temp[i] = myarray[myarray.Length - (i + 1)];
                Console.WriteLine(temp[i]);

            }

            return temp;
        }


        /// <summary>
        /// Reverse the array elements efficient way
        /// </summary>
        /// <param name="myarray"></param>
        /// <returns></returns>
        public static int[] ReverseArrayEff(int[] myarray)
        {
            //int[] temp = new int[myarray.Length];
            int temp = 0;
            int length = myarray.Length;
            for (int i = 0; i < myarray.Length / 2; i++)
            {

                temp = myarray[length - (i + 1)];
                myarray[length - (i + 1)] = myarray[i];
                myarray[i] = temp;


            }

            return myarray;
        }



    }
}
