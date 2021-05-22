using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question6
    {
        public void Answer()
        {
            char[] list = { 'f', 'b', 'g', 'a', 'b', 'c' };
            bool output = ContainsDuplicate(list, 4);
            Console.WriteLine("Result :" + output);
        }
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (j - i <= k)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
