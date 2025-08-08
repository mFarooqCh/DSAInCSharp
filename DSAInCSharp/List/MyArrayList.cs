using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.List;

public sealed class MyArrayList<T> : IMyList<T>
{
    private T[] _items;
    private int _size = 0;

    public MyArrayList(int capacity = 100)
    {
        _items = new T[capacity + 1];
        _size = capacity;
    }

    public T this[int index]
    {
        get {
            if (index < 0 || index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index));
            else
                return _items[index];
        }
        set
        {
            if (index < 0 || index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index));
            _items[index] = value;
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(_items[i], item))
            {
                return i;
            }
        }

        return -1;
        //return Array.IndexOf(_items, item, 0);
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _size)
            throw new ArgumentOutOfRangeException(nameof(index));
        if (_size >= _items.Length)
            //Resize();
        _items[index] = item;
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }
}