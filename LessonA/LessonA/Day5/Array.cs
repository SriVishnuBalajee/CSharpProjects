using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day5
{
    internal class Array1
    {
        public static void FirstMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            Random random = new Random();
            for (i = 0; i < 10; i = i + 1)
                sample[i] = random.Next(100);
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
                Console.WriteLine(sample.Length);
                Console.WriteLine(sample.Reverse());
                Console.WriteLine(sample.Average());
                Console.WriteLine(sample.Max());
                Console.WriteLine(sample.Min());
            }
        }
        public static void TwoD()
        {
            int r, c;
            int[,] table = new int[3, 4];//3 Rows - 4 Col
            for (r = 0; r < 3; ++r)
            {
                for (c= 0; c < 4; ++c)
                {
                    table[r, c] = r * 4 + c + 1;
                    Console.Write(table[r, c] + " ");
                }
                Console.WriteLine();
            }
           
        }
        public static void Anagram()
        {
            String str11 = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered";
            string[] str12 = str11.Replace(".", " ").Trim().Split(" ");
            for(int i = 0;i < str12.Length;i++)
            {
                Console.WriteLine(str12[i]);
                char[] Arr11= str12[i].ToCharArray();
                Array.Sort(Arr11);
                
                
               for(int j=0;j<str12.Length;j++)
                    Array.Sort(Arr11);
                  string str13 = Arr11[i].ToString();
                if (string.Equals(str13, str11))
                  {
                        Console.WriteLine($"{str13},{str11}");
                    }
                
            }
        }
    }
}
