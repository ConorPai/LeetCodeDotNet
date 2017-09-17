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

            TreeNode root10 = new TreeNode(4);
            TreeNode left10 = new TreeNode(2);
            left10.left = new TreeNode(1);
            left10.right = new TreeNode(3);
            TreeNode right10 = new TreeNode(7);
            right10.left = new TreeNode(6);
            right10.right = new TreeNode(9);
            root10.left = left10;
            root10.right = right10;
            InvertBinaryTreeDemo test10 = new InvertBinaryTreeDemo();
            TreeNode nodeResult10 = test10.InvertTree(root10);

            FindAllNumbersDisappearedinanArrayDemo test11 = new FindAllNumbersDisappearedinanArrayDemo();
            IList<int> pResult11 = test11.FindDisappearedNumbers(new int[] {4,3,2,7,8,2,3,1});


            TreeNode root12 = new TreeNode(5);
            TreeNode left12 = new TreeNode(3);
            left12.left = new TreeNode(2);
            left12.right = new TreeNode(4);
            TreeNode right12 = new TreeNode(6);
            right12.right = new TreeNode(7);
            root12.left = left12;
            root12.right = right12;

            TwoSumIVDemo test12 = new TwoSumIVDemo();
            Console.WriteLine(test12.FindTarget(root12, 9) ? "true" : "false");

            ConstructStringfromBinaryTreeDemo test13 = new ConstructStringfromBinaryTreeDemo();
            Console.WriteLine(test13.Tree2str(root12));

            ListNode curL1 = new ListNode(2);
            curL1.next = new ListNode(4);
            curL1.next.next = new ListNode(3);

            ListNode curL2 = new ListNode(5);
            curL2.next = new ListNode(6);
            curL2.next.next = new ListNode(4);
            AddTwoNumbersDemo test14 = new AddTwoNumbersDemo();
            ListNode rNode14 = test14.AddTwoNumbers(curL1, curL2);

            TreeNode root15 = new TreeNode(5);
            root15.left = new TreeNode(2);
            root15.right = new TreeNode(13);

            ConvertBSTtoGreaterTreeDemo test15 = new ConvertBSTtoGreaterTreeDemo();
            TreeNode ret15 = test15.convertBST(root15);
        }
    }
}
