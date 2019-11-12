//https://leetcode-cn.com/problems/cells-with-odd-values-in-a-matrix/

public class CellswithOddValuesinaMatrixDemo {
    public int OddCells(int n, int m, int[][] indices) {
        int[] arrayN = new int[n];
        int[] arrayM = new int[m];

        for(int i = 0; i < indices.Length; i++)
        {
        	arrayN[indices[i][0]]++;
        	arrayM[indices[i][1]]++;
        }
        int nCount = 0;
        for(int i = 0; i < n; i++)
        	for(int j = 0; j < m; j++)
            {
        		if((arrayN[i] + arrayM[j]) % 2 > 0)
        			nCount++;
        	}
        return nCount;
    }
}