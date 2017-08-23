using System;

namespace dotnetcoreproject
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWordsDemo test1 = new ReverseWordsDemo();
            Console.WriteLine(test1.ReverseWords("Let's take LeetCode contest"));
        }
    }
}
