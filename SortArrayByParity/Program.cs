using System;
using System.Collections.Generic;

namespace SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = { 3, 1, 2, 4 };
            SortArrayParity(A);

        }
    
        public static int[] SortArrayParity(int[] A)
        {
            List<int> B = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    B.Add(A[i]);

            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                    B.Add(A[i]);

            }

            return B.ToArray();

        }

    }
}
