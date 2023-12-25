


string[] input = new string[] {"tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"};
Console.WriteLine($"Output is: {LongestConsecutives.LongestConsec(input, 2)}");

public class LongestConsecutives 
{
    
    public static string LongestConsec(string[] strarr, int k) 
{ 
    if (k <= 0 || k > strarr.Length)
    {
        return "";
    }

    string[] concatStrings = new string[strarr.Length - k + 1];

    for (int i = 0; i <= strarr.Length - k; i++)
    {
        string concatenated = "";
        for (int j = 0; j < k; j++)
        {
            concatenated += strarr[i + j];
        }
        concatStrings[i] = concatenated;
    }

    int returnIndex = 0;

    for (int i = 1; i < concatStrings.Length; i++)
    {
        if (concatStrings[i].Length > concatStrings[returnIndex].Length)
        {
            returnIndex = i;
        }
    }

    return concatStrings[returnIndex];
}
}