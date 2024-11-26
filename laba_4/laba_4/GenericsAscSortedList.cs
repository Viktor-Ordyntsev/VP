using System;

namespace SortedListExample
{
    public class GenericsAscSortedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;
            public Node Prev;

            public Node(T value)
            {
                Value = value;
                Next = null;
                Prev = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count => count;

        public void Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = tail = newNode;
            }
            else if (item.CompareTo(head.Value) <= 0)
            {
                // Add at the beginning
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            else if (item.CompareTo(tail.Value) >= 0)
            {
                // Add at the end
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            else
            {
                // Add in the middle
                Node current = head;
                while (current != null && current.Value.CompareTo(item) < 0)
                {
                    current = current.Next;
                }

                newNode.Next = current;
                newNode.Prev = current.Prev;

                if (current.Prev != null)
                {
                    current.Prev.Next = newNode;
                }

                current.Prev = newNode;
            }

            count++;
        }

        public T Max()
        {
            if (tail == null)
                throw new InvalidOperationException("List is empty.");
            return tail.Value;
        }

        public T Min()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty.");
            return head.Value;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public override string ToString()
        {
            Node current = head;
            string result = "";

            while (current != null)
            {
                result += current.Value + " ";
                current = current.Next;
            }

            return result.Trim();
        }
    }
}