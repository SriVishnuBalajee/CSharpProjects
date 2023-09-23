using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LessonA.Day7
{
    class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CureentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID:" + id);
            ServiceA a1 = new ServiceA();
            a1.objectServiceA = a1;
            Thread t1 = new Thread(a1.DoTaskA);


            t1.Start();
            a1.DoTaskA();
            Console.WriteLine("------End of DemoB--]--------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID:" + id);
            ServiceA a1 = new ServiceA();
            a1.objectServiceA = a1;

            Thread t1 = new Thread(a1.DoTaskA);
            Console.WriteLine(t1.ManagedThreadId + "T1 State:" + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "T1 State After Start" + t1.ThreadState);
            Thread.Sleep(6000);
            Console.WriteLine(t1.ManagedThreadId + "T1 State After Sleep:" + t1.ThreadState);
            Console.WriteLine("------End of DemoB2----------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID:" + id);
            ServiceA a1 = new ServiceA();

            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(2000);
            //if (t1.IsAlive) Monitor.;
            t2.Join(2000);
            //if(t2.IsAlive) t2.Abort();
            Console.WriteLine("------End Of DemoC------");


        }
    }
}
