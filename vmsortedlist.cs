using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmarrays
{
    internal class vmsortedlist
    {
        static void main(string[] args)
        {
            var num = new SortedList<string, int>();
            num.Add("apple", 3);
            num.Add("banana", 5);
            num.Add("guvva", 17);
            num.Add("orange", 13);
            num.Add("df", 34);
            num.Clear();
            foreach (var pair in num)
            {
                Console.WriteLine(pair);
                Console.ReadLine();
            }

        }
        



    }
}
