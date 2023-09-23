using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Box
    {
        public static int height;//IN CASE OF STATIC VARIABLES THE VALUE IS NOT NEED TO BE DECLARED
        public  int width;
        public const String type = "Wooden";//IN CASE OF CONSTANT VARIABLE THE VALUE NEEDS TO BE DECLARED AND THAT CANNOT BE CHANGED
        public int Getheight() 
        { 
            return height; 
        }
    }
    internal class TestBox
    {
        public static void TestOne() 
        {
            Box.height = 100;//STATIC MEMBERS OF A CLASS CAN BE ACCESSED WITHOUT A OBJECT REFERENCE
            //Box.width = 200;
            Box FirstBox= new Box();
            Box SecondBox= new Box();
            FirstBox.width = 12345;
            SecondBox.width = 98765;
            Console.WriteLine($"FirstBox ={FirstBox.width},{FirstBox.Getheight()}");
            Console.WriteLine($"SecondBox ={SecondBox.width},{SecondBox.Getheight()}");
            Box.height = 5555;
            Console.WriteLine($"FirstBox ={FirstBox.width},{FirstBox.Getheight()}");
            Console.WriteLine($"SecondBox ={SecondBox.width},{SecondBox.Getheight()}");
            Console.WriteLine(Box.type);
            //box.type = "glass"; THIS OVER WRITTING IS NOT POSSIBLE IN CASE OF CONSTANT VARIABLE
        }
    }
}
 