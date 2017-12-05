//https://leetcode.com/problems/move-zeroes/description/

public class MoveZeroesDemo {
    public void MoveZeroes(int[] nums) {
        
        int nLastNoneZeroIndex = -1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] != 0)
            {
                nLastNoneZeroIndex = i;
                break;
            }
        }

        if (nLastNoneZeroIndex == -1)
            return;
        
        for (int i = nLastNoneZeroIndex - 1; i >= 0; i--)
        {
            if (nums[i] == 0)
            {
                for (int j = i; j < nLastNoneZeroIndex; j++)
                {
                    nums[j] = nums[j + 1];
                }

                nums[nLastNoneZeroIndex] = 0;

                int nStart = nLastNoneZeroIndex - 1;
                nLastNoneZeroIndex = -1;
                for (int j = nStart; j >= 0; j--)
                {
                    if (nums[j] != 0)
                    {
                        nLastNoneZeroIndex = j;
                        break;
                    }
                }

                if (nLastNoneZeroIndex == -1)
                    return;
            }
        }
    }
}