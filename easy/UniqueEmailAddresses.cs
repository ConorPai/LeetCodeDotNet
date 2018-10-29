//https://leetcode-cn.com/problems/unique-email-addresses/

using System.Collections.Generic;

public class UniqueEmailAddressesDemo {
    public int NumUniqueEmails(string[] emails) {
        List<string> listEmails = new List<string>();
        
        foreach (string e in emails)
        {
            string[] parts = e.Split('@');
            parts[0] = parts[0].Replace(".", "");
            string newEmail = parts[0].Substring(0, parts[0].IndexOf('+')) + "@" + parts[1];

            if (!listEmails.Contains(newEmail))
                listEmails.Add(newEmail);
        }

        return listEmails.Count;
    }
}