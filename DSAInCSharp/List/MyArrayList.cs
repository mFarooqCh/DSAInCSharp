using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.List;

public sealed class MyArrayList : IMyList
{
    private int[] _array;
    private int _current = 1;
    private int _size = 0;

    public MyArrayList(int capacity = 100)
    {
        _array = new int[capacity + 1];
        _size = capacity;
    }

    public void Add(int number)
    {
        _array[_current] = number;
        _current++;
    }

    public int Get()
    {
        return _array[_current];
    }

    public void Remove()
    {
        _array[_current] = 0;
        _current--;
    }

    public bool Find(int number)
    {
        throw new NotImplementedException();
    }

    public bool Update(int number)
    {
        throw new NotImplementedException();
    }

    public int Size()
    {
        throw new NotImplementedException();
    }

    public void Back()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}