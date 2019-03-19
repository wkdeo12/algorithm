using System;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int[] progresses, int[] speeds)
    {
        int[] answer = new int[] { };
        Queue<int> time = new Queue<int>();
        Stack<int> Q2 = new Stack<int>();
        List<int> aL = new List<int>();

        for (int i = 0; i < progresses.Length; i++)
        {
            var devide = (100 - progresses[i]) / speeds[i];
            var a = (100 - progresses[i]) % speeds[i] == 0 ? devide : devide + 1;
            time.Enqueue(a);
        }


        for (int i = 0; time.Count!=0; i++)
        {
            
                Q2.Push(time.Dequeue());
            
            for (int j = 0; j < time.Count+1; j++)
            {
                if (time.Count == 0)
                {
                    break;
                }
                var a = Q2.Pop();
                var b = time.Dequeue();
                if (a >= b)
                {
                    Q2.Push(b);
                    Q2.Push(a);
                    j--;
                }
                else
                {
                    Q2.Push(a);
                    time.Enqueue(b);
                    for (int c = 0; c < time.Count-1; c++)
                    {
                        time.Enqueue(time.Dequeue());
                    }
                    break;
                }
            }
            aL.Add(Q2.Count);
            Q2.Clear();
        }
        answer=aL.ToArray();

        return answer;
    }
}
