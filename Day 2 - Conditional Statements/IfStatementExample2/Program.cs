using System;

namespace IfStatementExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please enter a grade.");
            double grade = double.Parse(Console.ReadLine());
            string letterGrade;
            double tilOneHundred = 100 - grade;

            //processing
            if(grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
        }
    }
}
