using System;
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        return word == word.ToUpper() ||
               word == word.ToLower() ||
               (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower());
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.DetectCapitalUse("USA"));
        Console.WriteLine(solution.DetectCapitalUse("FlaG"));
        Console.WriteLine(solution.DetectCapitalUse("Google"));
        Console.WriteLine(solution.DetectCapitalUse("leetcode"));
        Console.WriteLine(solution.DetectCapitalUse("LeetCode"));
    }
}
