using System;
using System.Collections.Generic;

public class Solution
        {
            public int solution(int[] priorities, int location)
            {
                Queue<Paper> ingage = new Queue<Paper>();
                List<int> Sequence = new List<int>();

                

                for (int i = 0; i < priorities.Length; i++)
                {
                    ingage.Enqueue(new Paper(priorities[i],i));
                    Sequence.Add(priorities[i]);
                }
                Sequence.Sort();
                Sequence.Reverse();
                Queue<Paper> stack = new Queue<Paper>();
                for (int i = 0; ingage.Count !=0;)
                {
                    var a = ingage.Dequeue();
                   if ( a.periority== Sequence[i])
                    {
                        i++;
                        stack.Enqueue(a);
                    }
                    else
                    {
                        ingage.Enqueue(a);
                    }
                    
                }
                int count = 1;

                for (int i = count; stack.Dequeue().idx != location; ++count) ;

                return count;
            
            }
            
        }
        internal class Paper
        {
            public int periority = 0;
            public int idx = 0;
            public Paper(int periority, int idx)
            {
                this.periority = periority;
                this.idx = idx;
            }
        }
