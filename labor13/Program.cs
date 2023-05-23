using System.Xml.Linq;

namespace labor11
{
    public class DoublyLinkedList
    {
        public DoublyNode head;
        public DoublyNode tail;
        public void Add(DoublyNode node)
        {
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            while (head.Previous != null) 
            { 
                head = head.Previous;
                count++;
            }
            while (tail.Next != null) 
            {       
                tail = tail.Next;
                count++;
            }
            count++;
        }
        public void AddFirst(DoublyNode node)
        {
            DoublyNode temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        public void Delete()
        {
            DoublyNode node = head;
            if (count == 0)
            {
                throw new ArgumentException("нельзя удалить из нулевого списка");
            }
            else if (count == 1)
            {
                var temp = new DoublyNode();
                head = tail = temp;
                count--;
            }
            else
            {
                var temp = tail.Previous;
                tail = new DoublyNode(tail.Previous.Data);
                tail.Previous = temp.Previous;
                count--;
            }
        }
        public DoublyNode GetFirst
        {
            get { return head; }
        }
        
        public DoublyNode GetLast
        {
            get { return tail; }
        }
        public string total()
        {
            DoublyNode node = head;
            string str = "";
            for (int i = 0; i < count; i++)
            {
                str += node.Data + " ";
                node = node.Next;
            }
            return str;
        }
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
    }
    public class DoublyNode
    {
        public DoublyNode() { }
        public DoublyNode(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public DoublyNode Previous { get; set; }
        public DoublyNode Next { get; set; }
    }
}
