using System;

namespace CalculateFinalGPA {
    class Program {
        static void Main(string[] args) {
            //collecting student name
            Console.Write("Enter Student Name here: ");
            string studentName = Console.ReadLine();

            //collect subject names and marks
            Console.Write("Enter Home Language here: ");
            string subject1 = Console.ReadLine();
            Console.Write("Enter Home Language marks here: ");
            int subject1marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter First Additional Language here: ");
            string subject2 = Console.ReadLine();
            Console.Write("Enter First Additional Language marks here: ");
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

            //processing arrays
            string[] subjects = { subject1, subject2, subject3, subject4, subject5, subject6, subject7 };
            int[] marks = { subject1marks, subject2Marks, subject3Marks, subject4Marks, subject5Marks, subject6Marks, subject7Marks };
            string[] subjectSymbol = new string[7];
            int[] subjectPoints = new int[7];

            // Assign credit and point based on mark ranges
            for (int i = 0; i < marks.Length; i++) {
                
                if (marks[i] < 30)
                {
                    subjectSymbol[i] = "G";
                    subjectPoints[i] = 1;
                }
                else if (marks[i] < 40)
                {
                    subjectSymbol[i] = "F";
                    subjectPoints[i] = 2;
                }
                else if (marks[i] < 50)
                {
                    subjectSymbol[i] = "E";
                    subjectPoints[i] = 3;
                }
                else if (marks[i] < 60)
                {
                    subjectSymbol[i] = "D";
                    subjectPoints[i] = 4;
                }
                else if (marks[i] < 70)
                {
                    subjectSymbol[i] = "C";
                    subjectPoints[i] = 5;
                }
                else if (marks[i] < 80)
                {
                    subjectSymbol[i] = "B";
                    subjectPoints[i] = 6;
                }
                else
                {
                    subjectSymbol[i] = "A";
                    subjectPoints[i] = 7;
                }
            }

            int pointSum = 0;
            for (int i = 0; i < subjectPoints.Length; i++) {
                pointSum += subjectPoints[i];
            }

            int sumSubjectMarks = 0;
            for (int i = 0; i < marks.Length; i++) {
                sumSubjectMarks += marks[i];
            }

            //determine student progression status
            bool isProgressing = true;
            int above40Count = 0;
            int above30Count = 0;


            //Count subjects above 40 and 30
            for (int i = 0; i < marks.Length; i++) {
                if (marks[i] > 40) above40Count++;
                if (marks[i] > 30) above30Count++;
            }

            //condition to progress
            if (above40Count >= 3 && above30Count >= 3 && subject1marks >= 40)
            {
                isProgressing = true;
            }
            else
            {
                isProgressing = false;
            }

            string status;
                if (isProgressing) {
                    status = "Progressing";
                    }
                    else {
                        status = "Not Progressing";
                    }


            //display results
            Console.WriteLine($"\n--- Final Report for {studentName} ---");
            Console.WriteLine("Subject\t\t\tMarks\tCredit\tPoint");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < subjects.Length; i++) {
                Console.WriteLine($"{subjects[i],-24}{marks[i],-8}{subjectSymbol[i],-8}{subjectPoints[i]}");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Total Points:\t\t{pointSum}");
            Console.WriteLine($"Total Marks:\t\t{sumSubjectMarks}");
            Console.WriteLine($"Status:\t\t\t{status}");
        }
    }
}
