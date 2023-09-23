using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day5
{
    internal class task
    { public static void DoTask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x) //ref means address of the variable.
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
    }
}
