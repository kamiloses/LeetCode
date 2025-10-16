public class Solution{
public string LongestCommonPrefix(string[] strs) {
    if (strs == null || strs.Length == 0) return "";

    string currentPrefix = "";
    int maxLength = strs.Min(s => s.Length); 

    for (int i = 0; i < maxLength; i++) {
        char currentChar = strs[0][i];
        for (int j = 1; j < strs.Length; j++) {
            if (strs[j][i] != currentChar) {
                return currentPrefix; 
            }
        }
        currentPrefix += currentChar; 
    }

    return currentPrefix;
}

public static void Main(string[] args)
{
    var solution = new Solution();
   Console.WriteLine( solution.LongestCommonPrefix(new string[]{"flower","flow","flight"}));
}
}