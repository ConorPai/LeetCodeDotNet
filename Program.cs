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
            int[] nRes26 = test26.Intersect(new int[]{1, 2, 2, 1}, new int[]{2, 2});

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

            FindtheDifferenceDemo test45 = new FindtheDifferenceDemo();
            Console.WriteLine(test45.FindTheDifference("abcd", "abcde").ToString());

            DetectCapitalDemo test46 = new DetectCapitalDemo();
            
            
            TwoSumIIInputarrayissortedDemo test47 = new TwoSumIIInputarrayissortedDemo();
            int[] nRet47 = test47.TwoSum(new int[]{-1, 0}, -1);
            Console.WriteLine(nRet47[0].ToString() + "," + nRet47[1].ToString());

            AddDigitsDemo test48 = new AddDigitsDemo();
            Console.WriteLine(test48.AddDigits(38).ToString());

            MaximumProductofThreeNumbersDemo test49 = new MaximumProductofThreeNumbersDemo();
            Console.WriteLine(test49.MaximumProduct(new int[]{1,2,3,4}).ToString());

            TreeNode root50 = new TreeNode(2);
            root50.left = new TreeNode(2);
            root50.right = new TreeNode(5);
            root50.right.left = new TreeNode(5);
            root50.right.right = new TreeNode(7);
            SecondMinimumNodeInaBinaryTreeDemo test50 = new SecondMinimumNodeInaBinaryTreeDemo();
            Console.WriteLine(test50.FindSecondMinimumValue(root50).ToString());

            TreeNode root51 = new TreeNode(1);
            root51.left = new TreeNode(2);
            root51.right = new TreeNode(3);
            root51.left.right = new TreeNode(5);
            BinaryTreePathsDemo test51 = new BinaryTreePathsDemo();
            Console.WriteLine(test51.BinaryTreePaths(root51).ToString());

            StringCompressionDemo test52 = new StringCompressionDemo();
            Console.WriteLine(test52.Compress(new char[] {'a','a','b','b','c','c','c'}).ToString());

            RemoveElementDemo test53 = new RemoveElementDemo();
            Console.WriteLine(test53.RemoveElement(new int[]{2}, 3).ToString());

            ListNode curL541 = new ListNode(1);
            curL541.next = new ListNode(2);
            curL541.next.next = new ListNode(4);

            ListNode curL542 = new ListNode(1);
            curL542.next = new ListNode(3);
            curL542.next.next = new ListNode(4);
            MergeTwoSortedListsDemo test54 = new MergeTwoSortedListsDemo();
            ListNode lResult54 = test54.MergeTwoLists(curL541, curL542);

            SqrtXDemo test55 = new SqrtXDemo();
            Console.WriteLine(test55.MySqrt(8).ToString());

            FindAnagramMappingsDemo test56 = new FindAnagramMappingsDemo();
            int[] nResult56 = test56.AnagramMappings(new int[]{12, 28, 46, 32, 50}, new int[]{50, 12, 32, 46, 28});

            MergeSortedArrayDemo test57 = new MergeSortedArrayDemo();
            test57.Merge(new int[]{1, 3, 5, 6, 8, 10, 0, 0, 0, 0, 0, 0}, 6, new int[]{2, 4, 6, 7, 12, 13}, 6);

            ThirdMaximumNumberDemo test58 = new ThirdMaximumNumberDemo();
            Console.WriteLine(test58.ThirdMax(new int[]{2, 2, 3, 1}).ToString());

            ImplementstrStrDemo test59 = new ImplementstrStrDemo();
            Console.WriteLine(test59.StrStr("hello", "ll").ToString());

            LengthofLastWordDemo test60 = new LengthofLastWordDemo();
            Console.WriteLine(test60.lengthOfLastWord("a ").ToString());

            PlusOneDemo test61 = new PlusOneDemo();
            int[] nRet = test61.PlusOne(new int[]{9, 9, 9, 9, 9});

            CanPlaceFlowersDemo test62 = new CanPlaceFlowersDemo();
            test62.CanPlaceFlowers(new int[]{0, 0, 1, 0, 0, 0, 0, 1}, 2);

            ToeplitzMatrixDemo test63 = new ToeplitzMatrixDemo();
            bool bRet63 = test63.IsToeplitzMatrix(new int[,]{{1,2,3,4},{5,1,2,3},{9,5,1,2}});

            PerfectNumberDemo test64 = new PerfectNumberDemo();
            bool bRet64 = test64.CheckPerfectNumber(28);

            MinStack test65 = new MinStack();
            test65.Push(-2);
            test65.Push(0);
            test65.Push(-3);
            int nRet65 = test65.GetMin();
            nRet65 = test65.Top();
            test65.Pop();
            nRet65 = test65.GetMin();

            NumArray test66 = new NumArray(new int[]{-2, 0, 3, -5, 2, -1});
            int nRet66 = test66.SumRange(0, 2);
            nRet66 = test66.SumRange(2, 5);
            nRet66 = test66.SumRange(0, 5);

            JewelsandStonesDemo test67 = new JewelsandStonesDemo();
            Console.WriteLine(test67.NumJewelsInStones("aA", "aAAbbbb").ToString());

            RotateArrayDemo test68 = new RotateArrayDemo();
            test68.Rotate1(new int[]{1,2,3,4,5,6,7}, 3);

            LongestCommonPrefixDemo test69 = new LongestCommonPrefixDemo();
            Console.WriteLine(test69.LongestCommonPrefix(new string[]{"aac", "ab"}));

            PartitionLabelsDemo test70 = new PartitionLabelsDemo();
            IList<int> ret70 = test70.PartitionLabels("ababcbacadefegdehijhklij");

            SingleElementinaSortedArrayDemo test71 = new SingleElementinaSortedArrayDemo();
            Console.WriteLine(test71.SingleNonDuplicate(new int[]{1,1,2,3,3,4,4,8,8}).ToString());

            LetterCasePermutationDemo test72 = new LetterCasePermutationDemo();
            IList<string> ret72 = test72.LetterCasePermutation("a1b2");

            LargestNumberAtLeastTwiceofOthersDemo test73 = new LargestNumberAtLeastTwiceofOthersDemo();
            Console.WriteLine(test73.DominantIndex(new int[]{3, 6, 1, 0}).ToString());

            RotateStringDemo test74 = new RotateStringDemo();
            bool bRet74 = test74.RotateString("abcde", "cdeab");

            LongestWordinDictionaryDemo test75 = new LongestWordinDictionaryDemo();
            Console.WriteLine(test75.LongestWord(new string[]{"rac","rs","ra","on","r","otif","o","onpdu","rsf","rs","ot","oti","racy","onpd"}));

            FindSmallestLetterGreaterThanTargetDemo test76 = new FindSmallestLetterGreaterThanTargetDemo();
            Console.WriteLine(test76.NextGreatestLetter(new char[]{'c', 'f', 'j'}, 'd').ToString());

            RepeatedStringMatchDemo test77 = new RepeatedStringMatchDemo();
            Console.WriteLine(test77.RepeatedStringMatch("abcd", "cdabcdab").ToString());

            LongestHarmoniousSubsequenceDemo test78 = new LongestHarmoniousSubsequenceDemo();
            Console.WriteLine(test78.FindLHS(new int[]{1,2,3,3,1,-14,13,4}).ToString());

            ShortestUnsortedContinuousSubarrayDemo test79 = new ShortestUnsortedContinuousSubarrayDemo();
            Console.WriteLine(test79.FindUnsortedSubarray(new int[]{2, 4, 5, 8, 9, 10, 15}).ToString());

            Base7Demo test80 = new Base7Demo();
            Console.WriteLine(test80.ConvertToBase7(101));

            TreeNode root81 = new TreeNode(1);
            root81.left = new TreeNode(4);
            root81.right = new TreeNode(5);
            root81.left.left = new TreeNode(4);
            root81.left.right = new TreeNode(4);
            root81.right.right = new TreeNode(5);
            LongestUnivaluePathDemo test81 = new LongestUnivaluePathDemo();
            Console.WriteLine(test81.LongestUnivaluePath(root81).ToString());

            UniqueMorseCodeWordsDemo test82 = new UniqueMorseCodeWordsDemo();
            Console.WriteLine(test82.UniqueMorseRepresentations(new string[]{"gin", "zen", "gig", "msg"}).ToString());

            NumberofLinesToWriteStringDemo test83 = new NumberofLinesToWriteStringDemo();
            int[] ret83 = test83.NumberOfLines(new int[]{10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "abcdefghijklmnopqrstuvwxyz");

            MaxIncreasetoKeepCitySkylineDemo test84 = new MaxIncreasetoKeepCitySkylineDemo();
            Console.WriteLine(test84.MaxIncreaseKeepingSkyline(new int[4][]{new int[4]{3,0,8,4},new int[4]{2,4,5,7},new int[4]{9,2,6,3},new int[4]{0,3,1,0}}).ToString());

            MaximumAverageSubarrayIDemo test85 = new MaximumAverageSubarrayIDemo();
            Console.WriteLine(test85.FindMaxAverage(new int[]{1,12,-5,-6,50,3}, 4).ToString());

            AssignCookiesDemo test86 = new AssignCookiesDemo();
            Console.WriteLine(test86.FindContentChildren(new int[]{1,2,3}, new int[]{1,1}));

            SelfCrossingDemo test87 = new SelfCrossingDemo();
            Console.WriteLine(test87.IsSelfCrossing(new int[]{2, 1, 1, 2}).ToString());

            SubdomainVisitCountDemo test88 = new SubdomainVisitCountDemo();
            IList<string> ret88 = test88.SubdomainVisits(new string[]{"9001 discuss.leetcode.com"});

            int[,] value89 = new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            ImageSmootherDemo test89 = new ImageSmootherDemo();
            int[,] ret89 = test89.ImageSmoother(value89);

            SetMismatchDemo test90 = new SetMismatchDemo();
            int[] ret90 = test90.FindErrorNums(new int[]{9789,3596,5596,2037,7303,9763,3626,7077,1213,2292,8658,5968,2334,7708,2053,1891,8556,616,5159,4682,4642,6308,7628,7843,2660,9691,2488,6057,6952,3465,1443,7793,6979,9049,6165,7039,8901,2531,532,4512,7810,5769,3450,2880,4113,6487,6929,3668,414,4330,2405,9153,378,2149,461,6731,8948,4807,5952,3457,9734,1503,6348,2054,719,2852,3671,147,9986,1663,4874,6954,3116,4957,8292,7316,8054,8841,1729,4139,1204,129,3917,3659,35,8654,5091,822,7227,441,1240,4202,2201,3708,2739,9004,2843,7560,7464,3888,9892,6108,5967,238,9382,9629,2091,2585,3302,9419,3811,1583,34,2566,5172,763,1952,6693,8761,3213,1761,1502,3997,4078,5421,32,3199,4804,1437,2107,2186,2802,6384,9652,1827,1142,5510,8619,6127,8301,1129,8877,6834,9311,6795,9544,2716,1838,9105,4442,7620,8395,3296,8740,7219,4569,5291,5582,6013,9304,8210,687,591,5109,6190,1064,6325,1133,1988,5227,61,7244,5216,8982,9265,335,5472,4219,2733,6882,5001,8078,2391,2847,2174,5925,7838,8545,5739,3746,945,9825,1921,4102,789,9496,8860,2283,407,2229,5783,7042,371,7305,7975,8188,6196,7121,1320,8647,4008,56,5528,8628,9556,6733,4977,6816,3402,8787,4723,1177,7974,1893,2029,3905,9104,5380,2304,2581,9276,7497,5654,9269,2518,8812,6708,7189,1054,8090,3152,3707,1481,2529,135,9925,2883,6946,2116,7396,6386,1226,546,3833,7443,442,8272,7768,5393,8694,4910,5859,7619,3089,9667,2097,145,3427,4234,2458,4982,2153,4047,1401,7911,4521,8025,5036,3460,4850,7773,2970,6223,2295,1996,4207,4201,7503,2247,5504,1741,4878,2849,4344,2138,6101,3601,9469,8271,5396,2300,635,9822,4989,4597,3496,5212,2619,573,3566,8079,429,8072,5219,1946,6866,355,1101,460,2671,1380,7934,9509,3884,4192,9688,5276,7771,3128,245,7999,1412,7,5485,9861,2231,6167,3282,1597,7249,1447,3257,421,5760,5819,1860,6988,9950,2693,9193,7691,9335,1402,5963,2272,785,6697,8514,6315,883,228,286,3738,7876,3564,3886,3068,9234,8621,770,6698,7567,7612,3986,1388,4611,5271,4549,7356,406,469,8522,3818,6115,8160,554,1281,8088,3322,9133,2551,2895,4509,5972,3863,159,4925,9606,475,5740,4585,51,2933,2204,133,6749,1409,3504,7051,2258,3335,9895,5411,7897,7745,7645,8496,8364,3029,3689,8095,4327,5706,7614,9642,1428,6114,5029,5456,6986,1888,6803,3106,574,7429,4747,1333,7196,1293,5030,7208,9453,741,7091,4018,2863,53,2562,3800,6601,638,3749,1036,6823,7657,7256,5882,2884,2109,6168,5012,8589,5646,3653,9959,7006,8006,7988,4620,523,7403,8593,4036,9824,588,9328,4292,4037,558,1784,4016,586,545,7832,7546,4594,5662,1818,1180,2040,3256,72,2241,7298,7352,9330,3333,6479,3391,4877,710,6166,7084,4304,1190,564,4887,2386,7997,8793,614,9009,793,8971,2422,3553,1151,9646,6940,4787,4387,4644,3785,4926,4745,6382,5641,7104,3401,5300,6677,9655,9285,8540,4537,4687,7683,9274,3591,997,3945,3331,7662,7442,8049,5106,8871,6338,7845,7972,330,6270,3433,9240,6321,7376,7157,2909,18,3142,5173,8487,4767,1062,9100,3305,2367,6919,5843,2460,8531,8499,904,5703,8341,1390,2445,3891,7579,6502,2781,9401,4259,514,7015,7621,2737,2122,7348,3522,2120,512,5105,3419,5278,1537,7254,8846,4983,6304,4232,1843,7518,6632,8893,6445,9785,5073,9783,2397,6761,9526,1810,4561,1731,575,3918,6976,5027,5438,4772,2240,2984,8019,9203,7300,3975,9527,6281,4492,4519,1408,6500,7512,5837,6239,2198,3275,2341,5452,7615,9381,736,8533,7251,9432,6475,7688,2155,1382,3797,1930,8355,3817,8131,8415,5903,2757,8945,6805,3247,2070,6621,1216,9668,7270,7747,9321,1966,2443,6238,695,3926,9905,5686,5155,5661,6837,9172,3657,1979,4705,2927,3628,3306,3066,2408,529,8894,8321,4740,4416,8738,7102,3166,3767,3237,7738,541,6839,552,8662,3188,3701,948,3631,8766,6097,4351,6595,888,6984,9248,8904,707,1806,7704,9670,6531,1495,153,8744,3636,4465,9268,1733,766,5787,2993,2996,9833,6872,4990,5207,2347,9183,6195,3666,3793,6350,4694,864,9254,9508,2997,7659,6504,2839,2126,4550,7019,5214,727,108,8577,8636,1125,9322,8992,3415,5572,4215,4811,5578,3941,8221,9142,5288,50,4601,437,7358,1755,3294,9814,8668,4147,280,5650,611,9774,1473,6040,9054,4636,8970,8974,4458,3422,9283,237,6355,7366,5192,4001,9643,7881,3352,807,2549,8096,2022,6840,2684,585,5697,9490,9682,5297,9524,2507,6021,9638,8656,8105,5419,9538,2723,2072,2490,1878,7840,7631,6540,5902,1043,6513,7430,8586,7134,201,6079,8070,2575,178,4309,9932,8771,820,4464,8580,6465,1584,2841,1509,1963,5951,9818,9709,1546,5585,3330,5242,8406,7678,7446,9429,7178,7553,6653,9705,2006,7075,506,6439,3607,4118,8827,3394,9,4901,4525,134,9279,9178,4500,4414,1088,8112,5258,2308,8494,6095,7374,6962,1018,9504,9727,8405,4728,8453,9225,7912,8810,4699,43,8804,9953,1774,3314,9776,3182,8794,6880,1306,1657,5622,1772,2617,9440,6636,5205,6619,4503,9523,2659,1288,6875,7350,7622,2542,2263,513,4633,1619,2444,5946,610,8696,1158,7915,4386,3018,6363,5023,474,8148,7078,5773,4418,1776,6599,9390,3715,850,4392,2756,9033,7755,5526,2589,7388,8056,1737,299,686,4992,2038,6572,992,3361,6175,5645,8017,3635,566,225,1433,9280,5720,4089,4532,358,2898,1263,2235,2134,1001,6544,279,801,3573,1465,4141,2061,3992,8319,4480,8287,2191,9752,8912,7870,2718,4279,4935,2449,1641,6235,1744,609,8777,4949,5840,7716,1135,2510,4211,379,1231,3506,8359,8840,3491,9975,8692,9995,2251,4457,1676,9658,2580,4860,9037,3372,5230,1592,9694,5790,5413,3954,3529,8062,6729,4864,5656,4195,9851,9718,3770,2954,1553,8772,8952,329,8464,9935,4320,493,388,3399,4780,6515,4823,5176,5561,1874,9310,4716,1057,9187,1514,3240,9223,2788,714,7004,6272,9224,7277,87,7670,2911,3312,954,5038,8736,2227,2401,1017,1492,3409,7406,9634,2955,2309,6117,2565,8935,8026,3217,4566,6959,9174,6785,5743,2257,1858,5696,9807,5601,8602,6000,193,4856,6926,3136,6732,5044,4224,658,477,3281,7956,5237,1549,16,8149,9228,6903,7505,1794,8340,1398,423,2932,4567,3475
            ,3808,1470,3268,81,1642,8068,9800,9816,4810,6849,7183,2564,7228,9249,2578,2019,6076,4052,2110,9343,1892,3072,7982,8799,7658,4679,8085,3250,3234,8334,313,340,2848,2519,6447,2111,4353,97,9227,1360,7807,7647,8719,8503,749,6126,3435,9626,5907,2870,1491,8969,3869,2160,2017,8310,5303,4698,4862,1153,8897,6422,2226,5157,884,1393,8534,3249,3664,3642,1522,4290,4743,8519,2159,2190,1073,5672,631,6888,4126,9746,9729,5190,5982,64,6061,7494,6296,8870,7559,7327,243,311,5252,3270,4703,4125,7767,9408,2462,4334,1370,1149,7400,8880,7914,8108,7787,2876,4135,7984,9945,5035,5794,4819,3878,4578,583,2358,3071,2092,9416,3095,1699,999,8611,4675,6007,8675,2114,5162,1870,9070,4928,7653,11,1268,8249,8465,1709,5328,5259,7106,8691,5995,8145,6846,5165,8381,6336,4769,2629,3627,4264,9361,3541,5125,1730,3452,6829,1309,7360,8926,416,4952,6714,3568,2708,3813,4487,7499,4406,2421,8099,5311,4237,5161,3437,5506,9541,3777,1710,5758,3221,4138,3336,9767,6943,4410,600,8267,7958,274,5970,5067,892,3901,6066,7293,1881,5664,2812,158,6334,694,6723,761,5245,8924,9546,3968,6624,7296,1510,5848,1042,5233,4641,9846,6480,4941,4021,6511,3274,5766,7785,7120,6409,9666,2545,7705,6002,4523,4346,5607,4615,39,9383,4315,2013,7182,9273,4622,2881,3061,1607,2327,1346,4399,6015,2332,434,9830,5454,6649,8083,4258,260,7166,2217,1947,9723,170,1847,6155,5550,1556,9005,5648,109,5056,381,6352,7410,9253,5352,3667,4054,8498,6014,2270,6074,3778,7756,215,2406,5797,9997,8435,1267,6573,3969,2503,7669,756,2672,4178,3543,2101,3487,8591,6852,7175,7355,9614,9491,8493,744,8940,7732,5749,8003,267,6783,1636,6633,7726,6062,959,2078,1747,4531,8220,500,5802,8625,1688,4659,2075,7666,5737,1300,5491,8667,8525,6734,3299,8911,9923,2924,5652,6947,7253,5573,2624,682,5768,7833,1372,8244,4347,5586,2399,4962,6885,8751,6362,5831,9073,5803,7493,2521,7127,7234,8734,5059,55,9968,6,9340,6904,5217,3324,3881,6094,5034,2573,3376,6011,1903,9823,6848,8000,146,4299,5361,4429,6537,5007,1143,9414,5771,6119,86,9349,2918,6192,1414,9680,5138,4751,3467,2706,8957,6234,131,5467,5552,229,1962,4438,9963,6618,3208,1974,4403,3618,4441,2026,759,8035,9908,8853,203,9580,7212,6231,2707,9659,696,6876,4781,7932,9697,651,6985,1282,745,6726,5663,1367,3432,6287,5055,988,9082,2468,8865,5354,2824,5369,2729,9192,220,9826,9693,2416,8648,4282,141,3858,6450,6230,6326,2192,7941,738,1286,8224,9319,3426,9484,2937,3751,2289,6722,255,3961,4624,973,1929,9711,8330,2861,7537,4583,2466,1474,604,4602,1488,9868,6608,282,4057,2574,9474,481,395,2854,116,4961,844,2287,8258,2335,7680,7530,7385,6413,8443,9449,8212,637,5386,7684,9221,2456,1025,2370,6229,2978,9458,1866,6793,2127,8261,5143,6508,9662,3390,4548,1677,5608,9946,4269,1505,8979,1484,4640,3805,8685,5152,5043,579,7484,3393,9877,2930,6912,1026,9609,3703,6878,3822,7888,6578,7491,8752,2840,9904,4577,2537,2516,7517,1813,9091,2894,2033,7596,6328,3276,7613,3480,160,7052,5026,4827,4570,6740,5567,1981,6030,567,815,8040,1475,5319,8323,8084,5612,3261,8469,9399,1768,2795,3228,842,698,605,1461,2992,6977,8124,1031,8641,4632,1169,2931,4940,2833,9842,3725,2459,4559,5032,354,3494,8560,1139,7137,269,517,2027,9299,7835,8800,9735,9488,3721,102,2823,8109,7558,1379,2224,2832,673,4991,6526,2506,6522,7338,8629,8383,562,2171,1252,7883,2758,1508,9620,1859,5930,4287,5088,75,538,6927,9847,4284,2273,7924,854,8635,7874,3194,1236,675,2885,6814,1069,4205,900,1391,9515,2470,4446,9323,5334,5170,1483,7380,2544,4281,9689,5457,6658,9699,6739,856,3195,909,4163,9260,6488,8513,1707,167,7405,5374,708,6143,4302,4473,8762,5047,7370,3092,825,6855,5084,5068,7797,7067,8947,9477,2514,7187,5372,3915,6318,9831,6123,8816,4463,9549,7016,7186,8705,3087,3698,230,8500,1899,8470,3679,7326,3220,2543,6051,8151,4635,2736,7601,3716,3155,6205,8076,4456,1384,612,1750,946,5215,8386,7462,5587,5712,4671,9712,9726,6436,8113,7445,6503,4388,2128,2330,2056,8873,4515,1228,4876,7357,5944,3076,1438,2385,6702,3550,1250,1940,2135,17,1646,867,936,5410,6756,4093,8384,6346,8506,6147,3510,1680,4311,26,9316,3536,9949,4482,8200,7791,9028,8684,4142,2004,8783,2389,6248,3923,4145,6896,4959,9447,8407,9555,1211,6553,7144,5555,3625,8098,8728,3004,1832,4625,3119,8277,4773,2606,7762,5860,9928,6122,2963,2157,6560,8446,1973,6216,9909,5788,4835,4715,7325,9362,8672,7547,195,3266,172,6566,6631,3498,6887,4869,9584,1708,7262,3630,3346,5875,4576,9215,8102,6247,5199,7950,1389,1330,2372,8420,8177,5397,7188,6295,2584,8053,4357,119,5060,5210,6955,1364,3193,6865,100,4753,5989,8930,3603,6416,2282,7145,8921,8357,848,80,6340,1424,3103,9579,3726,2508,875,1935,1500,5279,9159,5854,5888,5746,304,3149,548,6581,168,7806,8425,4757,5782,2163,9536,9387,8153,5355,9061,5628,8688,4647,1303,1507,618,8700,4517,9880,8528,438,8134,5592,6493,1116,8715,8320,9101,1951,2657,9598,3062,494,425,2576,6215,196,3293,6684,8222,2477,3499,8546,8288,8595,5260,1229,2704,2212,8050,1206,8673,9072,3098,5070,47,8936,4714,9660,8092,9115,6211,5687,6993,7802,5887,5670,1016,2752,6322,3756,1486,9242,8353,1675,6365,2242,4933,8225,5974,6661,368,7871,5806,3219,1712,4368,6183,185,8639,5924,9430,9721,8462,597,4437,2698,6627,1164,3784,6414,8791,550,4124,1617,962,5900,5834,8028,8314,7159,2046,6351,9753,8702,5651,6088,3508,3229,8869,3248,5516,2435,3542,7206,5076,4272,4707,4912,424,9358,7304,2988,2357,2670,9149,5599,3356,7059,8423,5623,1278,1816,3696,6443,6915,155,5412,4661,362,9406,7991,1561,1015,7346,1136,6935,7050,6528,3662,3085,4350,5609,2161,4828,2896,1422,636,8866,9344,6505,2236,1214,3181,4580,1912,7637,692,4600,9418,6284,377,1517,2864,1172,3417,4813,671,9069,5392,5037,3692,2786,4297,9113,8708,8397,2560,5792,5576,7830,2690,5476,3431,8575,4826,492,3028,6534,3396,9651,9290,8185,5732
            ,8133,2628,5880,7700,9916,7264,9363,6998,6519,464,8831,8848,2213,8291,7334,7435,8727,1568,2745,7735,5595,5856,6454,2158,871,3311,4349,9513,7312,3977,9452,1055,9841,6651,9535,2611,7306,5348,8932,6524,1023,9858,6305,6337,1938,693,4929,7140,7339,2957,7024,6361,3286,7371,6891,6405,6507,7962,9450,659,1184,2774,9176,7805,2352,8130,9395,9038,7543,1120,5018,8584,6652,9300,6687,8916,6301,7654,4491,3794,879,2640,4024,4314,8255,9859,3434,9191,901,5274,9768,3375,6809,2850,3005,3012,931,7676,6717,6200,7713,1690,5870,5211,7821,4904,4244,9053,2770,7719,630,9760,5864,3780,2063,7307,8547,5839,5186,7839,8432,453,7711,4794,4452,4323,6314,4072,4007,9019,2771,8300,7454,1014,702,2607,7359,5512,8986,6269,1152,117,8706,6329,3272,5559,1237,2143,3366,6236,1464,4760,9426,2424,3246,622,5494,8203,762,8703,6245,369,8978,2721,4648,4664,5415,8490,9346,4066,4265,8451,8043,3412,5028,6780,6981,1002,8524,9360,169,9799,3184,9632,28,3167,6342,3326,6884,7468,7318,2223,4742,4059,723,5581,9164,7413,9237,3647,5799,2759,6582,6163,1093,7115,9094,4144,8537,2230,4407,8303,3951,4956,8892,2005,7237,9006,7846,8356,874,7750,5889,9972,3385,6467,7431,5736,4958,6821,9573,7812,9278,5680,99,3563,8195,5548,7057,6626,7589,9190,4582,3254,1440,8238,8965,1163,2612,773,6799,1580,4182,2986,6857,1759,6782,7551,6989,2261,9111,7440,4691,8555,8717,1056,2368,8315,7828,4459,8322,5544,2052,4501,2438,4343,1477,2572,9282,3757,5469,2862,2069,4069,2985,9981,2595,4294,8162,391,364,9365,6656,6765,5942,6432,5160,316,3307,3105,9492,6745,4727,7873,8037,4143,9331,2590,9239,4384,7587,4806,5682,3772,4999,111,2197,2047,2961,4348,46,2676,7983,3146,5810,1598,132,1687,4328,3258,7949,6925,5054,1748,1421,620,9301,9782,3650,352,5583,7634,2842,3641,7231,5263,4371,191,769,3387,6937,5969,3197,3712,6056,4690,7275,6071,2692,9384,812,1121,4643,5615,281,780,9872,7422,1567,2681,6452,3548,4875,9118,8118,2705,657,6241,2724,2051,3042,9920,9715,684,6268,4774,10000,3223,6559,3720,663,3139,7123,3828,4557,7660,4669,162,2210,9951,8030,1638,6742,3358,2083,184,7853,3079,3348,4871,8468,3623,4071,621,1496,6748,9566,373,3418,9016,1765,4993,4574,7667,5502,6968,7094,4915,4447,394,9092,1497,6069,497,8723,1171,3867,4755,8409,411,180,4131,4584,1868,5879,1185,3395,7576,3439,2254,6520,6370,6438,9869,37,2540,3241,8327,2680,2777,9710,5701,5253,2090,4193,291,6176,9433,857,5284,9977,8836,7864,8669,6773,1191,853,9702,7363,9145,594,2765,3461,1756,6838,5826,360,5277,1980,8830,4477,4978,8955,8954,2686,8785,4338,4050,2667,1591,8821,7967,6104,5195,6859,989,1844,4172,2796,3594,4150,3629,8457,9956,6713,5131,7472,2615,5694,4481,7819,4209,4934,8964,4428,4711,9500,3313,9501,607,3673,3405,1038,6473,3587,9020,4598,7954,436,8598,2853,4906,7753,9891,7868,3613,3255,5873,4013,9533,383,926,7009,3605,5318,4010,6160,2338,2586,4379,5132,1386,4271,9355,2808,3384,2094,852,7607,8835,8988,211,5390,4608,669,1383,1420,8211,4362,1548,5639,3820,4185,4305,7068,5148,1606,9160,3848,2333,4312,7931,6286,4539,5296,2177,9530,1533,8507,3572,9090,7775,3581,6474,6103,1348,5407,9506,5832,8190,3151,6730,482,6644,7748,4023,283,6102,5884,9220,8699,8993,1407,7681,9531,7850,4243,2614,985,4370,6017,9653,209,7176,8176,5807,9885,8769,9813,5729,4220,2966,3175,3837,9883,5518,1735,6762,6063,9886,2642,6657,9161,5191,665,4984,1225,5489,5809,2950,5149,7246,6387,5920,8154,8768,2740,6120,1097,9425,5509,1950,2695,5398,2946,6864,499,7989,7060,9679,7896,161,7089,4245,3451,6078,7271,7990,9516,7118,3824,6390,236,887,7143,349,9961,8398,6918,2805,3446,4174,2717,726,8474,5266,800,256,1006,8786,8132,2714,2419,7124,6177,2041,1914,5921,3728,7335,1989,5074,9186,4326,3965,4604,9663,5725,6023,4233,6930,2666,40,4673,6757,9245,1573,539,6379,1230,151,7421,7575,7048,7939,8184,5643,9843,105,7506,3488,3889,5692,2928,1673,7861,4,8265,5874,9294,5061,2697,7916,6772,7727,9647,814,7272,3253,5867,4678,6886,6417,4649,5933,9238,4610,8609,3871,68,9965,6212,2123,5971,1175,7378,4847,1365,2398,1536,4194,507,3058,8828,1071,2761,7586,2344,1350,1181,2249,9618,3819,6055,9828,5111,9117,9766,633,3530,1217,666,5660,1253,6556,6609,7661,2403,2168,3392,7373,8797,2306,8712,8309,2638,2975,9334,4085,2365,5130,9206,9808,2914,8031,1770,9845,2489,1146,8698,8803,3516,5095,8071,5158,6395,1836,1328,9840,3041,2147,4528,6133,6543,6819,4965,3638,2020,4112,4342,524,5146,4417,6333,6242,483,3877,3338,5890,9015,4248,7699,4076,2696,8950,7722,44,4218,214,7847,7381,1200,7720,3579,4744,4653,7740,2990,7584,9849,7643,6813,2725,1114,5175,9993,2436,4702,5861,4275,4369,9205,6994,6854,8263,4385,2558,9487,798,1060,4162,3752,7629,1108,3190,4734,9495,5814,2772,6289,8169,5800,7153,1905,4524,4494,6845,7642,8561,3683,747,859,5563,5681,535,957,8013,5322,4556,1247,4654,869,7191,6004,9829,8417,188,8678,6966,8931,6455,9157,7535,8735,8670,9140,8337,9631,1329,1582,8394,1993,2768,6393,7554,3909,6741,7893,6140,41,8664,2021,1850,6324,3203,7132,4151,4155,6755,5669,4470,1406,8295,6751,4086,6833,9467,8764,8886,3242,322,6121,8649,9075,3424,2395,4216,2265,2603,4341,9085,2315,4891,775,4846,1581,7163,4479,1077,3019,3122,3138,5980,5916,2093,5939,2735,149,7936,4475,6972,2875,1435,6506,3141,3218,7450,1777,4903,4568,8343,8400,6048,2314,8530,344,8209,3345,8060,2384,3535,6807,5990,8615,7650,5647,1212,3731,7142,4434,9235,3125,8721,1258,8020,3670,5594,5987,5835,9131,1110,3444,721,5553,3472,990,1453,2420,6974,4411,1246,504,2393,7308,3006,5051,1434,4035,1975,3055,6672,1090,7328,4830,5417,5466,9046,272,5201,1235,8837,1448,8858,7055,8428,1311,7295,186,2244,7571,3989,1997,8876,3758,1831,4133,4149,5188,49,905,7012,2688,956,9244,6005,5638,3008,4070,7856,4888,7672,5229,1013,9921,7824,3187,3892,3875,8410,758,5631,5102,
            7314,9676,6944,3263,2874,4886,5200,5756,5958,8495,7073,9489,6483,1452,3852,7439,2058,7071,8755,1113,717,7283,2900,5448,8437,3283,752,7180,7540,7693,1839,3540,5849,5954,4892,5863,7519,2851,2836,7245,5221,6760,8741,8501,8373,4056,3760,8645,1208,3455,7099,1515,2448,1978,14,3084,5731,5545,6720,5590,3842,5535,9027,1207,7222,6700,5099,9347,7310,2137,2626,1294,9114,8663,9434,3238,8943,7466,640,7331,6274,6586,4759,4116,8627,7248,302,8117,2926,2170,5083,3034,2838,578,408,271,6498,1427,1506,23,9769,2594,1757,6371,5280,6893,7011,6567,7627,6430,921,8371,7002,2452,2008,9894,1095,8745,9779,386,7058,9169,250,5997,8438,984,2917,6797,1127,3414,914,8163,9704,1028,712,3082,3173,5927,6802,2600,5929,1745,3278,8051,7473,1552,5565,536,4191,126,4655,7882,5695,208,7831,5078,9775,7110,3846,4979,227,2942,8864,6462,5107,3123,8637,399,3321,6897,8329,5975,7420,6769,9587,8538,5774,9586,1713,9778,4808,4293,8042,2081,9708,9392,2353,1960,4801,8009,5039,7960,3134,7729,3479,3158,8036,418,4310,2597,4820,8366,6228,8709,1325,2371,221,2623,5493,9749,2467,8335,3761,9720,540,5534,4161,8730,5657,4032,5371,4660,4088,947,8057,8574,6290,4954,6615,4966,7848,7857,7534,6032,7463,2533,6001,3936,821,8549,6477,5184,5905,6035,6676,2280,2414,6810,6790,6476,8898,4488,7625,2658,8073,4612,3484,4914,1141,9742,7919,6410,5342,5828,516,7155,5761,2407,1534,2601,5591,5391,3059,9896,4105,3374,9645,9540,348,9329,7998,577,4884,6580,289,6171,4413,1376,4345,7041,4158,6643,7465,4200,366,1821,4885,3355,6547,701,7696,3658,6244,4251,370,8365,85,7432,1621,5470,9805,8247,6817,219,1284,472,4291,6179,156,4513,6688,2784,2219,9941,5394,3303,297,6016,9593,1074,9561,9122,6778,152,9960,1807,9542,967,6292,8080,3440,82,3825,7235,5270,7241,5616,7151,2278,277,7005,2944,6022,6250,8422,1117,7539,1848,2001,5368,7490,3859,5909,3836,6545,5488,2620,2959,7891,4863,893,6824,9907,6402,813,4022,9973,8011,5429,4668,576,2323,2650,125,8196,8116,3745,9462,974,1697,9359,899,1355,5723,754,9200,6464,70,8008,1939,7203,6728,7173,742,403,8854,1285,7211,4423,8275,8486,1782,2826,6557,4289,9108,951,9677,8814,1906,5462,2504,2188,891,6616,7285,2956,2919,2828,700,4208,5209,6842,1358,6933,1449,217,5312,5264,8429,7526,3879,9179,3952,448,7179,2821,8855,5289,2465,9844,6600,1615,5755,5041,2746,1432,7021,63,5634,8165,9539,1463,5912,8671,4646,1378,7114,6711,8282,7968,9671,6028,3308,4586,7126,2873,1835,5000,3204,6073,177,7692,6530,7193,4355,6481,8477,9690,2316,4997,3171,9055,5442,9571,1797,6031,9558,6701,4029,1749,7000,862,5750,1931,8710,9576,3976,1829,4119,8146,7369,601,6306,6660,6232,1686,3235,2428,3665,263,526,426,2711,8608,5636,4796,1845,1651,1990,1985,2567,4741,1404,8905,3998,2899,8553,1884,9503,667,9320,774,2196,781,5571,2018,9803,479,734,1634,9375,1255,949,2989,5495,5708,3801,4951,7195,2183,978,5668,6532,7784,7731,7792,189,3958,6699,4253,5747,5598,1527,6146,9156,1260,1220,2991,6970,7336,242,9403,9681,2364,720,1193,7557,5377,9644,6284,9821,2294,1945,8087,6456,9890,9870,9352,5164,3469,7884,6401,5931,6142,6987,4684,5299,975,7129,5065,9585,3001,9485,2703,9795,1066,6675,5218,7146,1012,771,8138,4579,8516,7395,3932,6892,8347,9325,4288,8379,8760,941,885,4120,2087,2176,4226,9292,1948,2100,7101,2865,7332,2999,6596,1351,8548,5486,6466,3849,8324,2180,7816,2971,1326,6313,9893,4499,3421,4498,240,8788,6394,1696,2778,1614,9601,1788,2264,4028,1916,6867,8481,2050,5824,9182,7496,5409,9617,1337,3940,5764,5185,5674,9522,6576,2815,4250,4843,4055,38,2783,5945,7664,4768,2439,251,8273,2082,5416,3981,7701,6969,8544,9065,7577,1490,1385,4725,4034,4865,1795,2655,2785,828,8958,2396,9218,3090,9719,5255,2,1194,7162,361,7565,1415,2485,8806,3201,1109,2080,3022,6922,7090,5367,7860,1418,5231,1545,9985,4852,4719,9354,824,7849,690,8707,3202,7286,5350,6902,5492,1918,3897,784,3081,8610,8458,4873,5240,7354,3597,3902,5213,3021,8990,337,655,8849,881,6911,942,6091,902,5789,6628,8718,3534,6811,9428,9166,3145,3277,9958,2811,9802,8966,2222,6152,2030,5283,1221,527,4212,2140,4652,3769,5620,826,2936,3644,2694,9262,2509,1454,2425,3017,3674,2563,6638,1540,8189,5058,9270,3783,8748,1256,9494,5653,9855,3927,5483,5387,7302,9022,4062,5575,6996,2738,5606,790,7943,4833,8248,9464,3470,3485,6685,8412,6469,7177,9459,6357,1538,2084,7588,7069,7029,7556,58,342,6696,6208,5538,505,880,4239,1965,8767,7574,3950,5189,3378,4462,4899,9386,122,2432,2998,4170,9413,5346,3489,9902,5614,314,1344,9759,7525,7566,1660,8260,6303,4329,157,5282,2487,1773,4717,9078,9695,2007,7160,3097,1608,6786,2787,4064,681,6429,300,8929,3096,8228,9064,1616,8868,7513,4396,7214,2451,6598,6571,9528,6776,1986,8086,4097,8363,3137,8650,4196,8404,7996,4382,9267,2674,9041,9706,1644,6901,2882,3868,7109,5671,6135,7482,5236,8878,7097,5147,1209,2214,8204,866,4361,30,9213,3259,2478,5683,163,2618,5630,5791,3519,5531,5977,994,8933,8640,268,1669,6145,4005,2637,447,6975,8998,547,2983,95,1396,4589,6737,2337,4908,8985,9936,9370,6331,8739,390,3874,4613,2539,456,9745,7953,7471,9350,2553,6044,7022,6706,1550,2250,5508,4504,5943,5349,6963,5855,1196,9765,3711,882,559,9871,9063,7679,8064,5908,2205,9876,1444,9565,1266,2184,4750,1879,2634,1722,2457,2602,3177,2252,5042,1849,3930,653,3709,6451,5795,3792,3600,4106,2522,4395,3802,4923,7447,617,5475,4249,8913,4173,3159,5151,1917,8883,6203,8573,8778,1610,1259,3762,4805,6948,4048,8168,7528,6620,8332,8895,3471,8367,4026,7636,8838,5936,7047,4542,4229,5744,7583,9035,5196,6716,7344,7087,3389,3413,4322,8927,5513,6169,4443,8442,2948,7247,6858,1700,1900,9499,697,6141,7460,36,1160,121,4046,7419,9076,6569,5275,2974,7226,5640,3688,7933,9999,1011,4554,7618,1072,3403,1547,5024,9641,2903,2144,4533,9372,3100,8279,5031,6188,6593,5337,1790,4650,
            6246,9427,3970,1871,9364,5187,6398,4530,3503,3788,1717,1801,4337,9448,7818,5414,207,8257,3724,294,4695,3962,7687,3733,8910,2960,3990,4204,3953,6767,5549,7205,3370,4540,570,2964,5914,6640,2446,7291,7995,519,2968,8081,3015,9761,9124,2115,3315,7682,2559,4375,1003,4960,7113,3298,7033,3063,961,4316,1624,8953,1476,1096,2426,1202,5554,8989,2450,4623,7085,2753,247,7416,2039,3288,649,3560,2663,415,1967,2059,2893,1195,9345,1639,6791,5956,5364,2233,5496,8616,2897,9017,5373,2302,642,9212,2669,3537,7220,5937,7757,5142,3588,3386,6869,1331,4043,3289,868,2501,9943,387,9400,5404,8725,2494,8807,3948,1925,827,8887,2934,6831,2633,4802,8963,1479,9337,204,1339,1652,4967,5804,1480,9931,2782,6659,1890,9327,7961,917,1314,6789,5040,1706,703,8302,6369,2220,6971,4851,1144,2472,4433,433,7492,90,7895,9379,2654,6565,7585,2380,1570,4266,7474,2609,4791,2317,7412,2528,5580,2678,8551,345,982,7393,5049,4666,9366,732,468,7887,6606,8532,2498,6591,3619,5812,8489,5427,7250,9013,4919,834,1908,2044,1919,3148,480,5722,2709,3815,3070,3478,6353,6186,1504,6408,1897,5992,7061,9209,8416,175,8566,7770,2922,5904,6539,3511,9796,3262,7744,2627,7070,7232,3020,2750,1589,9332,3133,7488,5964,5961,8479,8354,9637,3676,5866,3640,6271,3196,3620,6012,5659,4916,553,9780,8523,7815,8312,9502,8601,5589,1718,6512,357,9232,2139,5428,2977,6440,2905,8447,6415,3956,728,1111,3593,777,7580,9751,6367,7238,3052,9837,9817,9460,1251,7542,569,9096,1964,8655,3046,5137,2762,9811,2360,1174,563,603,1035,5913,8994,8987,1241,9385,7456,7825,8285,2677,1467,1511,533,7903,7411,1356,7349,3126,8526,4094,9369,8450,9479,9743,7184,4606,3044,8750,7772,4798,104,7511,2552,7093,9154,8832,8120,1630,8157,3279,6273,6294,733,1030,7608,2556,1566,9456,920,6019,9241,2530,5498,9790,6744,6850,8276,458,4981,2195,9927,3643,9348,1369,8579,8773,819,8511,7197,5443,8380,3377,9563,6879,1134,3280,2906,6100,9378,3353,5688,1257,1983,6982,2150,8919,7752,4377,9158,2801,495,3960,3639,3077,3423,1423,5993,1304,9045,9095,8471,2493,1430,1291,2413,2035,3562,4538,5434,8938,2099,6404,336,1595,9014,7362,164,3743,6535,2064,8642,318,8552,5326,8242,935,2463,3755,2319,8914,4268,9086,5871,8737,3938,7743,7032,7524,2194,4455,7092,3557,5635,4063,9926,9608,3115,5304,8339,5292,2390,5632,4241,427,5363,8218,9534,1022,1611,923,878,940,7079,5959,2293,5378,4564,8027,1852,8779,2744,7823,955,1602,1880,9482,5376,4683,9306,1949,9939,9059,3365,1340,915,1450,2433,3056,7476,7026,2591,3436,5752,598,2133,5019,7910,5845,3648,275,9051,9317,4626,7066,5400,7709,8311,4296,1371,6527,9036,7564,2000,4689,1625,8004,9611,6536,2569,187,4339,7154,7292,817,4335,3332,2958,7267,7929,1632,4870,4905,3959,2610,8852,3153,298,1814,2015,2400,2363,6881,2165,9380,3045,6199,8281,1586,9196,664,5145,2639,71,9050,6446,3883,4824,1620,3569,7827,7510,5281,8599,2661,7224,1501,5437,8677,1041,2427,3320,8445,9957,7138,7139,8833,6264,8419,7351,4617,1413,6763,2845,6319,8175,6597,3972,9443,7536,2268,2604,1826,4931,930,4228,2418,4534,2912,239,7841,2810,2043,1762,9308,6233,2141,2206,9272,3443,6634,5370,3966,8485,8424,7130,7387,5121,705,9992,6770,5808,811,980,1199,5226,1080,6983,4609,3382,932,309,8562,9952,7461,1243,1909,8711,8007,5140,8614,5166,3271,1429,3810,2887,8571,3655,2869,4795,9275,4927,489,4709,5063,2423,3416,8472,5525,8657,7617,7375,8234,1186,287,3468,6316,4879,5847,8047,7869,4156,6906,6964,1907,3955,9120,7036,6172,8623,10,4412,3212,3107,6492,7527,6444,8497,5570,1145,4448,4685,2049,3359,8014,3750,676,1953,7384,8349,5402,4257,4484,8229,8701,6679,6894,6721,8742,6743,4799,4726,4184,7694,7345,5347,5521,5222,1254,5382,8012,5141,628,7281,1334,757,7455,1478,9669,9512,3513,6098,5919,8630,3007,4749,7834,6406,3913,114,661,9411,2939,6339,4998,2326,5194,525,8851,8973,7013,3344,6252,1283,3735,2803,2953,9144,9420,7128,2945,2689,4881,2011,9672,8039,8342,5597,258,343,8518,2440,5239,4358,3048,2200,396,5356,5224,5090,402,264,3135,5046,3610,1943,2829,2324,2913,1106,4770,8820,7502,6784,8296,4555,6709,4496,1982,3411,6836,3025,6441,6260,8714,3300,2271,6579,2145,307,1007,3621,4672,7278,4360,6372,6067,3505,2269,3652,8482,8119,3108,5784,6435,9687,2322,4909,9942,1442,8646,1519,3200,6900,2355,21,5177,4970,9744,8899,4783,6412,2481,4518,6533,4129,8022,9106,6485,8215,9728,7215,3925,9098,4132,1666,4866,3524,1352,7404,1318,995,2079,9194,4471,7965,6267,7198,7734,3551,6550,9030,8631,5436,1954,5273,1805,8819,5171,4599,4616,123,2726,7803,3612,8205,8283,8352,9657,3459,4453,2687,8634,7606,6681,3463,5375,1489,338,4260,4697,8214,3398,3963,6042,2182,4000,7389,1000,9784,9201,9560,213,5178,9042,325,1668,4255,1363,2208,3776,8792,7866,7477,1830,6529,3354,1157,333,6584,5898,8564,2178,22,4502,8521,3791,7927,8504,3734,8839,6992,760,7668,6138,1779,4614,7258,768,5447,683,7504,7152,3038,1021,5129,8790,2981,1192,270,2520,806,8171,6148,5957,4101,6909,8038,4618,2382,1661,4336,9740,1156,542,9792,4019,3988,3231,1050,7572,1875,6549,2608,2760,6206,2731,6692,4210,9029,9170,3369,4844,1065,1864,1323,8129,2073,8536,6036,3957,8888,8433,9367,7174,5499,5745,5072,2935,6754,9056,231,836,1599,4031,9250,1920,3230,953,7171,476,430,1381,3215,9714,4629,3934,5033,9860,6648,9933,2388,6293,5005,6243,8294,6801,9393,5235,5401,9246,4968,8922,7880,4816,31,148,8567,3812,5285,9654,6818,9093,6399,7638,1658,7900,2675,8568,755,913,776,7150,6420,572,8401,3170,9913,6617,6189,9012,5441,647,6080,1577,7795,8251,8107,4663,8681,6635,6214,4739,8726,3406,5514,1234,6045,6641,1889,8604,2641,2105,4038,88,9368,2207,9762,3176,3964,5714,7507,5897,3985,8863,3994,3309,711,4262,9786,9230,139,5853,6961,3571,7239,244,6131,6411,3032,6674,2474,8454,4560,3609,4506,1419,2256,5529,9486,5649,4520,4510,764,1972,713,2356,
            4832,2239,9675,8781,7037,5560,2016,417,79,4603,4469,3206,8063,7862,222,783,4733,7045,1147,8643,8293,4306,2793,9421,6486,4203,3595,7100,6149,296,7315,440,9498,3140,60,7458,7555,8720,7718,2495,9461,1834,4476,861,1518,6457,1535,2311,8834,9162,4497,3549,2582,6792,8558,5127,4440,3775,1854,1633,839,6775,3729,7776,8231,8202,7149,3013,5825,4706,5689,2734,6594,1987,3143,3328,2346,4175,8976,6396,6128,9314,4692,4854,4985,3910,5877,6928,3887,1034,3608,487,3360,656,981,1618,2024,2800,2867,5655,3245,2644,8617,5698,5838,210,5269,6956,8529,7088,7452,3574,5626,3714,5294,8044,2034,3980,7486,3974,9165,1851,419,2497,7786,1319,8029,2062,7976,4419,4996,2938,8001,1366,816,1265,9621,2511,2947,3854,4546,2791,7043,3185,5507,2668,9971,5323,308,8128,1353,3946,1555,6827,6647,5978,735,7367,3736,2045,8206,976,443,7498,8140,689,7108,5551,8304,4181,8254,5045,810,1674,1227,6283,3343,6495,422,8232,4213,1698,5336,7459,4693,206,5700,1937,7706,4067,9478,107,4722,5497,7451,5772,3490,2859,9302,6006,6275,9175,6774,8542,8308,1297,2972,8949,965,6407,3570,9569,1587,845,1999,6735,3790,6158,9455,8331,8583,6758,1863,113,8847,1068,7928,4514,9442,8318,1877,5690,5915,4948,9591,6299,6781,4710,2410,8362,8456,6249,6266,4148,7086,2060,332,1898,401,3922,590,7263,4789,3337,4994,7737,7259,7630,4541,2980,792,4735,6298,5134,7014,7261,7758,5100,2076,321,3768,1009,7859,7020,3919,8879,9603,9468,259,7673,9737,8798,3147,7677,779,6683,435,8284,1342,5484,1102,3744,7777,9466,4217,365,4590,8956,6130,3080,1132,5197,6259,8704,1846,2243,9139,7970,9696,9138,8348,384,6686,896,7778,3,9988,4732,6750,9873,6541,1926,9074,3561,4454,7288,7523,1290,7578,1239,8900,1249,9983,6980,3741,5777,6639,9717,6400,6832,7125,7379,2412,367,5940,265,8268,3602,5287,8077,5892,9848,9875,8939,2232,3552,7899,7573,1107,9815,9979,1796,2260,6157,6070,6003,890,3624,5179,7665,4136,8005,5906,3706,2813,3112,9733,2719,797,2834,927,6625,943,8164,912,7309,8230,6482,4081,508,3853,3030,471,9134,7266,1059,9189,1732,5265,8746,4380,5329,6178,5420,92,2616,894,2780,7742,5446,6690,9703,2491,1564,534,4117,1170,1635,3590,6041,9305,7836,5006,7563,877,5762,8875,5830,341,4240,5101,8270,9047,9068,6551,9404,6282,4818,1819,2255,6499,9572,7007,7402,641,6222,5715,2561,5617,3687,2118,1224,3520,2555,3737,7966,4467,8351,2211,7721,7671,1126,205,729,7201,7855,3501,5163,9648,7993,1233,3162,200,5883,5002,2773,212,2142,7605,2915,5605,6237,1571,6637,1647,1373,1689,1958,2809,6253,3260,3773,5938,6538,8882,1596,7689,2749,7715,5813,4718,8884,2130,8754,1944,8753,4166,6999,1842,7759,3474,8679,8693,9071,4516,6546,6489,4366,3129,1455,9231,3144,9633,9865,8317,9081,5754,12,1182,6939,4468,7640,9787,9964,29,9284,6381,5965,9394,1271,8559,753,9339,7754,3855,672,9256,6383,9797,1446,9204,7877,6870,8585,5685,4390,8024,1302,8041,4015,4812,6010,7207,5464,7582,3442,743,4779,7905,9312,4254,4483,1462,3334,5770,3865,6605,2502,6694,1262,679,9021,3943,4677,8907,2203,5500,3383,3222,8082,2570,393,746,5911,7978,3493,9938,1601,9640,9854,6034,1643,4389,8502,3317,674,9838,4924,7852,6691,831,5357,3637,8250,511,5569,5243,5011,4883,3160,8240,1298,3995,8411,9067,8280,9955,249,7064,7904,1046,1541,2476,1815,9692,7898,3425,849,9991,6217,9480,9552,3829,8763,9271,5602,5899,6655,7390,428,1472,8208,8805,4003,5325,1711,1161,2301,1037,8259,5979,6085,4575,922,6491,3060,4373,5543,4953,1569,8659,1275,98,8345,6375,4280,1942,3804,5183,2259,1576,4359,8690,522,2517,4963,5730,1244,2769,2779,4821,5717,3681,4971,5298,2189,9622,3835,4430,4974,319,613,9303,5087,4308,9000,6787,2814,9493,449,3753,4367,4363,2307,6376,7035,7225,4547,1627,1984,8376,7470,1622,5868,2394,4665,6518,4256,9879,9163,4777,6093,2679,8923,2952,4987,805,9525,4189,6302,5858,2318,7076,83,9441,1004,5118,3900,8121,9357,4545,7789,6707,9110,5627,4365,5566,3559,5709,93,5505,1189,5385,2237,1403,5482,2965,9730,6050,3821,3269,5004,9062,1970,4325,2286,8152,3723,6990,1150,5307,5775,3921,7872,3363,3120,7018,9793,7408,5850,8475,3651,2878,7038,3233,3979,4917,136,9862,347,8660,5818,2074,9202,6077,3130,4955,5678,9229,166,5244,6261,6156,937,964,8181,5365,6470,9624,7276,6510,7948,2995,906,4298,6105,8782,385,8817,4775,557,5202,4815,3547,969,3102,9222,1600,4398,8360,8587,3035,565,9217,7804,5896,2652,3350,8581,9313,8652,4103,919,1273,8235,6663,6449,8665,8166,1392,2702,339,25,9252,1138,5532,1436,9258,6924,3154,3719,4765,7697,1934,5935,4900,9878,4167,1274,2104,3680,1049,8861,4006,7433,6431,2354,1341,6923,4834,7633,4352,924,7202,1316,5721,3847,2402,5324,8683,8123,4058,7107,1679,5295,7529,830,7287,9099,4160,3186,1361,6646,491,9974,9754,5338,3693,2113,2417,5540,69,6332,252,5610,7347,5759,5268,3533,5481,4340,4950,3379,6025,1387,6916,1683,3912,4790,2730,3000,9900,9852,4295,9521,6226,9685,7599,9882,8770,8262,8885,5399,5821,5308,3065,2547,8676,8274,1280,2982,8033,9397,6612,110,1085,7185,1910,7119,1362,3121,4704,8333,6459,6905,1179,1118,8216,91,2636,2121,2281,8997,802,6689,4508,3514,3476,8747,1726,2844,2979,3110,6847,234,2515,501,5403,2798,6423,103,2146,2009,5618,5719,6358,4527,9969,2199,876,1289,3036,2700,6084,7858,5718,6099,4817,5057,8980,1029,1123,4261,5537,1579,2345,5666,560,7010,232,8606,182,5894,7952,4394,5691,3069,4986,699,5389,4107,2479,4972,5358,5150,2622,7685,6484,2298,3538,8818,1305,2067,1417,2238,1521,5094,1327,3054,1485,5128,2807,2342,5075,3050,2387,4157,3527,6800,7340,3127,7712,3580,4708,544,3016,3740,4588,3585,2593,5734,2951,6221,4087,6910,1248,9537,400,6185,3381,9791,5267,9077,8857,5716,4756,4942,8369,8937,5625,363,1201,9295,2866,4505,1397,9912,8269,7909,7223,431,9315,3232,9435,9326,3483,1853,2036,2656,958,1543,8682,9373,3284,7135,1308,9412,3885,5827,5262,4165,4188,8374,
            6433,1272,2455,9678,5089,9333,1629,4631,7980,7317,8361,5748,9755,3407,5359,4321,2031,8440,8413,485,1767,1933,9903,809,8473,2994,3799,9966,7992,1173,52,6359,7875,9574,3718,5093,2245,6132,6285,1653,4084,6219,595,1736,8480,8960,1721,7951,8570,9475,9044,9199,6220,6311,9750,2253,1203,9043,6664,2012,1063,8183,9970,9623,8859,3556,7428,5120,670,9151,1656,7598,1961,8517,6082,8622,143,8862,7533,4068,8680,331,4169,9510,412,1678,8127,7401,6863,7814,4137,9032,1692,5816,7415,4030,9756,9197,1198,1078,9899,3073,7906,3273,1817,3576,6589,515,9356,323,9141,3093,3895,2305,6428,3803,7796,4206,5480,6144,3695,465,7908,7397,4090,1104,8491,5077,9391,1786,8444,6240,8192,165,7520,6828,9007,3584,78,1778,8286,722,7703,7469,709,4907,3339,9324,7500,8377,3649,4627,9181,5679,6227,7383,1315,9937,725,5742,1771,7725,7592,3678,8666,5984,1659,6562,2538,5206,7111,2068,843,7409,295,9568,3705,4895,7648,5123,7865,3002,1637,2376,2871,5829,3083,8633,2010,7289,1681,7161,8449,2751,1885,9771,5738,2554,3861,4486,2943,3732,7255,76,6181,4378,5315,8236,382,2645,9518,1299,462,6453,9008,7218,2820,7449,5453,2891,1869,7714,7117,2148,2172,9532,2857,4988,608,872,7269,2879,7478,1218,4061,5008,3646,6509,8144,5135,9034,9635,9810,4044,2742,9243,556,7979,5988,5693,2929,3209,317,4108,128,6047,1702,5423,5869,7741,561,1588,3438,4572,473,6060,6710,4946,5511,1377,1955,15,1167,293,916,1719,2248,7751,6373,8620,353,5257,3996,3267,750,2378,4680,6736,2846,7851,1219,4656,3099,9701,4128,654,7190,1416,1516,1574,9700,7817,3827,7561,8139,4788,8106,3297,9336,9128,3207,4890,9341,5558,7969,5527,4004,1901,3589,3575,3462,8142,4186,6213,372,8626,8434,6794,2635,3340,1425,4748,2754,5619,4427,851,8563,7054,833,2683,9296,6622,5114,7649,3987,6705,2169,420,5460,5314,7788,5079,5477,6592,823,4605,7635,4829,794,6345,1628,5778,3091,3798,1312,6771,6673,1808,9595,3053,4190,2454,7417,9119,5062,6033,4199,3873,5985,2910,895,1528,3033,5353,6613,7707,3604,786,7902,1575,3677,2381,9132,2925,4758,4803,3713,2523,5633,6629,7181,9152,5895,4372,8918,7938,1626,1612,6746,832,7407,6029,3840,8186,2962,9407,7632,9698,171,4848,1033,7368,216,5973,2630,7889,5893,9084,96,4724,5309,4183,3933,870,3645,2577,3292,3252,150,1112,8402,6180,787,6908,8758,5983,691,8403,626,3049,8290,7581,9781,8217,5103,7095,8722,3544,9570,5444,6768,5345,3906,5182,9954,3663,6973,3156,6118,4225,9198,1168,632,7216,7098,6951,7947,3632,4460,6317,629,6895,8455,551,6256,2482,9887,5082,2152,5702,3656,8414,3795,3512,6958,8632,3373,5705,5811,7444,6712,8097,467,5234,1530,5433,8197,4867,1277,6327,9664,4104,137,3929,6680,2339,2967,8227,4426,8603,8385,9980,7639,1466,2125,7917,3747,6218,9612,5524,5530,6124,1459,7780,7426,3285,8731,9471,4400,9293,6725,8100,3518,3183,3685,6777,4095,6719,2065,2349,9994,7702,9850,6727,2921,9374,7538,1375,1368,2631,9650,2453,3704,2447,2755,8219,1977,3523,778,2822,6826,2907,7886,7386,5003,1261,3862,2747,6883,48,3872,6820,5167,6843,1411,9625,8689,124,7765,1359,8644,5822,4562,288,9901,3011,13,9989,5331,346,7894,8136,1098,886,1307,8881,6150,1783,8478,6341,1865,4565,1809,2377,7273,8147,310,9102,3088,6421,7568,4376,7610,8484,3894,7935,5228,751,9747,3316,4331,2512,9287,5579,3118,5981,9856,9263,5254,9129,7156,910,5955,7268,908,2665,7333,94,1317,8483,4110,939,2817,3481,4424,9195,7656,9214,6191,6385,4913,3717,3832,8306,6154,4391,4596,1400,571,3168,2028,8125,27,6808,9577,1313,1345,9155,1525,7800,5520,8972,1148,8977,5941,8618,3265,9639,970,2234,4227,1559,5198,6038,6374,6822,2496,9915,7028,118,7641,4096,6424,9911,7624,9057,5169,6380,276,4109,704,2649,1837,9473,4153,4020,1753,5735,3251,301,963,2766,5805,3239,5208,3179,1276,1010,6434,9125,531,1670,65,9216,7957,3111,9627,6873,5115,2117,5022,3031,7809,1458,1310,6197,181,7920,6610,5533,9519,8114,1405,5547,3163,3094,1039,677,6950,1896,6053,3191,9559,8045,8390,2524,5272,7597,9773,6204,2835,2202,9040,2291,1399,8010,6936,8896,7489,803,6187,9147,5124,9236,4176,582,3351,6860,6184,2296,4651,5539,1645,1886,9832,5976,4425,455,9507,5327,6364,8808,261,4168,8996,4849,9277,3759,6965,7837,6991,3428,1648,7550,2262,3104,685,1685,7204,8110,7548,2085,688,1603,8801,748,4466,716,6957,7172,3205,1520,2098,4587,5180,4976,1992,4432,782,8962,4922,6059,4025,218,8299,4738,9554,4511,6853,5317,3295,1754,8600,6862,9396,8983,6759,1374,3410,9594,202,8141,6704,3318,3697,7609,7279,8813,8350,9812,6496,5710,2313,3164,356,328,4764,4630,4012,404,4839,8174,8396,5728,3904,5917,9298,9307,9583,6134,7545,6667,9607,8180,3633,4489,6588,6403,4762,9511,9758,8237,9806,6945,5522,1932,7003,6064,2548,6129,1995,1994,7284,6874,6335,7603,7103,3430,6086,2949,9551,4836,4973,8126,2048,7937,9185,2284,1178,3982,1103,3565,979,2119,3517,5305,4837,2923,3448,350,6523,6065,6472,2701,5064,2321,9422,1825,5793,7522,2369,2343,5515,9686,4324,8065,8137,1822,8278,3349,6397,4902,4880,650,5780,4842,788,2872,3973,1119,8243,1565,9342,3429,2299,662,6575,9619,8925,8305,4736,413,4319,5425,4041,5343,7053,127,2715,3074,7030,9136,8902,8375,6841,9906,4731,1793,6020,1048,445,7623,3466,5050,5451,6136,6585,4436,2014,8582,3928,2764,2557,6354,521,8757,5110,3067,3999,4838,5293,4746,9918,1715,6796,4039,2886,7320,4529,5246,6356,8578,7394,5406,4771,4573,3458,4784,9867,9505,324,5122,89,8460,791,7562,8358,9173,4763,9247,1468,9834,619,3823,8733,454,8201,6514,1155,8889,3774,648,1867,6310,7434,8590,5256,8920,4445,8034,3765,6107,4637,1887,4401,4171,5724,9405,5139,4286,9088,7479,8891,4002,2096,112,4859,1665,9962,254,5865,3509,3456,9465,4825,2303,1922,3117,9112,6570,2904,8686,8,5379,3327,3882,9026,8872,1076,3578,5637,3003,9168,6871,3691,2103,8382,5960,9423,2187,4809,4761,5016,1188,3043,5918,1609,2727,9897,1804,4014,645,1264,
            3064,5320,8596,7136,8825,8207,1861,183,4507,7481,4267,6654,4409,9476,3920,3606,1242,528,4198,9497,6877,306,4450,8297,4535,24,9481,7475,3654,865,9410,5621,4814,9180,9684,3978,2499,2534,2328,7549,4474,1115,6202,4621,9454,8111,2837,2797,3454,8651,9255,2351,142,7602,3831,1140,3622,2916,2940,6907,120,2830,9514,8046,4074,8674,235,1044,6027,4857,2312,8829,5126,5490,7798,5181,1927,6614,6478,6164,4729,9930,7794,7192,7240,6978,2175,8155,7746,1798,9929,8510,6835,9604,4797,4405,4920,7509,8543,2571,9130,3464,8713,8018,7723,7942,543,5996,2908,3236,9996,4223,6089,9600,2441,4333,7427,6052,450,7425,5015,1394,5344,1487,389,7001,8795,2818,8245,312,1791,1724,9674,4177,5765,5577,8392,246,555,4283,5306,1833,4493,5136,2646,8103,996,993,7074,3086,5465,4451,1539,944,8695,6201,3967,9944,3844,2819,2471,4159,2969,4544,8368,5053,5153,7842,7901,7391,7730,5574,9103,4782,9547,7361,2550,3682,8508,5934,3582,4421,3323,3078,9439,9470,765,7364,6343,6425,2546,644,840,1482,496,5339,1471,284,7781,1714,9286,9023,439,6804,397,359,5872,925,5071,3903,991,2266,351,4115,8104,2442,9291,3787,9707,6049,5220,5667,3157,7243,3614,2621,6583,9863,6116,625,7017,9003,7766,2167,2662,5471,8909,6193,7453,3040,3310,1052,5727,660,2901,8408,9297,8505,928,7485,3686,1105,4123,3014,1159,5948,101,6291,7749,837,3789,5542,9445,6715,262,3864,5536,8874,678,3502,3132,5857,8802,8724,8981,4374,7167,2279,7343,9351,7854,8346,3971,7811,7105,509,730,5468,6806,9135,1720,1613,2431,8115,987,1295,1902,273,6366,2532,7981,380,8915,4592,9940,2209,8550,7764,9788,5677,6561,9919,2002,7760,6087,8326,5878,3942,3546,6255,6263,8749,4645,8995,4073,77,7930,392,2225,1099,6623,9121,8187,1968,8908,1590,9553,7122,9060,5144,6388,9436,4114,8607,8903,3700,6458,7299,1705,3826,1691,3371,1693,3449,8191,1008,292,4461,5248,2340,6899,9543,4180,1269,8399,8052,1395,2274,5431,4277,1079,7337,4273,7213,7414,1238,4882,9713,5862,1957,2362,9948,966,8421,1671,4855,8393,1763,4393,9089,3748,2475,5048,7782,8015,9757,1084,6463,772,1751,7437,5950,1803,2359,7879,9052,581,7418,9233,7116,5395,9998,8687,3244,9371,5333,8476,6037,2592,9210,7552,5418,3816,2743,9431,8928,5786,5381,3554,7252,7675,3754,1780,4593,5432,4822,8541,1585,7674,7170,589,4670,4674,9836,3521,6645,5330,847,5435,5408,6666,4140,9917,9353,1223,4754,8775,4083,938,398,9289,7918,3024,4127,3010,3583,5852,8592,5999,4730,5069,4662,1739,3860,4091,9517,9610,4230,1820,2825,9424,9665,6471,2920,2276,5251,9605,1664,5156,7065,4301,8253,226,8968,8944,8427,5767,8067,2071,1594,2285,7164,8999,8143,8241,194,9615,4307,1604,8325,5261,3198,623,9048,5584,6072,7194,3124,795,4831,4011,6921,7987,1976,2799,179,7593,1460,8811,8023,3441,9636,6766,8223,7297,2095,115,7663,498,4420,2599,7652,9564,3911,7829,5383,4222,5052,7844,59,9748,3896,3890,9010,2215,6468,9002,7963,3347,6574,9417,1883,4121,1742,4065,3486,9167,7878,4543,290,897,1704,7763,3766,7081,4701,7034,7926,6426,5817,9592,1469,1165,6890,7611,54,1799,3211,9338,7210,5953,9171,7994,8624,9389,8213,5086,1100,6125,8016,929,7779,1187,174,7783,1124,7541,2003,5223,9402,2598,5430,6265,2129,9529,5564,6151,3675,5014,484,6058,3935,9219,3227,9126,457,6587,7698,7595,7233,7761,2505,6288,5846,8159,8069,8370,9990,7301,2216,6461,9264,6555,327,2632,8605,8917,7436,4152,2136,9446,6419,3779,5733,7769,7646,8743,8298,6611,6548,4053,2108,8226,8572,9798,3742,6276,6347,7448,8266,8459,4676,5753,4214,5885,4051,1301,5876,7923,199,7986,6096,2102,9483,767,8436,6279,4667,715,9398,5241,144,7025,4943,3495,8823,1215,4402,1911,2722,9741,488,7826,737,6670,3174,7495,4146,5966,3611,8431,4332,2154,2877,4911,3586,2643,3558,1498,1667,6460,2855,1047,4713,5823,7531,1082,9967,8890,8430,2131,6665,490,248,5461,7955,6113,3672,6953,646,42,2383,7594,4100,2151,1332,4221,2720,2685,1094,1122,1695,7290,7217,5704,7323,3907,8193,3368,4274,8378,3660,8845,907,9725,8032,4840,5891,6392,7907,1811,45,5440,3192,6960,503,8074,8075,6437,1760,6920,9910,5519,9914,4969,4536,808,5991,3876,903,4628,1431,4408,5642,6564,6868,5168,3834,8172,3539,3690,5707,1210,7820,376,3598,7925,9107,8178,4364,1654,7008,5926,5676,518,1682,3727,8439,446,8613,3838,303,9557,8002,7027,8520,8233,4197,8729,9146,829,2409,4435,2246,7372,8557,3592,1053,3786,855,3782,5932,5020,3730,5097,9984,6856,8058,863,190,5478,5541,6081,9039,8426,4231,3224,599,4853,3937,2473,4179,3939,1684,1662,3814,1894,5340,2596,5851,5316,1532,4111,4042,3226,5013,7200,6009,8388,9656,7080,4800,4079,858,6090,7082,9150,6309,1061,8048,9226,2625,1051,7168,1915,3515,1802,7945,9898,4785,305,5751,6312,7651,5290,3984,8843,2513,6391,2088,5923,9582,6517,8289,3857,4478,6997,9736,6521,739,968,6280,7230,606,4472,8338,7280,8822,8824,9562,1083,7521,7148,1551,3357,9066,3615,4027,5673,2366,8826,8198,3545,3210,8942,7604,4354,8539,2025,6542,5600,4049,568,9716,1862,7133,3180,634,6307,3319,8959,1354,3702,1032,4939,3445,6695,5250,410,3839,9934,9976,3225,7655,5776,7441,2218,8466,5092,9731,7570,6568,6039,2583,4975,5009,6349,9097,9259,9148,7774,5603,7322,1445,4381,5844,5665,6938,7274,5763,5629,5713,2790,6577,2691,334,8452,4017,3287,8061,8984,7913,7959,9866,4872,9922,1176,130,3109,4040,1758,4889,2469,6552,8789,9058,652,5445,6251,7590,2434,7365,950,4278,1856,9616,6153,718,7377,8565,9589,960,680,9018,3845,8150,4303,3949,6297,3809,6516,375,7424,4563,8569,8975,7341,2486,7644,8488,2973,1792,2673,1563,3669,5422,2156,3047,2132,7044,7199,3189,6525,6277,5503,9257,7049,1956,2430,4009,9309,8264,1338,841,8135,4553,8961,8252,9630,4317,1457,1655,6932,8199,9080,8170,8867,3026,1823,1232,4276,7321,740,6967,6262,1701,3362,8461,1245,3039,9724,1703,285,5017,4285,3453,873,537,7508,9578,5360,3914,7330,1969,7467,1840,106,4187,5781,4552,6170,
            5801,1075,6207,6558,5154,9116,1882,7483,8246,1752,520,1578,7736,2112,1183,7973,3178,3243,8122,4595,6209,9947,4918,3473,2023,2484,4688,4591,2373,530,5010,4721,3555,4431,2055,3477,176,1493,1542,6830,1092,1086,5116,4861,6642,8856,8093,8344,5487,3291,6718,2392,3991,6043,5335,9575,7040,1593,1913,4246,3216,4944,5841,2275,2827,860,6054,2987,1764,5947,5455,5501,9881,6949,1904,838,2331,6278,57,643,952,6323,3830,5785,1357,7946,6320,9649,7600,1222,5021,6110,6083,1410,7686,4686,1872,2868,2941,4242,9548,2350,8091,7944,1067,7242,1166,898,2437,9819,2077,224,8179,9732,1070,5310,2816,3009,8389,6788,4868,8906,1087,5096,4681,1131,2587,3172,4313,9177,5986,3380,6501,7922,7342,5108,5449,2653,593,1523,4060,8336,2057,7083,7808,8594,2605,5439,2804,6448,7863,7062,9143,7813,2732,2890,5174,3851,6889,9261,1841,7616,9437,3304,7514,9820,8653,1349,5388,6913,3500,602,1512,2500,8697,1027,4164,3908,5366,1649,1322,3807,5815,9588,6678,1439,3699,7311,5604,4945,3577,1723,4896,257,66,84,198,3329,4571,5949,7221,1640,6159,6389,4415,5711,2775,320,5238,6254,6024,2647,2892,5562,1716,8515,3993,2379,7515,3497,4776,463,2860,3526,4490,326,4619,451,2541,615,9520,8158,7023,2173,8796,8774,5119,1,8066,1336,7569,934,1928,9376,8815,1324,2763,1499,1725,3408,9266,4921,8844,1091,1279,5588,4845,9770,6198,6662,4236,5080,2185,9184,9987,5321,1672,7480,5568,9764,8784,9772,6046,3694,6851,7739,6162,6630,5450,4964,9864,7867,3898,2325,9208,3856,33,6753,6602,9738,3165,8946,5332,7209,405,9087,1335,1019,8492,1513,9683,5249,2348,1557,9602,4134,5473,6798,4720,8780,4639,8463,1785,5301,2888,4130,5922,409,2374,3397,1162,3796,5113,9739,3023,9596,9804,3264,4404,2526,4607,9415,4634,7487,6941,3169,4638,5901,1746,2310,8941,3150,8194,2710,1292,3525,7131,7257,2613,20,8387,4082,1154,3924,4793,2535,1991,5886,4449,5193,9463,3870,4318,7985,4700,4897,3341,1812,6161,6378,1936,7544,1456,8372,8059,1081,1524,3528,466,4581,9451,9777,6671,5757,8094,315,4247,7516,6008,6764,1451,1270,724,6752,9211,4356,7921,8256,3531,3420,7265,3893,7398,1531,911,6210,1998,8156,5624,2320,7790,1740,7294,9722,8756,624,6995,3567,5796,7399,8089,6257,7532,8951,1959,2179,4099,1197,192,9628,8661,8182,3983,2164,6139,1205,7236,6018,9083,3447,1040,6224,3931,2831,2568,6650,3843,5459,1494,2902,7072,7169,9673,5424,706,2664,3114,8307,7329,1554,2290,4930,1766,6812,1895,7282,549,5684,804,5203,8316,2181,1941,7971,3763,1562,818,2267,5302,8776,6563,9794,9597,2066,5117,3290,6669,1873,6914,731,4766,7457,3364,9857,6330,5,4893,6112,4792,3507,1343,7733,5479,8467,5085,5613,1321,4696,6068,173,3634,8418,3684,6368,6173,627,154,3880,2889,8328,8055,73,19,9545,7695,7717,1824,5232,7229,5779,4995,3944,9188,8732,2492,4122,1800,668,6898,1544,5313,1130,4937,9207,8991,3075,7626,1605,2480,5798,1787,4383,4938,4270,7801,4712,1572,7096,9550,2415,2794,8809,7892,2277,1287,2527,2297,1526,5546,2525,8441,2336,7710,3661,8759,7591,3781,4154,9599,2042,470,7724,9613,9661,6182,5025,6747,9839,5133,5910,6844,5611,9827,3764,8527,2728,933,233,5699,5726,4841,6554,6815,7063,8391,2166,5066,2329,502,6942,7822,6092,6427,6174,266,8967,5523,2536,9388,9472,1631,2741,1558,6258,9127,6442,9809,1734,4252,3947,1727,9011,6724,5658,2106,3325,3599,2713,1024,2404,6779,998,9281,2124,7423,241,2375,584,2579,3532,5384,5820,1623,5928,9377,1769,4737,253,4444,2976,6075,3057,4422,8101,2086,8509,5644,2767,6026,1089,3899,587,5836,6490,1296,3404,8239,2776,9982,4558,5112,7031,5998,4238,1924,5517,2651,6377,7885,4980,2162,74,4045,2792,9567,4397,8161,846,4936,3739,1650,8167,8554,4858,3866,6194,6344,3482,5405,7392,7940,7382,6137,1005,9409,6917,592,2856,2461,4894,1828,8448,5081,67,3037,140,3342,8313,9888,9874,5458,9031,2748,977,5557,8576,5593,1347,4098,1020,2089,8535,6825,8638,1560,7964,478,9109,7046,8612,1971,5204,3771,9123,7319,971,5962,278,6738,596,5225,4657,9590,5833,6934,4786,2288,9001,5098,9978,5881,3051,8765,4263,2682,5341,6668,986,9251,138,9581,9884,3492,432,5362,2032,8842,6494,3388,9318,580,1058,4778,4075,972,2429,796,8597,1855,9025,8588,3131,374,5426,3113,7890,1857,1728,1781,5247,3161,7799,799,9444,5104,1137,1876,4495,5351,6300,7353,7977,4485,6603,918,4551,7165,4235,6225,6111,9457,7260,5675,6861,4526,3617,639,7501,6607,2193,3916,4658,5286,4932,223,2699,8716,2411,5463,3722,4092,9438,4077,1426,2483,3027,3806,6360,7056,983,5994,9889,9079,9024,1743,2648,2464,5842,889,8512,6106,9835,9924,1789,3214,7147,3616,5556,2588,3850,7690,6418,4300,1923,1441,8934,4439,4898,197,3710,1775,835,7438,9137,6604,4033,2858,486,7728,6590,7324,459,510,2712,2789,62,1694,2806,4752,6497,452,8021,2221,9288,5741,4080,7313,5474,444,7141,2228,6703,1529,6682,1128,6109,8173,9853,1045,1738,3301,3101,2361,9801,4947,3367,3400,4522,6931,7158,3841,8850});

            LargestTriangleAreaDemo test91 = new LargestTriangleAreaDemo();
            Console.WriteLine(test91.LargestTriangleArea(new int[5][]{new int[2]{0,0},new int[2]{0,1},new int[2]{1,0},new int[2]{0,2},new int[2]{2,0}}).ToString());

            ValidParenthesesDemo test92 = new ValidParenthesesDemo();
            Console.WriteLine(test92.IsValid("([])").ToString());

            RemoveDuplicatesfromSortedArrayDemo test93 = new RemoveDuplicatesfromSortedArrayDemo();
            Console.WriteLine(test93.RemoveDuplicates(new int[]{1, 1, 2}).ToString());

            CountandSayDemo test94 = new CountandSayDemo();
            Console.WriteLine(test94.CountAndSay(6));

            MaximumSubarrayDemo test95 = new MaximumSubarrayDemo();
            Console.WriteLine(test95.MaxSubArray(new int[]{-2,1,-3,4,-1,2,1,-5,4}).ToString());

            RemoveDuplicatesfromSortedListDemo test96 = new RemoveDuplicatesfromSortedListDemo();
            ListNode node96 = new ListNode(1);
            node96.next = new ListNode(1);
            node96.next.next = new ListNode(1);
            ListNode ret96 = test96.DeleteDuplicates(node96);

            MostCommonWordDemo test97 = new MostCommonWordDemo();
            Console.WriteLine(test97.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[]{"hit"}));

            TreeNode root98 = new TreeNode(1);
            root98.left = new TreeNode(2);
            root98.right = new TreeNode(2);
            root98.left.left = new TreeNode(3);
            root98.left.right = new TreeNode(4);
            root98.right.left = new TreeNode(4);
            root98.right.right = new TreeNode(3);
            SymmetricTreeDemo test98 = new SymmetricTreeDemo();
            Console.WriteLine(test98.IsSymmetric(root98).ToString());

            TreeNode root99 = new TreeNode(5);
            root99.left = new TreeNode(4);
            root99.right = new TreeNode(8);
            root99.left.left = new TreeNode(11);
            root99.left.left.left = new TreeNode(7);
            root99.left.left.right = new TreeNode(2);
            root99.right.left = new TreeNode(13);
            root99.right.right = new TreeNode(4);
            root99.right.right.right = new TreeNode(11);
            PathSumDemo test99 = new PathSumDemo();
            Console.WriteLine(test99.HasPathSum(root99, 22).ToString());

            PascalsTriangleDemo test100 = new PascalsTriangleDemo();
            IList<IList<int>> ret100 = test100.Generate(5);

            PascalsTriangleIIDemo test101 = new PascalsTriangleIIDemo();
            IList<int> ret101 = test101.GetRow(6);

            BestTimetoBuyandSellStockDemo test102 = new BestTimetoBuyandSellStockDemo();
            Console.WriteLine(test102.MaxProfit(new int[]{7,1,5,3,6,4}).ToString());

            BestTimetoBuyandSellStockIIDemo test103 = new BestTimetoBuyandSellStockIIDemo();
            Console.WriteLine(test103.MaxProfit(new int[]{7,1,5,3,6,4,3,2}).ToString());

            LongestContinuousIncreasingSubsequenceDemo test104 = new LongestContinuousIncreasingSubsequenceDemo();
            Console.WriteLine(test104.FindLengthOfLCIS(new int[]{1,3,5,7}).ToString());

            HappyNumberDemo test105 = new HappyNumberDemo();
            Console.WriteLine(test105.IsHappy(18).ToString());

            PalindromeNumberDemo test106 = new PalindromeNumberDemo();
            Console.WriteLine(test106.IsPalindrome(121).ToString());

            FactorialTrailingZeroesDemo test107 = new FactorialTrailingZeroesDemo();
            Console.WriteLine(test107.TrailingZeroes(6).ToString());

            ReverseIntegerDemo test108 = new ReverseIntegerDemo();
            Console.WriteLine(test108.Reverse(-123).ToString());

            HouseRobberDemo test109 = new HouseRobberDemo();
            Console.WriteLine(test109.Rob(new int[]{2,7,9,3,1}).ToString());

            MinCostClimbingStairsDemo test110 = new MinCostClimbingStairsDemo();
            Console.WriteLine(test110.MinCostClimbingStairs(new int[]{0, 1, 1, 0}).ToString());

            ShortestDistancetoaCharacterDemo test111 = new ShortestDistancetoaCharacterDemo();
            int[] nRet111 = test111.ShortestToChar("loveleetcode", 'e');

            PositionsofLargeGroupsDemo test112 = new PositionsofLargeGroupsDemo();
            IList<IList<int>> ret112 = test112.LargeGroupPositions("abcdddeeeeaabbbcd");

            GoatLatinDemo test113 = new GoatLatinDemo();
            Console.WriteLine(test113.ToGoatLatin("The quick brown fox jumped over the lazy dog"));

            DistributeCandiesDemo test114 = new DistributeCandiesDemo();
            Console.WriteLine(test114.DistributeCandies(new int[]{1,1,2,3}).ToString());

            NumberofSegmentsinaStringDemo test115 = new NumberofSegmentsinaStringDemo();
            Console.WriteLine(test115.CountSegments(", , , ,        a, eaefa").ToString());

            FlippinganImageDemo test116 = new FlippinganImageDemo();
            int[][] ret116 = test116.FlipAndInvertImage(new int[4][]{new int[4]{1,1,0,0},new int[4]{1,0,0,1},new int[4]{0,1,1,1},new int[4]{1,0,1,0}});

            FloodFillDemo test117 = new FloodFillDemo();
            int[,] ret117 = test117.FloodFill(new int[2,3]{{0,0,0},{0,1,1}}, 1, 1, 1);

            BaseballGameDemo test118 = new BaseballGameDemo();
            Console.WriteLine(test118.CalPoints(new string[]{"5","-2","4","C","D","9","+","+"}).ToString());

            RectangleOverlapDemo test119 = new RectangleOverlapDemo();
            Console.WriteLine(test119.IsRectangleOverlap(new int[]{0,0,1,1}, new int[]{1,0,2,1}).ToString());

            IsomorphicStringsDemo test120 = new IsomorphicStringsDemo();
            Console.WriteLine(test120.IsIsomorphic("foo", "bar").ToString());
        }
    }
}
