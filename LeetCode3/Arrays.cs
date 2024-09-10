using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode3
{
    public class Arrays
    {
        public void DuplicateZeros(int[] arr)
        {
            int[] support = new int[arr.Length];
            int iteradorSupport = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && arr[i] <= arr.Length && iteradorSupport <= support.Length-1)
                {
                    support[iteradorSupport] = 0;
                    iteradorSupport++;
                    if (iteradorSupport <= support.Length - 1)
                    {
                        support[iteradorSupport] = 0;
                        iteradorSupport++;
                    }
                } else if (iteradorSupport < support.Length)
                {
                    support[iteradorSupport] = arr[i];
                    iteradorSupport++;
                }
            }

            support.CopyTo(arr, 0);
        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
            Console.WriteLine();
            foreach (int item in nums1)
            {
                Console.Write(item);
            }
        }
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int[] numsTemp = new int[nums.Length];
            int indexTemp = 0;

            for (int i = 0; i< nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    k++;
                    numsTemp[indexTemp] = nums[i];
                    indexTemp++;
                }
            }
            for (int b = 0; b < nums.Length; b++)
            {
                nums[b] = numsTemp[b];
            }
            foreach (int item in nums)
            {
                Console.Write(item + ", ");
            }
            
            return k;
        }
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int[] numsTemp = new int[nums.Length];
            int indexTemp = 0;
            int previousNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != previousNum || i == 0)
                {
                    k++;
                    numsTemp[indexTemp] = nums[i];
                    indexTemp++;
                    previousNum = nums[i];
                }
            }
            for (int b = 0; b < nums.Length; b++)
            {
                nums[b] = numsTemp[b];
            }
            return k;
        }
        public bool CheckIfExist(int[] arr)
        {
            for (int i =0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && 0<= i && j < arr.Length && arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ValidMountainArray(int[] arr)
        {
            bool res = false;
            bool pujant = true;

            if (arr.Length < 3) {return false;}
            if (arr[0] >= arr[1]){return false;}
            if (arr[arr.Length - 1] >= arr[arr.Length -2 ]){return false;}

            for (int i = 1; i< arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) { return false; }
                else if (arr[i] > arr[i - 1] && pujant)
                {
                    res = true;
                }
                else if (arr[i] < arr[i - 1])
                {
                    pujant = false;
                    res = true;
                }
                else
                {
                    return false;
                }

            }
            return res;
        }
        public int[] ReplaceElements(int[] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i<arr.Length; i++)
            {
                int tempValorMax = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > tempValorMax)
                    {
                        tempValorMax = arr[j]; 
                    }
                }
                if (i == arr.Length - 1)
                {
                    temp[i] = -1;
                } else
                {
                    temp[i] = tempValorMax;
                }
            }
            for (int b = 0; b < arr.Length; b++)
            {
                arr[b] = temp[b];
            }
            return arr;

        }
        public void MoveZeroes(int[] nums)
        {
            int[] temp = new int [nums.Length];
            int counterTemp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp[counterTemp] = nums[i];
                    counterTemp++;  
                }
            }

            for (int b = 0; b < nums.Length; b++)
            {
                nums[b] = temp[b];
            }
        }
        public int[] SortArrayByParity(int[] nums)
        {
            int secondCounter = 0;
            int fromLastCount = nums.Length - 1;
            int[] temp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) 
            { 
                if (nums[i] % 2 == 0)
                {
                    temp[secondCounter] = nums[i];
                    secondCounter++;
                } else
                {
                    temp[fromLastCount] = nums[i];
                    fromLastCount--;
                }
            }
            for (int b = 0; b < nums.Length; b++)
            {
                nums[b] = temp[b];
            }
            return nums;
        }
    }

}
