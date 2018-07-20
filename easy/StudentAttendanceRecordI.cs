//https://leetcode-cn.com/problems/student-attendance-record-i/description/

public class StudentAttendanceRecordIDemo {
    public bool CheckRecord(string s) {

        if (s.Contains("LLL"))
            return false;
        
        bool bHasA = false;
        foreach (char c in s.ToCharArray())
        {
            if (c == 'A')
            {
                if (bHasA)
                    return false;
                else
                    bHasA = true;
            }
        }

        return true;
    }
}