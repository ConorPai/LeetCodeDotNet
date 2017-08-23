using System;
using System.Collections.Generic;

public class FizzBuzzDemo {
    public IList<string> FizzBuzz(int n) {
        
        IList<string> sResult = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                sResult.Add("FizzBuzz");
            else if (i % 3 == 0 && i % 5 != 0)
                sResult.Add("Fizz");
            else if (i % 3 != 0 && i % 5 == 0)
                sResult.Add("Buzz");
            else
                sResult.Add(i.ToString());
        }

        return sResult;
    }
}