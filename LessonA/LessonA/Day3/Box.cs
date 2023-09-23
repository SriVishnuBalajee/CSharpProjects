using LessonA.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class Box
    {

        public int Height;
        public int Length;
        public int Width;



        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
            Height = 10;
            Width = 5;
            Length = 20;
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return ($"{Height},{Width},{Length}");
        }

    }

    internal class WoodenBox : Box
    {
        public int Area;
        public WoodenBox(int x):base(x) //base is used to call the parents explicitly 
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public void Break()
        {
            Console.WriteLine("The box has been Broken");
        }
        public override string ToString()
        {
            return ("Tom And Jerry");
        }

    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(100);
           // box.Height = 10;
            //box.Width = 5;
            //box.Length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
        }

        public static void TestTwo()
        {
            WoodenBox wbox = new WoodenBox(10);
            wbox.Height = 100;
            wbox.Width = 50;
            wbox.Length = 200;
            wbox.Open();
            wbox.Close();
            wbox.Break();
            String output = wbox.ToString();
            Console.WriteLine(output);
         }
        public static void TestThree()
        {
            Box box = new WoodenBox(10);
            box.Height = 100;
            box.Width = 50;
            box.Length = 200;
            box.Open();
            box.Close();
           // box.Break();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area =300;
            

        }
    }
}
    

