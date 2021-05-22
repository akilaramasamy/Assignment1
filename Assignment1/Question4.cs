using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question4
    {
        public void Answer()
        {
            Console.Write("Enter A String : ");
            string str = Console.ReadLine();
            string output = FreqSort(str);
            Console.WriteLine(output);
            Console.ReadLine();
        }
        public static string FreqSort(string s)
        {
            string output = "";
            int i = 0;
            int length;
            length = s.Length - 1;
            Dictionary<string, int> list = new Dictionary<string, int>();

            while (i <= length)
            {
                string item = s[i].ToString();
                if (list.ContainsKey(item))
                    list[item] += 1;
                else
                    list.Add(item, 1);
                i++;
            }
            // Use OrderBy method.
            foreach (var item in list.OrderByDescending(i => i.Value))
            {
                for (int j = 0; j < item.Value; j++)
                    output = output + item.Key;
            }

            return output;
        }
    }
}
