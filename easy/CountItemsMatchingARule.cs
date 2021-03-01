using System.Collections.Generic;

public class CountItemsMatchingARule {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int index = -1;
        if (ruleKey == "type")
            index = 0;
        else if (ruleKey == "color")
            index = 1;
        else if (ruleKey == "name")
            index = 2;

        if (index == -1)
            return 0;

        int nTotalCount = 0;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i][index] == ruleValue)
                nTotalCount++;
        }

        return nTotalCount;
    }
}