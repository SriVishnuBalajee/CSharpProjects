﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void RecieveMessage();
        void DeleteMessage();
    }
    public interface IPayment
    {
        void MakePayment(float amount);
    }
    internal class Whatsapp : IMessageService
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Method Not Implemented"); 
        }
        public void RecieveMessage()
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public class MessageTester
        {
            public static void TestOne()
            {
                IMessageService service = new Whatsapp();
                service.SendMessage("Hello");
                service.RecieveMessage();
            }
        }

    }
        
    }

