//https://leetcode-cn.com/problems/di-string-match/

public class DIStringMatchDemo {
    public int[] DiStringMatch(string S) {
        char[] cs = S.ToCharArray();
        int[] ret = new int[S.Length + 1];
		int inc = 0;
        int dec = S.Length;
		for (int i = 0; i < S.Length; i++)
        {
			if (cs[i] == 'I')
				ret[i] = inc++;
			else
				ret[i] = dec--;
		}
		ret[S.Length] = inc;
		return ret;
    }
}