//https://leetcode-cn.com/problems/maximum-frequency-stack/description/

using System.Linq;
using System.Collections.Generic;

public class FreqStackDemo {

    Dictionary<int, List<int>> countValues = new Dictionary<int, List<int>>();
    Dictionary<int, int> freqCount = new Dictionary<int, int>();
    int topOfStack;

    public FreqStackDemo() {
        
    }
    
    public void Push(int x) {
        
        int nNewCount = 0;
        if (freqCount.ContainsKey(x))
            nNewCount = freqCount[x];
        
        nNewCount++;
        freqCount[x] = nNewCount;

        if (!countValues.ContainsKey(nNewCount))
        {
            countValues[nNewCount] = new List<int>();
            topOfStack = nNewCount;
        }

        countValues[nNewCount].Add(x);
    }
    
    public int Pop() {
        List<int> list = countValues[topOfStack];
        int nNum = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);

        if (list.Count == 0)
        {
            countValues.Remove(topOfStack);
            topOfStack--;
        }

        freqCount[nNum]--;

        return nNum;
    }
}