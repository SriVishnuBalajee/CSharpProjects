using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day7
{
    internal class lambdaDemo
    {
        public static void DemoA()
        {
            Func<int, int> foo = x => x / 2;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        public static void DemoB()
        {
            Func<int> foo = () => 100;
            int i = 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double> foo = (x, y) => (x + y) / 2;
            int i = 100;
            int j = 100;
            double result = foo(i, j);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            Func<int, double> foo = x => (double)x / 2;
            int i = 100;
            double result = foo(i);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {
            Func<double, int> foo = x => (int)x / 2;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        static void Echo(Func<string> foo)
        {

            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");

        }
        static double Dotrans(Func<int, int, double> foo)
        {
            return foo(50, 5);
        }
        static void TestDoTrans()
        {
            Func<int, int, double> Multiply = (x, y) => x * y;
            double d = Dotrans(Multiply);
            Console.WriteLine(d);
            Func<int, int, double> Add = (x, y) => x + y;
            d = Dotrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0)
                    y = 1;
                return x / y;
            };
            double d1 = Dotrans(Divide);
            Console.WriteLine(d1);
        }
    }
}

