//https://leetcode-cn.com/problems/compare-strings-by-frequency-of-the-smallest-character/

public class CompareStringsbyFrequencyoftheSmallestCharacterDemo {
    public int[] NumSmallerByFrequency(string[] queries, string[] words) {
        int[] wordsFreq = new int[words.Length];

        for(int i = 0; i < words.Length; i++)
            wordsFreq[i] = SmallerFrequency(words[i]);
        
        int[] nResult = new int[queries.Length];
        int nIndex = 0;
        foreach (string q in queries)
        {
            int qFreq = SmallerFrequency(q);
            foreach (int wf in wordsFreq)
            {
                if (qFreq < wf)
                    nResult[nIndex]++;
            }
            nIndex++;
        }

        return nResult;
    }

    private int SmallerFrequency(string s)
    {
        char[] cs = s.ToCharArray();

        char minChar = cs[0];
        int nFreq = 1;
        for (int i = 1; i < cs.Length; i++)
        {
            if (cs[i] < minChar)
            {
                minChar = cs[i];
                nFreq = 1;
            }
            else if (cs[i] == minChar)
                nFreq++;
        }

        return nFreq;
    }
}