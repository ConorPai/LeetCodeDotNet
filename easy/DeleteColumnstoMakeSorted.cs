//https://leetcode-cn.com/problems/delete-columns-to-make-sorted/

public class DeleteColumnstoMakeSortedDemo {
    public int MinDeletionSize(string[] A) {
        int nTimes = 0;

        for (int i = 0; i < A[0].Length; i++)
        {
            for (int j = 0; j < A.Length - 1; j++)
            {
                if (A[j][i] > A[j + 1][i])
                {
                    nTimes++;
                    break;
                }
            }
        }

        return nTimes;
    }
}