using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Lab2A
{
    class Program
    {
        static void Main(string[] args)

        {
            // sum of numbers and average ten scores (Lines 12 - 66)

            Console.WriteLine("What is the first students grade");
            var gradeOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second students grade");
            var gradeTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the third students grade");
            var gradeThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the fourth students grade");
            var gradeFour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the fifth students grade");

            var gradeFive = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the sixth students grade");
            var gradeSix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the seventh students grade");
            var gradeSeven = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the eighth students grade");
            var gradeEight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the ninth students grade");
            var gradeNine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the tenth students grade");
            var gradeTen = Convert.ToDouble(Console.ReadLine());

            var gradeAv = ((gradeOne + gradeTwo + gradeThree +
                            gradeFour + gradeFive + gradeSix +
                            gradeSeven + gradeEight + gradeNine +
                            gradeTen) / 10);


            if (gradeAv <= 59)
            {
                Console.WriteLine("The average letter grade is F with a score of " + gradeAv + "%");
            }
            else if (gradeAv >= 60 && gradeAv <= 70)
            {
                Console.WriteLine("The average letter grade is D with a score of " + gradeAv + "%");
            }
            else if (gradeAv >= 71 && gradeAv <= 79)
            {
                Console.WriteLine("The average letter grade is C with a score of " + gradeAv + "%");
            }
            else if (gradeAv >= 80 && gradeAv <= 89)
            {
                Console.WriteLine("The average letter grade is B with a score of " + gradeAv + "%");
            }
            else if (gradeAv >= 90 && gradeAv <= 100)
            {
                Console.WriteLine("The average letter grade is A with a score of " + gradeAv + "%");
                Console.WriteLine();
            }

            // sum of numbers and average decided number of tests (Lines 12 - 66)

            Console.WriteLine("How many students took the test?");
            var testNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first students grade");
            var grade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second students grade");
            var grade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the third students grade");
            var grade3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the fourth students grade");
            var grade4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the fifth students grade");
            var grade5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the sixth students grade");
            var grade6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the seventh students grade");
            var grade7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the eighth students grade");
            var grade8 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the ninth students grade");
            var grade9 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the tenth students grade");
            var grade10 = Convert.ToDouble(Console.ReadLine());

            var gradAvg = ((grade1 + grade2 + grade3 +
                            grade4 + grade5 + grade6 +
                            grade7 + grade8 + grade9 +
                            grade10) / testNum);


            if (gradAvg <= 59)
            {
                Console.WriteLine("The average letter grade is F with a score of " + gradAvg + "%");
            }
            else if (gradAvg >= 60 && gradAvg <= 70)
            {
                Console.WriteLine("The average letter grade is D with a score of " + gradAvg + "%");
            }
            else if (gradAvg >= 71 && gradAvg <= 79)
            {
                Console.WriteLine("The average letter grade is C with a score of " + gradAvg + "%");
            }
            else if (gradAvg >= 80 && gradAvg <= 89)
            {
                Console.WriteLine("The average letter grade is B with a score of " + gradAvg + "%");
            }
            else if (gradAvg >= 90 && gradAvg <= 100)
            {
                Console.WriteLine("The average letter grade is A with a score of " + gradAvg + "%");
                Console.WriteLine();

            }

            //gives average with letter grade (lines 138 - 149) were provided and explained by guest speaker who helped after class

            Console.WriteLine("Input the student grades seperated by a comma");

            string values = (Console.ReadLine());
            string[] grades = values.Split(',');

            double value = 0;
            foreach (var grade in grades)
            {
                value += double.Parse(grade);
            }

            var avg = value / grades.Length;


            if (avg <= 59)
            {
                Console.WriteLine("The average letter grade is F with a score of " + avg + "%");
            }
            else if (avg >= 60 && avg <= 70)
            {
                Console.WriteLine("The average letter grade is D with a score of " + avg + "%");
            }
            else if (avg >= 71 && avg <= 79)
            {
                Console.WriteLine("The average letter grade is C with a score of " + avg + "%");
            }
            else if (avg >= 80 && avg <= 89)
            {
                Console.WriteLine("The average letter grade is B with a score of " + avg + "%");
            }
            else if (avg >= 90 && avg <= 100)
            {
                Console.WriteLine("The average letter grade is A with a score of " + avg + "%");
                Console.WriteLine();


            }
        }
    }
}
