using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question2
    {
        public void Answer()
        {
            Console.Write("Enter A String : ");
            string str = Console.ReadLine();
            string output = StringReverse(str);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        private static string StringReverse(string s)
        {
            // Reverse using While loop  
            string reversestring = "";
            string output = "";
            int length;
            length = s.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + s[length];
                if (s[length].ToString() == " " || length == 0)
                {
                    output = " " + reversestring + output;
                    reversestring = string.Empty;
                }
                length--;
            }
            return output;
        }
    }
}
