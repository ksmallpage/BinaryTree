using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree mytree = new Tree(78);
            mytree.Add(100);
            mytree.Add(120);
            mytree.Add(12);
            mytree.Add(14);
            mytree.Add(11);
            mytree.Find(14);
            
        }
    }
}
