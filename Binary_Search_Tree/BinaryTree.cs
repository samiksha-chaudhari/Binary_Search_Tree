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
        public BinaryTree(T data) //constuctor
        {
            this.Data = data;
            this.RTree = null;
            this.LTree = null;
        }

        /// <summary>
        /// method to add data in BTS
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            T currentNodeValue = this.Data;
            if ((currentNodeValue.CompareTo(data)) > 0)
            {
                if (this.LTree == null)
                    this.LTree = new BinaryTree<T>(data);
                else
                    this.LTree.Add(data);
            }
            else
            {
                if (this.RTree == null)
                    this.RTree = new BinaryTree<T>(data);
                else
                    this.RTree.Add(data);
            }
           // Console.WriteLine("data added is:" +data);
        }
        private int LCount = 0, RCount = 0;

        /// <summary>
        /// method to display data
        /// </summary>
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

        /// <summary>
        /// method to check data is present or not in BTS
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
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

