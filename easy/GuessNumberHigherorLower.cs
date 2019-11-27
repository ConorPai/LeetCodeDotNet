//https://leetcode-cn.com/problems/guess-number-higher-or-lower/

public class GuessGame {

    public int guess(int n) {
        return 1;
    }
}

public class GuessNumberHigherorLowerDemo : GuessGame {
    public int guessNumber(int n) {
        int low = 1;
        int high = n;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            int res = guess(mid);
            if (res == 0)
                return mid;
            else if (res < 0)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }
}