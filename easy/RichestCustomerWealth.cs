public class RichestCustomerWealth {
    public int MaximumWealth(int[][] accounts) {
        int nRet = 0;
        for (int i = 0; i < accounts.Length; i++){
            int nWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
                nWealth += accounts[i][j];

            if (nWealth > nRet)
                nRet = nWealth;
        }

        return nRet;
    }
}