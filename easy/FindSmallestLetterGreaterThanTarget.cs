//https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/

public class FindSmallestLetterGreaterThanTargetDemo {
    public char NextGreatestLetter(char[] letters, char target) {
        
        foreach (char c in letters)
        {
            if ((int)c > (int)target)
                return c;
        }

        return letters[0];
    }
}