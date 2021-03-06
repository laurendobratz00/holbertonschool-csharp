using System;

///<summary> returns the Queue's type </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;
    ///<summary> returns the Queue's type </summary>
    public Type CheckType()
    {
        return (typeof(T));
    }
    public class Node
    {
        public T value = default(T);
        public Node next = null;
        public Node(T i)
        {
            value = i;
        }
    }
    public void Enqueue(T value)
    {
        Node newnode = new Node(value);
        if (head == null)
        {
            head = newnode;
            tail = newnode;
        }
        else if (tail == null)
        {
            tail = newnode;
        }
        else
        {
            tail.next = newnode;
            tail = newnode;
        }
        count++;
    }
    public int Count()
    {
        return count;
    }
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else
        {
            return (head.value);
        }
    }
    public void Print()
    {
        Node current = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }
    public string Concatenate()
    {
        Node current = head;
        string result = "";
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (current != null)
        {
            result += current.value;
            if (current != tail && typeof(T) == typeof(string))
            {
                result += " ";
            }
            current = current.next;
        }
        return (result);
    }
}
