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
            binarySearch.Add(22);
            binarySearch.Add(40);
            binarySearch.Add(60);
            binarySearch.Add(95);
            binarySearch.Add(11);
            binarySearch.Add(65);
            binarySearch.Add(3);
            binarySearch.Add(16);
            binarySearch.Add(63);
            binarySearch.Add(67);
            binarySearch.Display();
            Console.WriteLine("Searching 63 in binary tree \n");
            bool result = binarySearch.Search(63, binarySearch);
            Console.WriteLine(result);
        
        }      
    }
}
