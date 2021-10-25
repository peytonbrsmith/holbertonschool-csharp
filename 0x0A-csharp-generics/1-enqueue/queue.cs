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

    public int Count()
    {
        return count;
    }
}
