using System;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] returnArr = new int[commands[i, 1] - commands[i, 0] + 1];
            int index = 0;
            //자르기
            for (int j = commands[i, 0] - 1; j <= commands[i, 1] - 1; j++)
            {
                returnArr[index] = array[j];
                index++;
            }
            index = 0;
            //정렬
            for (int k = 1; index < returnArr.Length - 1; k++)
            {
                if (returnArr[index] > returnArr[k])
                {
                    int a = returnArr[index];
                    returnArr[index] = returnArr[k];
                    returnArr[k] = a;
                }
                if (k == returnArr.Length - 1)
                {
                    index++;
                    k = index;
                }
            }
            index = 0;
            //추출
            answer[i] = returnArr[commands[i, 2] - 1];
        }

        return answer;
    }
}
