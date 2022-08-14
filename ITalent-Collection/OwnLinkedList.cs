using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_Collection
{
    public class OwnLinkedList<T> : IEnumerable<T>
    {
        Node<T>? Head { get; set; }

        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
        }

        public T this[int index]
        {
            get
            {
                return FindAt(index).data;
            }
            set
            {
                Node<T> node = FindAt(index);
                node.data = value;
            }

        }

        public Node<T> FindAt(int index)
        {
            if (index > Count)
                throw new Exception("sınır aşıldı");
            Node<T> iterator = Head;
            for (int i = 0; i < index; i++)
            {
                iterator = iterator.nextNode;
            }
            return iterator;
        }

        public void RemoveAt(int index)
        {
            if (index > Count)
                throw new Exception("sınır aşıldı");

            Node<T> iterator = Head;
            for (int i = 0; i < index - 1; i++)
            {
                iterator = iterator.nextNode;
            }
            Node<T> deletedNode = iterator.nextNode;
            iterator.nextNode = iterator.nextNode.nextNode;
            deletedNode = null;
        }

        public void InsertFirst(T value)
        {
            Node<T> newNode = new Node<T> { data = value };
            if (_count == 0)
                Head = newNode;
            else
            {
                newNode.nextNode = Head;
                Head = newNode;
            }
            ++_count;

        }

        public void InsertLast(T value)
        {
            if (_count == 0)
                InsertFirst(value);
            else
            {
                Node<T> oldLastNode = Head;
                Node<T> newLastNode = new Node<T> { data = value };
                while (oldLastNode.nextNode != null)
                {
                    oldLastNode = oldLastNode.nextNode;
                }
                oldLastNode.nextNode = newLastNode;
                ++_count;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new OwnLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class OwnLinkedListEnumerator<T> : IEnumerator<T>
    {
        private Node<T> _head;


        public OwnLinkedListEnumerator(Node<T> head)
        {
            _head = head;
        }

        public T Current => _head.data;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_head == null) return false;
            _head = _head.nextNode;
            return (_head != null);
        }
        public void Dispose()
        {

        }

        public void Reset()
        {

        }
    }
}
