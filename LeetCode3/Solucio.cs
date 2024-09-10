using System;

namespace LeetCode3
{
    public class Solucio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Arrays testArrays = new Arrays();

            /* DuplicateZeros */
            //int[] toTest = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
            //int[] toTest2 = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            //testArrays.DuplicateZeros(toTest);
            //Console.WriteLine("");
            //testArrays.DuplicateZeros(toTest2);
            //Console.WriteLine("");

            /* Merge Sorted Array*/
            //int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = new int[3] { 2, 5, 6 };
            //int m = 3, n = 3;
            //testArrays.Merge(nums1, m, nums2, n);

            /* Remove Element*/
            //int[] nums = new int[4] {3,2,2,3};
            //int val = 3;
            //testArrays.RemoveElement(nums, val);

            /* Remove Duplicate */
            //int[] nums = new int[3] { 1, 1, 2 };
            //testArrays.RemoveDuplicates(nums);

            /* Check If N and Its Double Exist */
            //int[] arr = new int[4] { 10, 2, 5, 3 };
            //Console.WriteLine(testArrays.CheckIfExist(arr));
            //int[] arr2 = new int[4] { 3, 1, 7, 11 };
            //Console.WriteLine(testArrays.CheckIfExist(arr2));

            /* Valid Mountain Array */
            //int[] arr = new int[4] { 0, 3, 2, 1 };
            //Console.WriteLine(testArrays.ValidMountainArray(arr));
            //int[] arr2 = new int[10] { 0, 1, 2, 3, 2, 1, 0, 1, 2, 0 };
            //Console.WriteLine(testArrays.ValidMountainArray(arr2));
            //int[] arr3 = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Console.WriteLine(testArrays.ValidMountainArray(arr3));

            /* Replace Elements with Greatest Element on Right Side */
            //int[] arr = new int[6] { 17, 18, 5, 4, 6, 1 };
            //Console.WriteLine(testArrays.ReplaceElements(arr));
            //int[] arr1 = new int[1] { 400 };
            //Console.WriteLine(testArrays.ReplaceElements(arr1));

            /* Move zeroes to end */
            //int[] arr = new int[5] { 0, 1, 0, 3, 12 };
            //testArrays.MoveZeroes(arr);

            /* Move zeroes to end */
            int[] arr = new int[4] { 3,1,2,4 };
            Console.WriteLine(testArrays.SortArrayByParity(arr));


            Console.WriteLine("");
        }
    }
}