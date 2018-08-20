//https://leetcode-cn.com/problems/nim-game/description/

public class NimGameDemo {
    public bool CanWinNim(int n) {
        return !(n % 4 == 0);
    }
}