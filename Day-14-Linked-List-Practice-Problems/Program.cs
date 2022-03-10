using System;

namespace Day_14_Linked_List_Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist : operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("Adding 30 between 50 and 70");
            list.InsertAtParticulatPosition(2,30);
            list.Display();
        }
    }
}
