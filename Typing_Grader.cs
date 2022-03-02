//Author: Michael Speer

//This is a simple program console app I wrote for my wife
//She wasn't sure how to reasonably grade middle school typing speeds
//I wrote this to take in the highest and lowest typing speeds and the grade range she wants
//This allows her to be nicer or more strict
//Then it loops through, allowing her to type in each student's speed and prints out a grade

using System;

namespace Typing_Grader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the high speed?");
            double hs = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the low speed?");
            double low = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the lowest grade you would like?");
            double low_grade = Convert.ToDouble(Console.ReadLine());
            
            //100 is of the max grade, subtracting the low grade and 
            //dividing by the difference between the high speed and the low speed
            //creates the value of each word/minute in terms of percentage
            
            double r = (100 - low_grade) / (hs - low);
            double var = 100 - (r*hs);
            int i = 0;
            while(i==0)
            {
                Console.WriteLine("What is the typing speed?");
                double speed = Convert.ToDouble(Console.ReadLine());
                double grade = (r*speed) + var;
                Console.WriteLine($"Grade is \n  {grade}\n\n");
            }
        }
    }
}