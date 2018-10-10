//https://leetcode-cn.com/problems/reverse-only-letters/

public class ReverseOnlyLettersDemo {
    public string ReverseOnlyLetters(string S) {
        char[] arrayS = S.ToCharArray();

        char[] letters = new char[S.Length];

        int index = 0;
        for (int i = S.Length - 1; i >= 0; i--)
        {
            if (IsLetter(arrayS[i]))
                letters[index++] = arrayS[i];
        }

        index = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (!IsLetter(arrayS[i]))
                continue;

            arrayS[i] = letters[index++];
        }

        return new string(arrayS);
    }

    private bool IsLetter(char c)
    {
        int value = (int)c;
        return (value >= 65 && value <= 90) || (value >= 97 && value <= 122);
    }
}