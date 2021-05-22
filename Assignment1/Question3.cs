using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question3
    {
        public void Answer()
        {
            string input = string.Empty;
            int num = 0;
            int i = 0;

            int[] list = new int[4];
            try
            {
                while (i < list.Length)
                {
                    Console.WriteLine("Please enter a number to add to the array:  ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out num))
                    {
                        list[i] = num;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number!");
                    }
                }
                int sum = minSum(list);
                Console.WriteLine("Sum of array : " + sum);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public static int minSum(int[] arr)
        {
            Array.Sort(arr);
            int j = 1;
            int sum = 0;
            Dictionary<int, int> numlist = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {

                if (!numlist.ContainsValue(arr[i]))
                {
                    numlist.Add(i, arr[i]);
                }
                else
                {
                    while (numlist.ContainsValue(arr[i] + j))
                    {
                        j++;
                    }
                    numlist.Add(i, arr[i] + j);
                }
                sum = sum + numlist[i];
            }
            return sum;
        }
    }
}
