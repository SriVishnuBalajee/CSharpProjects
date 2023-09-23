using LessonA.Day3;
using LessonA.Day4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static LessonA.InnerClass.Car;
using static LessonA.InnerClass.Car.Engine;

namespace LessonA.InnerClass
{
    //    public class Car
    //    {
    //        int[] Wheel11 = new int[4];
    //        readonly string RegNo;
    //        string model;
    //        enum fueltype { Disel, Petrol, EV, Gas };

    //        public Car()
    //        { 
    //            Engine engine = new Engine(this);
    //            Wheel wheel = new Wheel(this);

    //        }
    //        public class Engine
    //        {
    //            private readonly Car c1;


    //            public Engine(Car outercar)
    //            {
    //                bool flag;
    //                c1 =outercar;
    //                Console.WriteLine("Enter Key Operations"); 
    //            }


    //            public static void KeyIn()
    //            {

    //                Console.WriteLine("Engine Has Started");

    //            }
    //            public static void KeyOut()
    //            {
    //                Console.WriteLine("Engine Has Been Stopped");
    //            }

    //            public class Wheel
    //            {


    //                public Wheel(Car outerengine)
    //                {

    //                }
    //                static void Rotate()
    //                    {
    //                    if (true)
    //                    {

    //                        Console.WriteLine("Car is moving");
    //                    }

    //                    {

    //                    }
    //                }

    //            }


    //        }
    //    }

    //}
    internal class Car
    {
        private readonly Wheel __wheel;
        private readonly Engine __engine;
        public int no { get; set; }
        public string model { get; set; }
        enum fueltype { Disel, Petrol, EV, Gas };








        public Car()
        {
            __wheel = new Wheel(this);
            __engine = new Engine(this);
        }
        public Wheel GetWheel() { return __wheel; }
        public Engine GetEngine() { return __engine; }



        public class Wheel
        {
            private readonly Car car;
            const int NO_OF_WHEELS = 4;
            public int wheel { get; set; }
            public static bool isFourWheel = true;
            




            public Wheel(Car c)
            {
                if (c == null)
                {
                    Console.WriteLine("CAR object is not instantiated");
                }
                else
                {
                    car = c;
                }
            }
            
            private Wheel()
            {
                Console.WriteLine("Not Allow to create the Wheel Object");
            }



            public static bool CheckTheWheel(int n)
            {
                if (n != NO_OF_WHEELS)
                {
                    Console.WriteLine("Wheel Must 4 Set Wheel to 4");
                    isFourWheel = false;
                    return isFourWheel;
                }
                return isFourWheel;
            }
            public static void StartDriving()
            {
                if (Engine.isStart == true)
                {
                    Console.WriteLine("Start driving");
                }
                else
                {
                    Console.WriteLine("First Start the engine");
                }
            }
        }
        public class Engine
        {
            public static bool isStart = false;
            
            private readonly Car car;
            public Engine(Car c)
            {
                if (c == null)
                {
                    Console.WriteLine("CAR object is not instantiated");
                }
                else
                {
                    car = c;
                }
            }
            
            private Engine()
            {
                Console.WriteLine("Not Allow to create the gine Object");
            }



            public void Start()
            {
                if (Wheel.isFourWheel == true && isStart == false)
                {
                    Console.WriteLine("Engine starting");
                    isStart = true;
                }
                else
                {
                    Console.WriteLine("Wheel must be 4 Unable to Start");
                }
            }
            public void Stop()
            {
                if (isStart == true)
                {
                    Console.WriteLine("Engine Stoping");
                    isStart = false;
                }
                else
                {
                    Console.WriteLine("It is Already  Stopped");
                }
            }
        }





    }
}