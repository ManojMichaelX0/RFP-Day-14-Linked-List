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
            list.Add(30);
            list.Add(70);
            list.Display();
            //Console.WriteLine("Popping first Element in List");
            //list.PoP_First_element();
            Console.WriteLine("Popping Last Element in List");
            list.PoP_Last_element();
            list.Display();

        }
    }
}
