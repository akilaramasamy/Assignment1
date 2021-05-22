using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question5
    { 
        public void Answer()
        {
            int[] nums1 = { 5, 6, 1, 2, 6, 7 };
            int[] nums2 = { 9, 6, 3, 6, 7 };
            int[] output = new int[5];
            Intersect1(nums1, nums2);

        }
        public static void Intersect1(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0, k = 0;
            int n = nums1.Length;
            int m = nums2.Length;

            Array.Sort(nums1);
            Array.Sort(nums2);

            int[] output = new int[5];
            while (i < n && j < m)
            {
                if (nums1[i] > nums2[j])
                    j++;
                else if (nums2[j] > nums1[i])
                    i++;
                else
                {
                    // when both are equal
                    output[k] = nums1[i];
                    Console.Write(nums1[i] + " ");
                    i++;
                    j++;
                    k++;
                }
            }
        }

    }
}
