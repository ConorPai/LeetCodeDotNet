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

            int[,] island = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            IslandPerimeterDemo test3 = new IslandPerimeterDemo();
            Console.WriteLine(test3.IslandPerimeter(island).ToString());

            NextGreaterElementDemo test4 = new NextGreaterElementDemo();
            int[] nResult = test4.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });

            TreeNode root = new TreeNode(2147483647);
            root.left = new TreeNode(2147483647);
            root.right = new TreeNode(2147483647);
            AverageofLevelsinBinaryTreeDemo test5 = new AverageofLevelsinBinaryTreeDemo();
            IList<double> dResult = test5.AverageOfLevels(root);

            SingleNumberDemo test6 = new SingleNumberDemo();
            Console.WriteLine(test6.SingleNumber(new int[] { 17, 12, 5, -6, 12, 4, 17, -5, 2, -3, 2, 4, 5, 16, -3, -4, 15, 15, -4, -5, -6 }));

            HammingDistanceDemo test7 = new HammingDistanceDemo();
            Console.WriteLine(test7.HammingDistance(1, 16));

            MaxConsecutiveOnesDemo test8 = new MaxConsecutiveOnesDemo();
            Console.WriteLine(test8.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));

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
            IList<int> pResult11 = test11.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });


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

            ConstructtheRectangleDemo test16 = new ConstructtheRectangleDemo();
            int[] nRet16 = test16.ConstructRectangle(5);
            Console.WriteLine(nRet16[0].ToString() + "," + nRet16[1].ToString());

            int[] nNums171 = new int[] { 1, 2, 2, 1 };
            int[] nNums172 = new int[] { 2, 2 };
            IntersectionofTwoArraysDemo test17 = new IntersectionofTwoArraysDemo();
            int[] nRet17 = test17.Intersection(nNums171, nNums172);

            ExcelSheetColumnTitleDemo test18 = new ExcelSheetColumnTitleDemo();
            Console.WriteLine(test18.ConvertToTitle(27));

            ExcelSheetColumnNumberDemo test19 = new ExcelSheetColumnNumberDemo();
            Console.WriteLine(test19.TitleToNumber("AA").ToString());

            TreeNode root201 = new TreeNode(5);
            TreeNode left201 = new TreeNode(3);
            left201.left = new TreeNode(2);
            left201.right = new TreeNode(4);
            TreeNode right201 = new TreeNode(6);
            right201.right = new TreeNode(7);
            root201.left = left201;
            root201.right = right201;
            TreeNode root202 = new TreeNode(5);
            TreeNode left202 = new TreeNode(3);
            left202.left = new TreeNode(2);
            left202.right = new TreeNode(4);
            TreeNode right202 = new TreeNode(6);
            right202.right = new TreeNode(7);
            root202.left = left202;
            root202.right = right202;
            SameTreeDemo test20 = new SameTreeDemo();
            Console.WriteLine(test20.IsSameTree(root201, root202) ? "same tree" : "not same tree");

            TreeNode root21 = new TreeNode(3);
            TreeNode right21 = new TreeNode(20);
            right21.left = new TreeNode(15);
            right21.right = new TreeNode(7);
            root21.left = new TreeNode(9);
            root21.right = right21;
            SumofLeftLeavesDemo test21 = new SumofLeftLeavesDemo();
            Console.WriteLine(test21.SumOfLeftLeaves(root21).ToString());


            TreeNode root22 = new TreeNode(1);
            TreeNode left22 = new TreeNode(2);
            TreeNode right22 = new TreeNode(3);
            left22.left = new TreeNode(4);
            right22.left = new TreeNode(5);
            root22.left = left22;
            root22.right = right22;
            BinaryTreeTiltDemo test22 = new BinaryTreeTiltDemo();
            Console.WriteLine(test22.FindTilt(root22).ToString());

            TreeNode root23 = new TreeNode(1);
            TreeNode right23 = new TreeNode(3);
            right23.left = new TreeNode(2);
            root23.right = right23;
            MinimumAbsoluteDifferenceinBSTDemo test23 = new MinimumAbsoluteDifferenceinBSTDemo();
            Console.WriteLine(test23.GetMinimumDifference(root23));

            ValidAnagramDemo test24 = new ValidAnagramDemo();
            Console.WriteLine(test24.IsAnagram("anagram", "nagaram") ? "true" : "false");

            ContainsDuplicateDemo test25 = new ContainsDuplicateDemo();
            Console.WriteLine(test25.ContainsDuplicate(new int[] {3, 2, 5, 4, 3, 1, 6}) ? "true" : "false");

            IntersectionofTwoArraysIIDemo test26 = new IntersectionofTwoArraysIIDemo();
            //int[] nRes26 = test26.Intersect(nNums171, nNums172);

            DiameterofBinaryTreeDemo test27 = new DiameterofBinaryTreeDemo();
            Console.WriteLine(test27.DiameterOfBinaryTree(root23).ToString());

            TreeNode root28 = new TreeNode(3);
            TreeNode left28 = new TreeNode(4);
            TreeNode right28 = new TreeNode(5);
            left28.left = new TreeNode(1);
            left28.right = new TreeNode(1);
            root28.left = left28;
            root28.right = right28;
            SubtreeofAnotherTreeDemo test28 = new SubtreeofAnotherTreeDemo();
            Console.WriteLine(test28.IsSubtree(root28, left28) ? "true" : "false");

            BinaryTreeLevelOrderTraversalIIDemo test29 = new BinaryTreeLevelOrderTraversalIIDemo();
            IList<IList<int>> ret29 = test29.LevelOrderBottom(root28);

            PowerofTwoDemo test30 = new PowerofTwoDemo();
            Console.WriteLine(test30.IsPowerOfTwo(9) ? "true" : "false");

            PowerofThreeDemo test31 = new PowerofThreeDemo();
            Console.WriteLine(test31.IsPowerOfThree(9) ? "true" : "false");

            PowerofFourDemo test32 = new PowerofFourDemo();
            Console.WriteLine(test32.IsPowerOfFour(16) ? "true" : "false");

            SearchInsertPositionDemo test33 = new SearchInsertPositionDemo();
            Console.WriteLine(test33.SearchInsert(new int[]{1, 3, 6, 9}, 7).ToString());

            EncodeandDecodeTinyURLDemo test34 = new EncodeandDecodeTinyURLDemo();
            Console.WriteLine(test34.decode(test34.encode("http://leetcode.com")));

            FindPivotIndexDemo test35 = new FindPivotIndexDemo();
            Console.WriteLine(test35.PivotIndex(new int[]{-1,-1,-1,0,1,-1}).ToString());

            SelfDividingNumbersDemo test36 = new SelfDividingNumbersDemo();
            IList<int> ret36 = test36.SelfDividingNumbers(1, 22);

            TreeNode root37 = new TreeNode(1);
            root37.left = new TreeNode(2);
            root37.right = null;
            MinimumDepthofBinaryTreeDemo test37 = new MinimumDepthofBinaryTreeDemo();
            Console.WriteLine(test37.MinDepth(root37).ToString());

            NumberComplementDemo test38 = new NumberComplementDemo();
            Console.WriteLine(test38.FindComplement(5).ToString());

            KeyboardRowDemo test39 = new KeyboardRowDemo();
            Console.WriteLine(test39.FindWords(new string[]{"Hello", "Alaska", "Dad", "Peace"}).ToString());

            BinaryNumberwithAlternatingBitsDemo test40 = new BinaryNumberwithAlternatingBitsDemo();
            Console.WriteLine(test40.HasAlternatingBits(10).ToString());

            int[,] grid41 = new int[,] {{0,0,1,0,0,0,0,1,0,0,0,0,0},
                                        {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                        {0,1,1,0,1,0,0,0,0,0,0,0,0},
                                        {0,1,0,0,1,1,0,0,1,0,1,0,0},
                                        {0,1,0,0,1,1,0,0,1,1,1,0,0},
                                        {0,0,0,0,0,0,0,0,0,0,1,0,0},
                                        {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                        {0,0,0,0,0,0,0,1,1,0,0,0,0}};
            MaxAreaofIslandDemo test41 = new MaxAreaofIslandDemo();
            Console.WriteLine(test41.MaxAreaOfIsland(grid41).ToString());

            MoveZeroesDemo test42 = new MoveZeroesDemo();
            int[] nums42 = new int[] {0, 1, 0, 3, 12};
            test42.MoveZeroes(nums42);

            MissingNumberDemo test43 = new MissingNumberDemo();
            Console.WriteLine(test43.MissingNumber(new int[]{9,6,4,2,3,5,7,0,1}).ToString());

            ArrayPartitionIDemo test44 = new ArrayPartitionIDemo();
            Console.WriteLine(test44.ArrayPairSum(new int[]{1,4,3,2}).ToString());
        }
    }
}
