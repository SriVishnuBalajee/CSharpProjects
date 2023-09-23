using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Person
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string Title { get; set; } =  string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string  Reason { get; set; } = string.Empty;
        public string WhotoVisit { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"ID:{this.Id} \nName:{Title} {FirstName} {lastName}\n" +
                $"Address:{Address}\n City:{City}\n State:{Region}\n" +
                $"Phone:{Phone}\n Country:{Country}\n zip:{PostalCode}\n" +
                $"Date:{Date}\n Time:{Time}\n Reason:{Reason}\n WhotoVisit:{WhotoVisit}";
        }
    }
    internal class Appointment
    {
       
        public static void TestOne()
        {
            Person firstperson = new Person();
            Console.WriteLine("APPOINTMENT FORM");
            firstperson.Id = 1;
            firstperson.FirstName = "Srivishnu";
            firstperson.lastName = "B";
            firstperson.Address = "Padur";
            firstperson.City = "Chennai";
            firstperson.Country = "India";
            firstperson.Phone = "9150012442L";
            firstperson.PostalCode = "603103";
            firstperson.Region = "TN";
            firstperson.Title = "Mr.";
            firstperson.Date = "24.08.2023";
            firstperson.Time = "2:00 pm";
            firstperson.Reason = "General CheckUP";
            firstperson.WhotoVisit = "Dr.Dhandapaani";
            String value=firstperson.ToString();
            Console.WriteLine(value);


        }

    }

}
