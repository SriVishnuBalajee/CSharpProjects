﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.Day4
{
    internal class DateDemo
    {
        //public static void FirstMethod()
        //{
        //    Console.WriteLine(DateTime.Now);
        //    DateTime d1 = new DateTime(2018, 04, 10);
        //    Console.WriteLine(d1.ToLongDateString());
        //    Console.WriteLine(d1.ToShortDateString());

        //}
        //public static void SecondMethod()
        //{
        //    Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
        //    String strdob = Console.ReadLine();
        //    DateTime d1 = DateTime.Parse(strdob);
        //    int year = d1.Year;
        //    Console.WriteLine("Year OF Dob " + year);
        //    int month = d1.Month;
        //    Console.WriteLine("Month OF Dob " + month);
        //    int day = d1.Day;
        //    Console.WriteLine("Day OF Dob " + day);
        //    DateTime d2 = d1.AddMonths(10);
        //    Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
        //    DateTime d3 = d1.AddDays(5);
        //    Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
        //    DateTime d4 = d1.AddYears(58);
        //    Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
        //    DateTime d5 = d1.AddYears(-5);
        //    Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        //}
        //public static void AgeOfaPerson()
        //{
        //    Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");

        //    try
        //    {

        //        String strdob = Console.ReadLine();
        //        DateTime d1 = DateTime.Parse(strdob);

        //        DateTime d2 = DateTime.Now;
        //        Console.WriteLine("Life Span");
        //        TimeSpan d3 = d2.Subtract(d1);
        //        DateTime age = new DateTime(d3.Ticks);
        //        Console.WriteLine("Age in Date" + age.ToShortDateString());
        //    } catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //public static void AgeOfaPerson2()
        //{
        //    Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
        //    string dobString = String.Empty;
        //    try
        //    {
        //        dobString = Console.ReadLine();
        //        if (dobString == null)
        //        {
        //            Console.WriteLine("Date Of Birth is NULL!!!");
        //            return;
        //        }
        //        // Parse the date of birth
        //        DateTime dob = DateTime.Parse(dobString);



        //        // Calculate the age
        //        DateTime now = DateTime.Now;
        //        int ageYears = now.Year - dob.Year;
        //        if (now < dob.AddYears(ageYears))
        //        {
        //            ageYears--;
        //        }
        //        int ageMonths = now.Month - dob.Month;
        //        if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
        //        {
        //            ageMonths--;
        //        }
        //        int ageDays = now.Day - dob.Day;
        //        if (now.Day < dob.Day)
        //        {
        //            ageDays += DateTime.DaysInMonth(now.Year, now.Month);
        //        }
        //        // Print the age
        //        Console.WriteLine(
        //            $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        public static void FindRetirement()
        {
            Console.WriteLine("Enter the Date of Birth:");



            try
            {

                String Dob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(Dob);
                DateTime d2 = d1.AddYears(60).AddMonths(1);
                DateTime nextMonthFirstDay = new DateTime(d2.Year, d2.Month, d2.Day);

                DateTime retirementdate = nextMonthFirstDay.AddDays(-1);
                Console.WriteLine("Your Retirement Date is" + retirementdate.ToLongDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }




        }
    }
  
}


    
    

