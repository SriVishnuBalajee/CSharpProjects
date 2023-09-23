using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LessonA.Day5;

namespace LessonA.Day6
{
    internal class Queue1
    {
        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue(25);
            Console.Write(25 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }
        public static void StackDemoA()
        {
            Stack st = new Stack();
            Random r = new Random();
            int x = 0;
            st.Push(25);
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                st.Push(x);
            }
            Console.WriteLine("");
            int count = st.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(st.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }



            Console.WriteLine("");
            count = st.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + st.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(st.Pop() + " ");
            }
            Console.WriteLine();
            count = st.Count;
            Console.WriteLine("Count After Pop=" + count);
        }
        public static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);
            ht.Add("id", 123);
            ht.Add("name", "Gates");
            Console.WriteLine("Count " + ht.Count);
            ht.Add("sal", 15000);
            ht.Add("r1", new Random().Next());
            ht.Add("IsDirector", false);
            ht.Add("Address", null);
            // ht.Add("name", "Bill");// Runtime Error duplicate key 
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine(ht["sal"]);
            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("r1"));
            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));



            foreach (object k in ht.Keys)
                Console.WriteLine(k + "--" + ht[k]);
        }
        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i,
                };
                empTable.Add(e.ID, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }
        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);



            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }
        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() { ID = r1.Next(100), Name = "Ellango", Salary = r1.NextDouble() * 5000 };
            Emp e5 = new Emp() { ID = r1.Next(100), Name = "Basker", Salary = r1.NextDouble() * 5000 };
            //   if (!empsortlist.ContainsKey(e1.ID))
            empsortlist.Add(e1.ID, e1);
            //  if (!empsortlist.ContainsKey(e2.ID))
            empsortlist.Add(e2.ID, e2);
            //  if (!empsortlist.ContainsKey(e3.ID))
            empsortlist.Add(e3.ID, e3);
            //  if (!empsortlist.ContainsKey(e4.ID))
            empsortlist.Add(e4.ID, e4);
            // if (!empsortlist.ContainsKey(e5.ID))
            empsortlist.Add(e5.ID, e5);



            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);



            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var orderedlist = empsortlist.OrderBy(key => key.Value.Salary);
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name + " : " + emp.Value.Salary);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Salary);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Value.ID + " : " + emp.Value.Name + " : " + emp.Value.Salary);
            }
            Console.WriteLine("===================");
            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Value.ID + " : " + emp.Value.Name + " : " + emp.Value.Salary);
            }

        }

    }
    class WorkingWithObjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;
            Emp empTwo = empOne;
            empTwo.ID = 1002;
            Console.WriteLine(empOne.ID);
            Emp empThree = new Emp();
            empThree.ID = 103;
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());




        }
    }
    class Emp
    {
        public int ID;
        public String Name= string.Empty;
        public double Salary;
    }
    class Box
    {
        List<int> noList = new List<int>();
        public void FillList(int from, int to)
        {
            int i = 0;
            for (i = from; i < to; i++)
            {
                noList.Add(i);
            }
        }
        public List<int> GetList()
        {
            return noList;
        }
        public static void OutParameterMethod(int v1, out int v2, out string v3)
        {
            v3 = "vishnu";
            //Console.WriteLine("v1={0},v2={1}", v1, v2); out v2 is unassigned
            v1 = v1 + 100;
            //v2 = v2 * 2000; //out v2 is unassigned
            v2 = v1 * 5; // v2 (y) is assigned
            Console.WriteLine("\t M2==> v1={0},v2={1}", v1, v2);
        }
        public static void TestOutParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before M2==> x={0},y={1}", x, y); // 5, 10
           // Box.OutParameterMethod(x, out y,");
            //M2(v2: out x, v1: y);//Using Named Arguments
            Console.WriteLine("After M2==> x={0},y={1}", x, y);// 5, 525
        }


        public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");

             static void TestOptionalParameter()
            {
                int x = 5;
                int y = 10;
                Console.WriteLine($"x={x},y={y}");
                OptionalParameters();
                OptionalParameters(x, y);
                OptionalParameters(v2: x, v1: y);//Using Named Arguments
            }
        }
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }
        class ParameterDemo
        {
            public static void ByRefMethod(int v1, ref int v2)
            {
                Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//5, 10
                v1 = v1 + 100;
                v2 = v1 * 2000;
                Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//105, 210000 
            }
            public static void TestByRefMethod()
            {
                int x = 5;
                int y = 10;
                Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 10
                ByRefMethod(x, ref y);
                Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 210000
            }
        }
    }

}


