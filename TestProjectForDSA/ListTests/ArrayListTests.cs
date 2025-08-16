using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForDSA.ListTests
{
    public sealed class ArrayListTests
    {
        [Fact]
        public void ShouldAddAnInt1()
        {
            var list = new DSAInCSharp.List.MyArrayList<int>(10);
            list.Add(100);
            list.Add(210);

            Assert.False(list.Contains(123));
        }
        
        [Fact]
        public void ShouldAddAnInt2()
        {
            var list = new DSAInCSharp.List.MyArrayList<int>(10);
            list.Add(100);
            list.Add(210);

            Assert.True(list.Contains(100));
        }
    }
}
