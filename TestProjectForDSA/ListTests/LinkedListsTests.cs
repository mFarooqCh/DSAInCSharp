using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForDSA.ListTests
{
    public sealed class LinkedListsTests
    {
        [Fact]
        public void ShouldInitAndIterate()
        {
            var list = new DSAInCSharp.List.MyLinkedList<int>();
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Start();
            while (list.Next())
            {
                Console.Write(list.Get());
            }
        }
    }
}
