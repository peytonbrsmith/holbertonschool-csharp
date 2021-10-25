using System;

class Queue<T>
{

    Node head;
    Node tail;
    int count;
    public System.Type CheckType()
    {
       return (typeof(T));
    }

    public class Node
    {
        public object value = null;
        public Node next = null;

        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    public void Enqueue(T value)
    {
        Node node = new Node();
        node.Value = value;

        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }

        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T Val = (T) head.Value;
        head = head.next;
        count--;
        return Val;
    }

    public int Count()
    {
        return count;
    }

    public object Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.Value;
    }

    public void Print()
    {
        Node current = head;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.next;
        }
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) == typeof(string) || typeof(T) == typeof(char))
        {
            string values = "";

            Node current = head;
            while (current != null)
            {
                values += current.Value;
                if (current.Value.GetType() == typeof(string))
                {
                    values += " ";
                }
                current = current.next;
            }

            return values;
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return null;
    }
}
