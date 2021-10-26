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
}
