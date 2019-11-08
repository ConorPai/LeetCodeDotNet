//https://leetcode-cn.com/problems/moving-stones-until-consecutive/

public class MovingStonesUntilConsecutiveDemo {
    public int[] NumMovesStones(int a, int b, int c) {
        int[] res = new int[2];
        int[] array = {a, b, c};
        System.Array.Sort(array);

        res[0] = (array[1] - array[0] == 1 ? 0 : 1) + (array[2] - array[1] == 1 ? 0 : 1);
        res[0] = (array[1] - array[0] == 2 || array[2] - array[1] == 2) ? 1 : res[0];
        res[1] = array[2] - array[0] - 2;

        return res;
    }
}