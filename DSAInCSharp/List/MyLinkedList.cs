using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.List
{
    public sealed class MyLinkedList<T> : IMyList<T>
    {
        private Node<T>? _head;
        private Node<T>? _current, _lastCurrent;
        private int _size;
        public MyLinkedList()
        {
            _head = new Node<T>();
            _current = null;
            _lastCurrent = null;
            _size = 0;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool Next()
        {
            if(_current is null)
                return false;
            _lastCurrent = _current;
            _current = _current.Next;
            if(_size == 0 || _current is null )
                return false;
            return true;
        }

        public void Start()
        {
            _lastCurrent = _head;
            _current = _head;
        }
        public T Get()
        {
            if (_current is null)
                throw new InvalidOperationException("No current item. Call Start() or Next() first.");
            return _current.Value;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (_current is null)
            {
                _head.Next = newNode;
                _lastCurrent = _head;
                _current = newNode;
            }
            else
            {
                newNode.Next = _current.Next;
                _current.Next = newNode;
                _lastCurrent = _current;
                _current = newNode;
            }

            _size++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            if (_current is null || _current == _head) return;
            _lastCurrent.Next = _current.Next;
            _current = _lastCurrent.Next;
            _size--;
        }

        public int Length()
        {
            return _size;
        }
    }

    internal sealed class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null!;
        }

        public Node()
        {
            Value = default!;
            Next = null!;
        }
    }
}
