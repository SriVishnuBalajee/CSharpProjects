using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//int x = 100; --->>NOT possible 
namespace LessonA.Day2

{
    //int x=100; ----->> NOT possible
    internal class DemoA
    {
        //GLOBAL DECLARATION
        int x = 100; //MEMBER VARIABLE,FIELD,CLASS VARIABLE
        static int y=567;
            //ONLY VARIABLE DECLARATION CAN BE DONE HERE 
        public static void FirstMethod() 
        {
            //THIS IS A STATIC METHOD
            //LOGICS AND THE STATEMENTS ARE ALWAYS WRITTEN INSIDE METHODS 
            //LOCAL Variables DECLARATION
            int x = 2000;
            int y = 5000;
            Console.WriteLine(x);//NON STATIC MEMBER CAN NOT BE ACCESSED AND ONLY THE LOCAL VALUE IS ACCESSED
            Console.WriteLine(DemoA.y);//GLOBAL VALUE OF THE VARIABLE IS ACCESSED
            Console.WriteLine(y);//LOCAL VALUE OF THE VARIABLE IS ACCESSED
        }
        public void SecondMethod()
        {    
            //THIS IS A NON STATIC METHOD
            //LOGICS AND THE STATEMENTS ARE ALWAYS WRITTEN INSIDE METHODS 
            //LOCAL Variables DECLARATION
            int y = 5000;
            Console.WriteLine(x);//NON STATIC MEMBER CAN  BE ACCESSED 
            Console.WriteLine(DemoA.y);//GLOBAL VALUE OF THE VARIABLE IS ACCESSED
            Console.WriteLine(y);//LOCAL VALUE OF THE VARIABLE IS ACCESSED
        }
    }
    internal class DemoB
    {

    }
}
namespace LessonA.Gavs
{
    internal class DemoA
    {

    }
}

