public class Solution
{
    public static int points(String[] games)
    {
        int result = 0;
        foreach (var game in games)
        {
            int[] scores = game.Split(":").Select(x => int.Parse(x)).ToArray();
            if (scores[0] > scores[1]) result += 3;
            else if (scores[0] == scores[1]) result += 1;
            else result += 0;
        }

        return result;
    }


    public static void Main(string[] args)
    {
        Object solution = new Solution();
        Console.WriteLine(points(new string[] { "3:1", "2:2", "0:1" }));
    }
}