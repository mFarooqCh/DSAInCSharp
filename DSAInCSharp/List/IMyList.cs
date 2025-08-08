using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.List
{
    public interface IMyList<T>
    {
        T this[int index] { get; set; }  // Indexer
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);

        //ICollection
        int Count { get; }
        bool IsReadOnly { get; }
        void Add(T item);
        void Clear();
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool Remove(T item);
    }
}
