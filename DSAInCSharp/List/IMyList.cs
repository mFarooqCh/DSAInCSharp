using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAInCSharp.List
{
    public interface IMyList
    {
        public void Add(int number);
        /// <summary>
        /// Returns the first occurrence of the current number in the list.
        /// </summary>
        /// <returns></returns>
        public int Get();
        /// <summary>
        /// Remove the element at current index and sets the current index to the previous element.
        /// </summary>
        public void Remove();
        public bool Find(int number);
        /// <summary>
        /// Updates the first occurrence of the specified number in the list. 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool Update(int number);
        /// <summary>
        /// Returns the number of elements in the list.
        /// </summary>
        /// <returns></returns>
        public int Size();
        /// <summary>
        /// Sets the value of current = current - 1
        /// </summary>
        public void Back();
        /// <summary>
        /// Sets the current index = 1
        /// </summary>
        public void Start();
        /// <summary>
        /// Sets the current = size 
        /// </summary>
        public void Stop();
    }
}
