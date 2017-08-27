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

            TreeNode root = new TreeNode(2147483647);
            root.left = new TreeNode(2147483647);
            root.right = new TreeNode(2147483647);
            AverageofLevelsinBinaryTreeDemo test5 = new AverageofLevelsinBinaryTreeDemo();
            IList<double> dResult = test5.AverageOfLevels(root);

            SingleNumberDemo test6 = new SingleNumberDemo();
            Console.WriteLine(test6.SingleNumber(new int[]{17,12,5,-6,12,4,17,-5,2,-3,2,4,5,16,-3,-4,15,15,-4,-5,-6}));

            HammingDistanceDemo test7 = new HammingDistanceDemo();
            Console.WriteLine(test7.HammingDistance(1, 16));

            MaxConsecutiveOnesDemo test8 = new MaxConsecutiveOnesDemo();
            Console.WriteLine(test8.FindMaxConsecutiveOnes(new int[]{1,1,0,1,1,1}));
            
            MaximumDepthofBinaryTreeDemo test9 = new MaximumDepthofBinaryTreeDemo();
            Console.WriteLine(test9.MaxDepth(root));
        }
    }
}
