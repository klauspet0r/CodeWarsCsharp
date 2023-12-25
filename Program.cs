


string[] input = new string[] {"tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"};
Console.WriteLine($"Output is: {LongestConsecutives.LongestConsec(input, 2)}");

public class LongestConsecutives 
{
    
    public static string[] LongestConsec(string[] strarr, int k) 
    { 
        string[] concatStrings = new string[strarr.Length];

        for (int i = 0; i < strarr.Length-1; i++)
        {
          concatStrings[0] = string.Join("", strarr[i] + strarr[i+1]);
        }

        foreach (var element in concatStrings)
        {
          
        }

        return concatStrings;
    }
}