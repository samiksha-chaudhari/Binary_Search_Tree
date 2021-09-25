using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinaryTree<int> binarySearch = new BinaryTree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Display();
        }
    }
}
