public class Solution {
    public long solution(int a, int b) {
        long answer = 0;

            int pivot = 0;

            if (a > b)
            {
                pivot = a - b;
                for (int i = 0; i < pivot + 1; i++)
                {
                    answer = answer + b + i;
                }
            }
            else
            {
                pivot = b - a;
                for (int i = 0; i < pivot + 1; i++)
                {
                    answer = answer + a + i;
                }
            }

            return answer;
    }
}
