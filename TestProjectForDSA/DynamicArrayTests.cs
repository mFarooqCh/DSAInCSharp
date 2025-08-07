using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSAInCSharp.DynamicProgramming;

namespace TestProjectForDSA
{
    public class DynamicArrayTests
    {
        [Fact]
        public void ShouldRun()
        {
            //var input = new object[] { "Array", 2, "pushback", 0, "pushback", 1, "pushback", 2, "getSize", "getCapacity" };
            List<object> output = new List<object>();
            DynamicArray arr = null;

            var commands = new List<string> {
                "Array", "pushback", "pushback", "pushback", "getSize", "getCapacity"
            };
            var args = new List<object> {
                2, 0, 1, 2, null, null
            };

            for (int i = 0; i < commands.Count; i++)
            {
                string cmd = commands[i];
                object arg = args[i];

                switch (cmd)
                {
                    case "Array":
                        arr = new DynamicArray((int)arg);
                        output.Add(null);
                        break;
                    case "pushback":
                        arr.PushBack((int)arg);
                        output.Add(null);
                        break;
                    case "getSize":
                        output.Add(arr.GetSize());
                        break;
                    case "getCapacity":
                        output.Add(arr.GetCapacity());
                        break;
                    default:
                        output.Add("Unknown command");
                        break;
                }
            }

            Console .WriteLine("[" + string.Join(", ", output) + "]");
        }
    }
}
