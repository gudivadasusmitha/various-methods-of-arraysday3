using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmarrays
{
    internal class vmlinkedlist
    {
        static public void main()
        {
            LinkedList<string> my_list = new LinkedList<string>();
            my_list.AddLast("zing");
            my_list.AddFirst("dum");
            my_list.AddLast("gind");
            my_list.AddFirst("susmi");
            foreach(string str in my_list)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }
        }
    }
}
