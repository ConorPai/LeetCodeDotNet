using System;
using System.Collections.Generic;

namespace dotnetcoreproject
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWordsDemo test1 = new ReverseWordsDemo();
            Console.WriteLine(test1.ReverseWords("Let's take LeetCode contest"));

            FizzBuzzDemo test2 = new FizzBuzzDemo();
            IList<string> sResult = test2.FizzBuzz(15);

            int[,] island = new int[,]{{0,1,0,0},{1,1,1,0},{0,1,0,0},{1,1,0,0}};
            IslandPerimeterDemo test3 = new IslandPerimeterDemo();
            Console.WriteLine(test3.IslandPerimeter(island).ToString());

            NextGreaterElementDemo test4 = new NextGreaterElementDemo();
            int[] nResult = test4.NextGreaterElement(new int[]{4,1,2}, new int[]{1,3,4,2});
        }
    }
}
