using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace labor13
{
    public class Node1<T> 
    {
        public Node1() { }
        public Node1(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node1<T> Next { get; set; }
    }

    public class Circle<T> 
    {
        int count;
        public int Count { get { return count; } }
        public Circle() { }
        Node1<T> tail { get; set; }
        Node1<T> head { get; set; }
        public void add(Node1<T> a)
        {
            if(head==null)
            {
                head=a;
                tail = a;
                tail.Next = head;
            }
            else
            {
                a.Next = head;
                tail.Next = a;
                tail = a;
            }
            count++;
        }
        public Circle(T[] a)
        {
            for(uint i = 0; i < a.Length; i++)
            {
                add(new Node1<T>(a[i]));
            }
        }
        public T[] GetArr()
        {
            T[] a = new T[count];
            var b = head;
            for(int i = 0; i < count; i++)
            {
                a[i] = b.Data;
                b = b.Next;
            }
            return a;
        }
        public Node1<T> Head { get { return head;} }
        public bool Check(T a)
        {
            var temp = head;
            for (int i = 0; i < count; i++)
            {
                if (temp.Data.Equals(a))
                {
                    return true;
                }
                else { temp = temp.Next; }
            }
            return false;
        }
        public void addNext(T a, Node1<T> b)
        {
            if (Check(a) == false)
            {
                Console.WriteLine("Нет данного элемента!");return;
            }
            else if (head == null) { head = b; count++; }
            else
            {
                var temp = head;
                while (!temp.Data.Equals(a))
                {
                    temp = temp.Next;
                }
                var temp2 = temp.Next;
                temp.Next = b;
                b.Next = temp2;
                count++;
            }
        }
        public void addUntil(T a, Node1<T> b)
        {
            if (Check(a) == false)
            {
                Console.WriteLine("Нет данного элемента!"); return;
            }
            else if (head == null) { head = b; count++; }
            else
            {
                var temp = head;
                int j = 0;
                while (!temp.Data.Equals(a))
                {
                    temp = temp.Next;j++;
                }
                T[] nk = new T[count];
                nk = GetArr();
                var temp2 = head;
                while (!temp2.Data.Equals(nk[j-1]))
                {
                    temp2 = temp2.Next;
                }
                temp2.Next = b;
                b.Next = temp;
                count++;
            }
        }
        public void addNext(Circle<T> a, T b, T c)
        {
            if (Check(b) == false|| a.Check(c)==false)
            {
                Console.WriteLine("Нет данного элемента!"); return;
            }
            else if (head == null || a.head==null) { throw new Exception("Список пуст"); }
            else
            {
                var temp = head;
                while (!temp.Data.Equals(a))
                {
                    temp = temp.Next;
                }
                var temp1 = a.head;int j = 0;
                while (!temp1.Data.Equals(c))
                {
                    temp1 = temp1.Next;j++;
                }
                T[] d= new T[a.Count-j];
                for(int i = 0; i < d.Length; i++)
                {
                    d[i] = temp1.Data; temp1 = temp1.Next;
                }
                Circle<T> sp = new Circle<T>(d);
                var temp2 = temp.Next;
                var temp3 = sp.head;
                for(int i = 0; i < sp.Count; i++)
                {
                    var temp4 = new Node1<T>(temp3.Data);
                    temp.Next = temp4;
                    temp = temp.Next;
                    temp3 = temp3.Next;
                    count++;
                }
                temp.Next = temp2;
            }
        }
        public string Output()
        {
            string str = "";
            var temp = head;
            for(int i = 0; i < count; i++)
            {
                str += temp.Data+ "\n";
                temp = temp.Next;
            }
            return str;
        }
    }
}
