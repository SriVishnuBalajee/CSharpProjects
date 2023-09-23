using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.WeekOneTestAns
{
    internal class QuestionThree
    //3
    {
        public static void A3()
        {
            String strFriends = "Tom and jerry are good friends";
            string[] count = strFriends.Split(" ");
            int lenght = count.Length;
            Console.WriteLine(lenght);
        }



        // Write a function that can count the words in a string 

        public static void QuestionThreeA()

        {

            String strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");

            int wordCount = words.Length;

            Console.WriteLine($"Word Count {wordCount}");

        }



        //  Write a function that can reverse the string

        public static void QuestionThreeB()

        {

            String strFriends = "Tom and Jerry are good friends";
         

            Console.WriteLine(strFriends);

            // first Method

            char[] charData = strFriends.ToCharArray();

            int len = charData.Length;

            StringBuilder sb = new StringBuilder(len = 10);

            for (int i = len - 1; i >= 0; i--)

            {

                sb.Append(charData[i]);
                
            }

            Console.WriteLine(sb.ToString());

            // Second Method

            var strReverse = strFriends.Reverse();

            foreach (var item in strReverse)

            {

                Console.Write(item);

            }

        }



        // Write a function that counts the no of characters in the string 

        public static void QuestionThreeC()

        {

            String strFriends = "Tom and Jerry are good friends";

            Console.WriteLine($"Char Count: {strFriends.Length} ");

        }




        // Change the string to Uppercase and print

        public static void QuestionThreeD()

        {

            String strFriends = "Tom and Jerry are good friends";

            string strInUpper = strFriends.ToUpper();

            Console.WriteLine(strFriends);

            Console.WriteLine(strInUpper);

        }




        //Print from 10th char to the 15th char

        public static void QuestionThreeE()

        {

            String strFriends = "Tom and Jerry are good friends";

            String strPart = strFriends.Substring(10, 5);

            Console.WriteLine(strFriends);

            Console.WriteLine(strPart);

        }

    }
}
