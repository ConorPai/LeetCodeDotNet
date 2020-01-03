//https://leetcode-cn.com/problems/replace-elements-with-greatest-element-on-right-side/

public class ReplaceElementswithGreatestElementonRightSideDemo {
    public int[] ReplaceElements(int[] arr) {
        int[] nRet = new int[arr.Length];
        nRet[arr.Length - 1] = -1;

        for (int i = arr.Length - 2; i >= 0; i--)
            nRet[i] = arr[i + 1] > nRet[i + 1] ? arr[i + 1] : nRet[i + 1];
        
        return nRet;
    }
}