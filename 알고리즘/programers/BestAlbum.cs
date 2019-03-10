using System;
using System.Collections.Generic;

public class Solution
{
    public List<int> solution(string[] genres, int[] plays)
    {
        Dictionary<string, Songs> genreMap = new Dictionary<string, Songs>();

        for (int i = 0; i < genres.Length; i++)
        {
            if (genreMap.ContainsKey(genres[i]))
            {
                genreMap[genres[i]].playCountAll += plays[i];
                genreMap[genres[i]].playCount.Add(plays[i]);
                genreMap[genres[i]].name.Add(i);
            }
            else
            {
                genreMap.Add(genres[i], new Songs(plays[i], i));
            }
        }

        List<Songs> songs = new List<Songs>();
        foreach (var item in genreMap.Values)
        {
            item.Sorting();
            songs.Add(item);
        }
        for (int i = 0; i < songs.Count - 1; i++)
        {
            for (int j = i + 1; j < songs.Count; j++)
            {
                if (songs[i].playCountAll <= songs[j].playCountAll)
                {
                    var a = songs[i];
                    songs[i] = songs[j];
                    songs[j] = a;
                }
            }
        }

        List<int> answer = new List<int>();
        for (int i = 0; i < songs.Count; i++)
        {
            if (songs[i].playCount.Count > 1)
            {
                answer.Add(songs[i].name[0]);
                answer.Add(songs[i].name[1]);
            }
            else
            {
                answer.Add(songs[i].name[0]);
            }
        }
        return answer;
    }
}

internal class Songs
{
    public List<int> playCount = new List<int>();
    public List<int> name = new List<int>();
    public int playCountAll;

    public Songs(int play, int index)
    {
        this.playCount.Add(play);
        this.name.Add(index);
        this.playCountAll = play;
    }

    public void Sorting()
    {
        if (playCount.Count == 1)
        {
            return;
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 1; j < playCount.Count; j++)
            {
                if (playCount[i] < playCount[j])
                {
                    var x = playCount[i];
                    var y = name[i];
                    playCount[i] = playCount[j];
                    name[i] = name[j];
                    playCount[j] = x;
                    name[j] = y;
                }
                else if (playCount[i] == playCount[j])
                {
                    if (name[i] > name[j])
                    {
                        name[i] = name[j];
                    }
                }
            }
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        string[] g = new string[] { "a", "a", "b", "b", "c", "f", "h", "asdf" };
        int[] p = new int[] { 500, 600, 150, 800, 2500, 3, 0, 5 };

        Solution sol = new Solution();

        var s = sol.solution(g, p);
        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
    }
}