using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int a_value)
        {
            value = a_value;
            left = null;
            right = null;
        }
    }

    public class BSTree
    {
        Node root;
        public BSTree()
        {
            root = null;
        }
        private void Add(ref Node _root, int value)
        {
            Node newNode = new Node(value);
            if (_root == null)
            {
                _root = newNode;
                return;
            }
            if (value < _root.value)
            {
                Add(ref _root.left, value);
                return;
            }
            Add(ref _root.right, value);
        }
        private void InOrder(Node _root)
        {
            if (_root == null)
            {
                return;
            }
            InOrder(_root.left);
            Console.WriteLine(_root.value);
            InOrder(_root.right);
        }
        public void InOrder()
        {
            InOrder(root);
        }
        public void Add(int value)
        {
            Add(ref root, value);
        }
    }
}
