using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day7
{
    class ServiceA
    {
        
        public ServiceA objectServiceA=null;
        public void DoTaskA()
        {
            Monitor.Enter(objectServiceA);
           Console.WriteLine(objectServiceA.ToString());
            Thread t1 = Thread.CurrentThread;
            
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTask");
            Console.WriteLine("\tThread ID:" + id);
            Console.WriteLine(id);
            int x = 0;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    x += i;
                    Console.WriteLine("ID: " + id + "X= " + x + " i=" + i);
                    Thread.Sleep(1000);//1s=1000ms

                }
            }
            finally
            {
                
                Monitor.Exit(objectServiceA);
            }
        }


    }
}
