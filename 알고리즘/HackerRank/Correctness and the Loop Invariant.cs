using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    class Solution
    {
        public static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j > 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            List<int> sort = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                sort.Add(A[i]);
            }
            sort.Sort();
            Console.WriteLine(string.Join(" ", sort));
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
        }
    }
}