//https://leetcode.com/problems/excel-sheet-column-title/description/

public class ExcelSheetColumnTitleDemo {
    public string ConvertToTitle(int n) {
        
        string res = "";
        while(n != 0) {
            char ch = (char)((n - 1) % 26 + 65);
            n = (n - 1) / 26;
            res = ch + res;
        }
        return res;
    }
}