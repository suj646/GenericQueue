﻿using System;
using System.Collections.Generic;

namespace GenericQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue<string> student = new Queue<string>();
            student.Enqueue("Pankaj");
            student.Enqueue("Pawan");
            student.Enqueue("sujit");
            student.Enqueue("vishal");
            student.Enqueue("pandit");
            print(student);
            Console.WriteLine("\nRemoving {0} from List. \nNew list is : ", student.Dequeue());
            print(student);
            string[] city = { "pune", "Aurangabad", "Nashik" };
            Queue<string> citylist = new Queue<string>(city);
            Console.WriteLine("\nPrinting City List");
            print(citylist);
            Console.WriteLine("Count{0}", citylist.Count);
        }
        public static void print(Queue<string> q)
        {
            foreach (string s in q)
            {
                Console.Write(s.ToString() + " ");
            }
        }
    }
}
