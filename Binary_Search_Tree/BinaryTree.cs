using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class BinaryTree<T>where T : IComparable<T>
    {
        public T Data { get; set; }
        public bool result;
        public BinaryTree<T> LTree { get; set; }
        public BinaryTree<T> RTree { get; set; }
        public BinaryTree(T data)
        {
            this.Data = data;
            this.RTree = null;
            this.LTree = null;
        }
        public void Add(T item)
        {
            T currentNodeValue = this.Data;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LTree == null)
                    this.LTree = new BinaryTree<T>(item);
                else
                    this.LTree.Add(item);
            }
            else
            {
                if (this.RTree == null)
                    this.RTree = new BinaryTree<T>(item);
                else
                    this.RTree.Add(item);
            }
        }
        private int LCount = 0, RCount = 0;
        public void Display()
        {
            if (this.LTree != null)
            {
                this.LCount++;
                this.LTree.Display();

            }
            Console.WriteLine(this.Data.ToString());
            if (this.RTree != null)
            {
                this.RCount++;
                this.RTree.Display();
            }
        }
        public bool Search(T element, BinaryTree<T> node)
        {

            if (node == null)
                return false;
            if (node.Data.Equals(element))
            {
                Console.WriteLine("Number is found :" + " " + node.Data);
                result = true;
            }
            else
                Console.WriteLine("Current {0} in BST", node.Data);
            if (element.CompareTo(node.Data) < 0)
                Search(element, node.LTree);
            if (element.CompareTo(node.Data) > 0)
                Search(element, node.RTree);
            return result;
        }

    }
}

