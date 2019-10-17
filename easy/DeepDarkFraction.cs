//https://leetcode-cn.com/problems/deep-dark-fraction/

class DeepDarkFractionDemo {
    public int[] fraction(int[] cont) {
        int n = 1;
        int m = cont[cont.Length - 1];
        for (int i = cont.Length - 2; i >= 0; i--)
        {
            int temp = m;
            m = cont[i] * m + n;
            n = temp;
        }

        return new int[] { m, n };
    }
}