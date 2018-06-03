﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            testList();

            string input = Console.ReadLine();
            return;
            switch (input)
            {
                case "heap":
                    testHeap();
                    break;
                case "bst":
                    testBST();
                    break;
            }
            testHeap();
        }

        static void testList()
        {
            List myList = new List(10);
            myList.insert(7);
            myList.insert(13);
            myList.insert(33);
            myList.insert(1);
            myList.insert(17);
            myList.insert(24);
            myList.insert(5);
            myList.insert(20);
            myList.insert(55);
            myList.insert(41);
            myList.insert(0);
            myList.insert(-5);
            myList.print();
            if(myList.find(21))
                Console.WriteLine("Value found");
            else
                Console.WriteLine("Value not found");
        }

        static void testBST()
        {
            BST bst = new BST(10);

            bst.insert(16);
            bst.insert(13);
            bst.insert(12);
            bst.insert(15);
            bst.insert(20);
            bst.insert(18);
            bst.insert(25);
            bst.insert(6);
            bst.insert(3);
            bst.insert(1);
            bst.insert(4);
            bst.insert(8);
            bst.insert(7);
            bst.insert(9);
            bst.insert(14);

            bst.printInOrder();

            int steps = 0; ;
            BST result = bst.find(34, ref steps);
            if (result == null)
                Console.WriteLine("Value not found after {0} steps", steps);
            else
                Console.WriteLine("Value found after {0} steps", steps);
        }

        static void testTree()
        {
            //int* a;

            return;
            Node tree = new Node(10);
            tree.insert(10);
        }


        static void testHeap()
        {
            int[] data = new int[] { 18, 16, 15, 11, 9, 12, 11, 6, 7, 3};
            Heap heap = new Heap(data);
            Console.WriteLine("Original heap");
            heap.print();
            Console.WriteLine("Heap after adding value 22");
            heap.insertValue(22);
            heap.print();
            Console.WriteLine("Heap after deleting max value");
            heap.deleteMax();
            heap.print();
        }
    }
}
