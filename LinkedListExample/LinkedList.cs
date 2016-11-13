using System.Collections.Generic;

namespace LinkedListExample
{
    public class LinkedList
    {
        private Node<int> _head;
        
        public IEnumerable<int> Nodes
        {
            get
            {
                var temp = _head;
                while (temp != null)
                {
                    yield return temp.Data;
                    temp = temp.Next;
                }
            }
        }

        public void Add(int value)
        {
            var newNode = new Node<int>(value);
            if (_head == null || _head.Data >= newNode.Data)
            {
                newNode.Next = _head;
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.Next != null && current.Next.Data < newNode.Data)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void AddRange(params int[] values)
        {
            foreach (var value in values)
            {
                Add(value);
            }
        }
    }

    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
