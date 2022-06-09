using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT
{
    public class Program
    {
        static void Main(string[] args)
        {
            BSTree newTree = new BSTree();
            newTree.Add(5);
            newTree.Add(12);
            newTree.Add(3);
            newTree.InOrder();
        }
    }
}
