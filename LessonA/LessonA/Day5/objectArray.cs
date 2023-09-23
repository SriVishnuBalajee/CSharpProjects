using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day5
{
    internal class objectArray
    {
        public static void object1()
        {
            Object[] obj = new Object[10];
            obj[0] = "hello";
            obj[1] = 1;
            obj[2] = null;
            obj[3] = " ";
            obj[4] = 4;
            obj[5] = new objectArray();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(obj[i]);
            }
        }

        
    }
}
