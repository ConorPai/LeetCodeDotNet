//https://leetcode.com/problems/excel-sheet-column-number/description/

public class ExcelSheetColumnNumberDemo {
    public int TitleToNumber(string s) {
        int result = 0;
        char[] chars = s.ToCharArray();
        for(int i = 0 ; i < chars.Length; i++) {
            result = result * 26 + (chars[i] - 'A' + 1);
        }
        return result;
    }
}