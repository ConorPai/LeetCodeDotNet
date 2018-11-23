//https://leetcode-cn.com/problems/valid-mountain-array/

public class ValidMountainArrayDemo {
    public bool ValidMountainArray(int[] A) {
        if (A.Length < 3 || A[0] >= A[1])
            return false;
        
        bool bLeft = true;
        for (int i = 1; i < A.Length; i++)
        {
            if (bLeft)
            {
                if (A[i] == A[i - 1])
                    return false;
                else if (A[i] < A[i - 1])
                    bLeft = false;
            }
            else
            {
                if (A[i] >= A[i - 1])
                    return false;
            }
        }

        return !bLeft;
    }
}