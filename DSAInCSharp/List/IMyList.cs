namespace DSAInCSharp.List
{
    public interface IMyList<T>
    {
        //T this[int index] { get; set; }  // Indexer
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
        bool Next();
        void Start();
        void Add(T item);
        void Clear();
        bool Contains(T item);
        bool Remove(T item);
        void Remove();
        int Length();
    }
}
