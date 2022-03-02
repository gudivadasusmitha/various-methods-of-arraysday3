using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmarrays
{
    internal class vmarraylist
    {
        public static void main()
        {
            vmarraylist mylist = new vmarraylist();
            mylist.add("A");
            mylist.add("b");
            mylist.add("c");
            mylist.add("d");
            Console.WriteLine(mylist.isflexiblesize);
            Console.WriteLine(mylist.isreadonly);
        
        }
    }
}
