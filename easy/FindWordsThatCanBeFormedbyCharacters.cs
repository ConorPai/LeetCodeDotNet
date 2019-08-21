//https://leetcode-cn.com/problems/find-words-that-can-be-formed-by-characters/

public class FindWordsThatCanBeFormedbyCharactersDemo {
    public int CountCharacters(string[] words, string chars) {
        int[] charsCount = new int[26];

        foreach (char c in chars.ToCharArray())
            charsCount[(int)c - (int)'a']++;

        int nTotalLength = 0;
        foreach (string s in words)
        {
            bool bFormed = true;
            int[] charsCountCopy = (int[])charsCount.Clone();
            foreach (char c in s.ToCharArray())
            {
                int nIndex = (int)c - (int)'a';
                if (charsCountCopy[nIndex] == 0)
                {
                    bFormed = false;
                    break;
                }

                charsCountCopy[nIndex]--;
            }

            if (bFormed)
                nTotalLength+= s.Length;
        }

        return nTotalLength;
    }
}