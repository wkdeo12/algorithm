using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] heights)
    {
        List<int> answer = new List<int>();

        Queue<int> Wheel = new Queue<int>();

        for (int i = heights.Length - 1; i >= 0; i--)
        {
            Wheel.Enqueue(heights[i]);
        }
        int compare = 0;
        bool go = true;
        for (int i = 1; Wheel.Count != 0; i++)
        {
            go = true;
            compare = Wheel.Dequeue();
            for (int j = 0; j < Wheel.Count; j++)
            {
                var a = Wheel.Dequeue();
                if (compare < a && go == true)
                {
                    answer.Add(Wheel.Count + 1 - j);
                    go = false;
                }

                Wheel.Enqueue(a);
            }
            if (go == true)
            {
                answer.Add(0);
            }
        }
        answer.Reverse();
        int[] realAnswer = answer.ToArray();
        return realAnswer;
    }

    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] heights = new int[] { 1, 5, 3, 6, 7, 6, 5 };
        var a = sol.solution(heights);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
