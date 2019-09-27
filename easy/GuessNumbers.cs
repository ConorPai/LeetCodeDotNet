//https://leetcode-cn.com/problems/guess-numbers/

public class GuessNumbersDemo {
    public int game(int[] guess, int[] answer) {
        int nCount = 0;
        
        for (int i = 0; i < 3; i++)
        {
            if (guess[i] == answer[i])
                nCount++;
        }
        
        return nCount;
    }
}