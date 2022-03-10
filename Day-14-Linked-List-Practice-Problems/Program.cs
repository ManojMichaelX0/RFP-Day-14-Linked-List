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
            Console.WriteLine("Popping first Element in List");
            list.PoP_First_element();
            list.Display();
            //Console.WriteLine("Popping Last Element in List");
            //list.PoP_Last_element();
            Console.WriteLine("Search Element and Adding 40 after 30");
            int a = list.Search(30);
            list.InsertAtParticulatPosition(a+1,40);
            list.Display();

        }
    }
}
