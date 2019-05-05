using System;
using System.Collections.Generic;
using System.Collections;


public class Solution
{
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 0;
        Queue<int> bridge = new Queue<int>();
        Queue<int> trucks = new Queue<int>();
        //다리에 공란 체우기
        for (int i = 0; i < bridge_length; i++)
        {
            bridge.Enqueue(0);
        }
        for (int i = 0; i < truck_weights.Length; i++)
        {
            trucks.Enqueue(truck_weights[i]);
        }
        for (int i = 1; bridge.Count !=0; i++)
        {
            weight += bridge.Dequeue();
            if (trucks.Count == 0)
            {
            answer = i;
                continue;
            }
            if (weight >= trucks.Peek())
            {
                var a = trucks.Dequeue();
                weight -= a;
                bridge.Enqueue(a);
            }
            else
            {
                bridge.Enqueue(0);
            }
        }
        return answer;
    }}
