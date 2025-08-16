namespace DSAInCSharp.List;

public sealed class MyArrayList<T> : IMyList<T>
{
    private T[] _items;
    private int _size = 0;

    public MyArrayList(int capacity = 100)
    {
        _items = new T[capacity + 1];
    }

    //public T this[int index]
    //{
    //    get
    //    {
    //        if (index < 0 || index >= _size)
    //            throw new ArgumentOutOfRangeException(nameof(index));
    //        else
    //            return _items[index];
    //    }
    //    set
    //    {
    //        if (index < 0 || index >= _size)
    //            throw new ArgumentOutOfRangeException(nameof(index));
    //        _items[index] = value;
    //    }
    //}

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
            Resize();
        _items[index] = item;
        _size++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > _size)
            throw new ArgumentOutOfRangeException(nameof(index));
        _items[index] = default; // Clear the item at index
        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1]; // Shift items to the left
        }

        _size--;
    }
    public void Add(T item)
    {
        if (_size >= _items.Length)
        {
            // Resize the array
            Resize();
        }
        _items[_size] = item;
        _size++;
    }
    private void Resize()
    {
        var newItems = new T[_items.Length * 2];
        Array.Copy(_items, newItems, _size);
        _items = newItems;
    }

    public void Clear()
    {
        _items = new T[_items.Length]; // Reset the array
        _size = 0; // Reset the size
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < _size; i++)
        {
            if (EqualityComparer<T>.Default.Equals(_items[i], item))
            {
                return true;
            }
        }

        return false;
    }

    public bool Remove(T item)
    {
        var index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }
        return false;
    }
}