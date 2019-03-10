using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[,] clothes)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        int length = clothes.GetLength(0);
        int answer = 0;
        //집어 넣는데 이미 같은 키가 잇으면++
        for (int i = 0; i < length; i++)
        {
            if (dic.ContainsKey(clothes[i, 1]))
            {
                dic[clothes[i, 1]] += 1;
            }
            else
            {
                dic.Add(clothes[i, 1], 1);
            }
        }
        var a = dic.Values;
        int resul = 1;
        foreach (var item in a)
        {
            resul = resul * (item + 1);
        }

        answer = resul - 1;

        return answer;
    }
}