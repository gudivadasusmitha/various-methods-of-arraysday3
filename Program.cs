using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first = new List<string>();
            first.Add("susmi");
            first.Add("ch46");
            first.Add("dhanush");
            first.Add("divya");
            first.Add("deepu");
            first.Add("sunny");
            first.Remove("susmi");
            first.Insert(0,"vamsi");
            foreach (string st in first)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }
        }
    }
}
