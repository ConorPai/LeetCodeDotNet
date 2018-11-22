//https://leetcode-cn.com/problems/convert-a-number-to-hexadecimal/

using System.Text;

public class ConvertaNumbertoHexadecimalDemo {

    private string[] m_charMap = {"0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f"};

    public string ToHex(int num) {
        
        if (num == 0)
            return "0";

        StringBuilder sbRet = new StringBuilder();
        while (num != 0 && sbRet.Length < 8)
        {
            sbRet.Insert(0, m_charMap[num & 15]);
            num = num >> 4;
        }

        return sbRet.ToString();
    }
}