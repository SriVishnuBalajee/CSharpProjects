using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day1
{
    internal class ValueTypeLesson
    {
        public static void typeValueTypes() {
            byte b1 = 255;
            Console.WriteLine(b1);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            float f1 = 52.678f;
            long l1 = 9150012442L;
            Console.WriteLine(l1);
            Console.WriteLine(f1);
            double d1 = 3.33d;
            Console.WriteLine(d1);
            decimal m1 = 3.88888888m;
            Console.WriteLine(m1);
            char c1 = 'A';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            int y = 66;
            char c2 = (char)y;
            Console.WriteLine(c2);
            bool flag = true;
            Console.WriteLine(flag);
        
        }
        public static void TestMethod()
        {
            Console.WriteLine("Test");

        }
        
    
        

    }


}
