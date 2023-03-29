using System.Collections.Generic;

namespace Day14_LinkedlistProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");
            Linkedlist linkedList = new Linkedlist();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("**********************************************************");
        }
    }
}