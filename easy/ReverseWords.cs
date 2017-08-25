//https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
//https://leetcode.com/problems/reverse-string/description/

using System.Text;

public class ReverseWordsDemo {
    public string ReverseWords(string s) {
        
        string[] list = s.Split(' ');

        StringBuilder sb = new StringBuilder();
        for (int j = 0; j < list.Length; j++)
        {
            string str = list[j];
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            if (j != list.Length - 1)
                sb.Append(' ');
        }

        return sb.ToString();
    }
}