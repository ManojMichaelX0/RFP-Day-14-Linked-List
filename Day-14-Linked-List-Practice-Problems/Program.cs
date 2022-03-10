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
            int a = list.Search(56);
            list.InsertAtParticulatPosition(a+1,30);
            int b = list.Search(30);
            list.InsertAtParticulatPosition(b + 1, 70);
            list.Display();
            //Console.WriteLine("Popping first Element in List");
            //list.PoP_First_element();
            //list.Display();
            //Console.WriteLine("Popping Last Element in List");
            //list.PoP_Last_element();
            //Console.WriteLine("Search Element and Adding 40 after 30");
            //int a = list.Search(30);
            //Console.WriteLine("index position of element 30 is :" + a);
            //list.InsertAtParticulatPosition(a + 1, 40);
            //list.Display();
            //Console.WriteLine("Popping element 40 in List");
            //int b = list.Search(40);
            //Console.WriteLine("index position of element 40 is :" + b);
            //list.PoP_Paricular_element(3);
            //list.Display();

        }
    }
}
