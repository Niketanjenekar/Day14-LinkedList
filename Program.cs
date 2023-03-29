using System;
using System.Collections.Generic;

namespace Day14_LinkedlistProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");
            Console.WriteLine("**********************************************************");
            Linkedlist linkedList = new Linkedlist();
            linkedList.Add(56);
            Console.WriteLine("Node with data 56 is first Created");
            Console.WriteLine("**********************************************************");
            //linkedList.Add(30);
            //Console.WriteLine("Next Append 30 to 56");
            Console.WriteLine("**********************************************************");
            linkedList.Add(70);
            Console.WriteLine("Finally Append 70 to 30");
            Console.WriteLine("**********************************************************");
            linkedList.Display();
            Console.WriteLine("**********************************************************");
            linkedList.InsertAtPerticularPosition(2, 30);
            Console.WriteLine("30 has been inserted between 56 anf 70 ");
            linkedList.Display();




        }
    }
}