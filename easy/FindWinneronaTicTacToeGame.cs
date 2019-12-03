//https://leetcode-cn.com/problems/find-winner-on-a-tic-tac-toe-game/

public class FindWinneronaTicTacToeGameDemo {
    public string Tictactoe(int[][] moves) {

        int[][] Game = new int[][]{new int[]{-1,-1,-1},new int[]{-1,-1,-1},new int[]{-1,-1,-1}};

        for (int i = 0; i < moves.Length; i++)
        {
            Game[moves[i][0]][moves[i][1]] = i % 2 == 0 ? 0 : 1;

            if (i > 2)
            {
                if (Game[0][0] != -1 && Game[0][1] != -1 && Game[0][2] != -1 && Game[0][0] == Game[0][1] && Game[0][0] == Game[0][2])
                    return Game[0][0] == 0 ? "A" : "B";
                if (Game[1][0] != -1 && Game[1][1] != -1 && Game[1][2] != -1 && Game[1][0] == Game[1][1] && Game[1][0] == Game[1][2])
                    return Game[1][0] == 0 ? "A" : "B";
                if (Game[2][0] != -1 && Game[2][1] != -1 && Game[2][2] != -1 && Game[2][0] == Game[2][1] && Game[2][0] == Game[2][2])
                    return Game[2][0] == 0 ? "A" : "B";
                if (Game[0][0] != -1 && Game[1][0] != -1 && Game[2][0] != -1 && Game[0][0] == Game[1][0] && Game[0][0] == Game[2][0])
                    return Game[0][0] == 0 ? "A" : "B";
                if (Game[0][1] != -1 && Game[1][1] != -1 && Game[2][1] != -1 && Game[0][1] == Game[1][1] && Game[0][1] == Game[2][1])
                    return Game[0][1] == 0 ? "A" : "B";
                if (Game[0][2] != -1 && Game[1][2] != -1 && Game[2][2] != -1 && Game[0][2] == Game[1][2] && Game[0][2] == Game[2][2])
                    return Game[0][2] == 0 ? "A" : "B";
                if (Game[0][0] != -1 && Game[1][1] != -1 && Game[2][2] != -1 && Game[0][0] == Game[1][1] && Game[0][0] == Game[2][2])
                    return Game[0][0] == 0 ? "A" : "B";
                if (Game[0][2] != -1 && Game[1][1] != -1 && Game[2][0] != -1 && Game[0][2] == Game[1][1] && Game[0][2] == Game[2][0])
                    return Game[0][2] == 0 ? "A" : "B";
            }
        }

        if (moves.Length >= 9)
            return "Draw";
        
        return "Pending";
    }
}