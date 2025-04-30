using System;

namespace CalculateFinalGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student name here: ");
            string studentName = Console.ReadLine();

            // Collect subject names and marks
            Console.Write("Enter first subject here: ");
            string subject1 = Console.ReadLine();
            Console.Write("Enter first subject marks here: ");
            int subject1marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second subject here: ");
            string subject2 = Console.ReadLine();
            Console.Write("Enter second subject marks here: ");
            int subject2Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third subject here: ");
            string subject3 = Console.ReadLine();
            Console.Write("Enter third subject marks here: ");
            int subject3Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fourth subject here: ");
            string subject4 = Console.ReadLine();
            Console.Write("Enter fourth subject marks here: ");
            int subject4Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fifth subject here: ");
            string subject5 = Console.ReadLine();
            Console.Write("Enter fifth subject marks here: ");
            int subject5Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter sixth subject here: ");
            string subject6 = Console.ReadLine();
            Console.Write("Enter sixth subject marks here: ");
            int subject6Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seventh subject here: ");
            string subject7 = Console.ReadLine();
            Console.Write("Enter seventh subject marks here: ");
            int subject7Marks = Convert.ToInt32(Console.ReadLine());

            // Process arrays
            string[] subjects = { subject1, subject2, subject3, subject4, subject5, subject6, subject7 };
            int[] marks = { subject1marks, subject2Marks, subject3Marks, subject4Marks, subject5Marks, subject6Marks, subject7Marks };
            string[] subjectCredits = new string[7];
            int[] subjectPoints = new int[7];

            // Assign credit and point based on mark ranges
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 30)
                {
                    subjectCredits[i] = "G";
                    subjectPoints[i] = 1;
                }
                else if (marks[i] < 40)
                {
                    subjectCredits[i] = "F";
                    subjectPoints[i] = 2;
                }
                else if (marks[i] < 50)
                {
                    subjectCredits[i] = "E";
                    subjectPoints[i] = 3;
                }
                else if (marks[i] < 60)
                {
                    subjectCredits[i] = "D";
                    subjectPoints[i] = 4;
                }
                else if (marks[i] < 70)
                {
                    subjectCredits[i] = "C";
                    subjectPoints[i] = 5;
                }
                else if (marks[i] < 80)
                {
                    subjectCredits[i] = "B";
                    subjectPoints[i] = 6;
                }
                else
                {
                    subjectCredits[i] = "A";
                    subjectPoints[i] = 7;
                }
            }

            // Display results
            Console.WriteLine($"\n--- Final Report for {studentName} ---");
            Console.WriteLine("Subject\t\tMarks\tCredit\tPoint");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}\t\t{marks[i]}\t{subjectCredits[i]}\t{subjectPoints[i]}");
            }
        }
    }
}
