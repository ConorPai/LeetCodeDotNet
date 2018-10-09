//https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards/

using System;

public class XofaKindinaDeckofCardsDemo {
    public bool HasGroupsSizeX(int[] deck) {
        int[] freq = new int[1000];
        
        foreach(int x in deck)
            freq[x]++;
        
        int gcd = 0;
        for(int i = 0; i < freq.Length; i++)
        {
            if(freq[i] == 0)
                continue;
            if(freq[i] == 1)
                return false;
            
            if(gcd == 0)
                gcd = freq[i];
            else
                gcd = GetGcd(gcd, freq[i]);
        }
        
        return gcd >= 2;  
    }

    public int GetGcd(int a, int b) {
        if (b == 0) {
            return a;
        }
        return GetGcd(b, a % b);
    }
}