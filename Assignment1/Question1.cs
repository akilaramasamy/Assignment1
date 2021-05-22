using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question1
    {
        public void Answer()
        {
            string input = string.Empty;
            int num = 0;
            int i = 0;
            int target = 0;
            int[] list = new int[6];
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

                Console.WriteLine("Please enter the target number:  ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num))
                {
                    target = num;
                }
                
                int[] output =targetRange(list, target);
                Console.WriteLine("[{0},{1}]", output[0], output[1]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        public int[] targetRange(int[] list, int target)
        {
            //initialize the values
            int firstIndex = -1, lastIndex = -1;
            int[] output = new int[2];

            for (int i = 0; i <= list.Length-1; i++)
            {
                //1.if no match continue the loop
                if (target != list[i])
                    continue;
                //2.assign first index only first time
                if (firstIndex == -1)
                    firstIndex = i;
                //3.assign last index
                lastIndex = i;
            }

            output[0] = firstIndex;
            output[1] = lastIndex;

            //return the output
            return output;
        }
    }

}
