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
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("**********************************************************");

            linkedList.Add(30);
            Console.WriteLine("Next 30 will be added to 70 ");
            Console.WriteLine("**********************************************************"); ;

            linkedList.Add(56);
            Console.WriteLine("Finally 56 will be added to 30");
            Console.WriteLine("**********************************************************");

            Console.WriteLine("LinkedList Sequence is : 56->30->70");
            Console.WriteLine("**********************************************************");




        }
    }
}