//https://leetcode.com/problems/detect-capital/description/

public class DetectCapitalDemo {
    public bool DetectCapitalUse(string word) {
        
        int numUpper = 0;
        char[] words = word.ToCharArray();
        for (int i = 0; i < words.Length; i++)
            if (char.IsUpper(words[i]))
                numUpper++;
        if (numUpper == 1)
            return char.IsUpper(words[0]);
        return numUpper == 0 || numUpper == word.Length;
    }
}