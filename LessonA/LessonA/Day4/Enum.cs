using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day4
{


    public enum City { Chennai, Banglore, Hyderabad, Pune }
    public enum Designation { Manager, Admin, developer }

    class TestEmployee
    {
        public readonly int EId; //Readonly variables are assigned and accessed only by the constructors
        public string EName;
        public City Ecity;
        public Designation JobTitle;
        public TestEmployee(int v1) 
        { EId = v1; }
        public override string ToString()
        {
            String output = String.Empty;
            output = $"Deteils of the Emplyee are:{EId}\nName:{EName}\n City:{Ecity}\nJobtitle:{JobTitle}";
            return output;
        }
        
        
        public static void TestOne()
        {
                TestEmployee e1 = new TestEmployee(348);
                e1.EName = "John";
                e1.Ecity = City.Banglore;
                e1.JobTitle = Designation.developer;
                string output = e1.ToString();
                Console.WriteLine(output);
         }

        
    }

}

public enum MovieRating
{
    VeryBad = 0,
    Bad = 1,
    Average = 2,
    Good = 3,
    Excellant = 4
}
public enum CarColor
{
    Black = 0, White = 1, Red = 2, Green = 3
}



public enum Deserts
{
    Icecream, Cake, MysorePak
}

class TestEnum
{

    public static void TestMovieRating()
    {
        Type t1 = typeof(MovieRating);
        String[] enumNames = Enum.GetNames(t1);
        String name = String.Empty;
        int len = enumNames.Length;
        for (int i = 0; i < len; i++)
        {
            name = enumNames[i];
            MovieRating movies = (MovieRating)Enum.Parse(t1, name);
            Console.WriteLine(name + " " + (int)movies);
        }
    }

}