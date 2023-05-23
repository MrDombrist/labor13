using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using labor11;
namespace labor13
{
    class Demo
    {
        static void Main(string[] args)
        {
            //task 1
            //DoublyLinkedList a = new DoublyLinkedList();
            //Console.WriteLine("Введите число: ");
            //int b;
            //string c = Console.ReadLine();
            //while (c != "")
            //{
            //    b = Convert.ToInt32(c);
            //    if (Math.Abs(b) <= 1000)
            //    {
            //        if (a.Count < 2)
            //        {
            //            a.Add(b);
            //        }
            //        else
            //        {
            //            if (Math.Abs(a.GetFirst.Data - b) < Math.Abs(a.GetLast.Data - b))
            //            {
            //                a.AddFirst(b);
            //            }
            //            else { a.Add(b); }
            //        }
            //        Console.WriteLine("Введите число: ");
            //        c = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("число должно быть меньше по модулю 1000");
            //    }
            //}
            //Console.WriteLine("Размер: " + a.Count);
            //Console.WriteLine("Список: " + a.total());

            //task 1 (2a)
            //DoublyLinkedList a = new DoublyLinkedList();
            //DoublyLinkedList b = new DoublyLinkedList();
            //int f;
            //string c = Console.ReadLine();
            //while (c != "")
            //{
            //    f = Convert.ToInt32(c);
            //    if (f >= 0)
            //    {
            //        a.Add(new DoublyNode(f));
            //    }
            //    else
            //    {
            //        b.Add(new DoublyNode(f));
            //    }
            //    Console.WriteLine("Введите число: ");
            //    c = Console.ReadLine();
            //}
            //if (a.Count % 2 != 0)
            //{
            //    throw new Exception("В первом списке нечетное количество элементов!");
            //}
            //var temp = a.GetFirst;
            //int k = a.Count / 2;
            //for (int i = 0; i < k - 1; i++)
            //{
            //    temp = temp.Next;
            //}
            //var temp1 = temp.Next;
            //temp.Next = b.head;
            //DoublyLinkedList l = new DoublyLinkedList();
            //l.Add(temp);
            //l.Add(temp1);
            //l.total();
            //Console.WriteLine("Размер: " + l.Count);
            //Console.WriteLine("Список: " + l.total());



            //task 1(2b)
            //    DoublyLinkedList a = new DoublyLinkedList();
            //    DoublyLinkedList b = new DoublyLinkedList();
            //    int f;
            //    string c = Console.ReadLine();
            //    while (c != "")
            //    {
            //        f = Convert.ToInt32(c);
            //        if (f >= 0)
            //        {
            //            a.Add(new DoublyNode(f));
            //        }
            //        else
            //        {
            //            b.Add(new DoublyNode(f));
            //        }
            //        Console.WriteLine("Введите число: ");
            //        c = Console.ReadLine();
            //    }
            //    if (a.Count % 2 != 0)
            //    {
            //        throw new Exception("В первом списке нечетное количество элементов!");
            //    }
            //    var temp = a.GetFirst;
            //    var temp1 = b.GetFirst;
            //    DoublyLinkedList l = new DoublyLinkedList();
            //    while (temp1 != null && temp!= null)
            //    {
            //        l.Add(new DoublyNode(temp.Data));
            //        l.Add(new DoublyNode(temp1.Data));
            //        temp = temp.Next;
            //        temp1= temp1.Next;
            //    }
            //    if (temp == null && temp1!=null)
            //    {
            //        l.Add(temp1);
            //    }
            //    else if(temp1 == null&& temp!=null)
            //    {
            //        l.Add(temp);
            //    }
            //    l.total();
            //    Console.WriteLine("Размер: " + l.Count);
            //    Console.WriteLine("Список: " + l.total());

            //task 1(3)
            //var a = new System.Collections.Generic.LinkedList<int>();
            //Console.WriteLine("Введите число: ");
            //int b;
            //string c = Console.ReadLine();
            //while (c != "")
            //{
            //    b = Convert.ToInt32(c);
            //    if (Math.Abs(b) <= 1000)
            //    {
            //        if (a.Count < 2)
            //        {
            //            a.AddLast(b);
            //        }
            //        else
            //        {
            //            if (Math.Abs(a.First.Value - b) < Math.Abs(a.Last.Value - b))
            //            {
            //                a.AddFirst(b);
            //            }
            //            else { a.AddLast(b); }
            //        }
            //        Console.WriteLine("Введите число: ");
            //        c = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("число должно быть меньше по модулю 1000");
            //    }
            //}
            //int[] d = new int[a.Count];
            //d = a.ToArray<int>();
            //Console.WriteLine("Размер: " + a.Count);
            //Console.Write("Список: ");
            //foreach(int i in d)
            //    Console.Write(i+ " ");
           

            //task 2
            //тут нужно было ввести еще перменную Previos но я решил этого не делать, от чего и не вышла данная реализация, но сам класс готов под названием Circle.cs
        }
    }
}
