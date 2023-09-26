/* Name: Lyra Karsaj
 * Date: 25/9/23
 * Desc: OO program
 */
namespace Q6
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
        // LC OL points from O1 to O8
        static int[] lowerPoints = { 56, 46, 37, 28, 20, 12, 0, 0 };

        // arrays with valid alphabetical grades
        static string[] alphabeticalGradesHigher = { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8" };
        static string[] alphabeticalGradesLower = { "O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8" };

        // NOTE: use a wide screen to see the table properly in the console
        static void Main(string[] args)
        {
            // hardcoded path
            string path = @"C:\test\file2.txt";
            // creates empty file for later
            File.Create(path).Dispose();

            // get inputs from user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your student number: ");
            string studentNumber = Console.ReadLine();
            Student student = new Student(name, studentNumber);

            // gets the amount of subjects to enter
            Console.Write("Enter the amount of graded subjects you earned in LC: ");
            int amtSubjects = Int32.Parse(Console.ReadLine());

            // gets necessary input to make SubjectResult objects for every subject
            for(int i = 0; i < amtSubjects; i++)
            {
                Console.Write("Enter subject " + (i + 1) + ": ");
                string subject = Console.ReadLine();
                Console.Write("Enter level of subject " + (i + 1) + ": ");
                string level = Console.ReadLine();
                Console.Write("Enter grade " + (i + 1) + ": ");
                double percentage = Double.Parse(Console.ReadLine());
                student.AddResult(new SubjectResult(subject, percentage, level));
            }
            // keeps track of total
            int pointTotal = 0;
            // prints statistics & appends them to a file
            Console.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Level",-30}{"Grades",-30}{"Points",-30}{"Alph. Grade",-30}");
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Level",-30}{"Grades",-30}{"Points",-30}{"Alph. Grade",-30}");
            }
            foreach (SubjectResult subjectResult in student.Results)
            {
                int currentPoints = DeterminePoints(subjectResult);
                string currentGrade = DetermineAlphabeticalGrade(subjectResult);
                if(currentPoints != -1)
                {
                    pointTotal += currentPoints;
                }
                Console.WriteLine($"{student.Name,-30}{student.StudentNumber,-30}{subjectResult.SubjectName,-30}{subjectResult.Level,-30}" +
                    $"{subjectResult.Percentage,-30}{currentPoints,-30}{currentGrade,-30}");
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"{student.Name,-30}{student.StudentNumber,-30}{subjectResult.SubjectName,-30}{subjectResult.Level,-30}" +
                    $"{subjectResult.Percentage,-30}{currentPoints,-30}{currentGrade,-30}");
                }
            }
            Console.WriteLine("TOTAL POINTS: " + pointTotal);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("TOTAL POINTS: " + pointTotal);
            }
        }

        // determines an alphabetical grade from a given subject object
        public static string DetermineAlphabeticalGrade(SubjectResult subjectResult)
        {
            string level = subjectResult.Level;
            if(level == "higher")
            {
                double percentage = subjectResult.Percentage;
                if(percentage > 100 || percentage < 0)
                {
                    return "Unknown";
                } else if(percentage >= 90)
                {
                    return alphabeticalGradesHigher[0];
                } else if(percentage >= 80)
                {
                    return alphabeticalGradesHigher[1];
                } else if(percentage >= 70)
                {
                    return alphabeticalGradesHigher[2];
                } else if(percentage >= 60)
                {
                    return alphabeticalGradesHigher[3];
                } else if(percentage >= 50)
                {
                    return alphabeticalGradesHigher[4];
                } else if(percentage >= 40)
                {
                    return alphabeticalGradesHigher[5];
                } else if(percentage >= 30)
                {
                    return alphabeticalGradesHigher[6];
                } else
                {
                    return alphabeticalGradesHigher[7];
                }
            } else if(level == "ordinary")
            {
                double percentage = subjectResult.Percentage;
                if (percentage > 100 || percentage < 0)
                {
                    return "Unknown";
                }
                else if (percentage >= 90)
                {
                    return alphabeticalGradesLower[0];
                }
                else if (percentage >= 80)
                {
                    return alphabeticalGradesLower[1];
                }
                else if (percentage >= 70)
                {
                    return alphabeticalGradesLower[2];
                }
                else if (percentage >= 60)
                {
                    return alphabeticalGradesLower[3];
                }
                else if (percentage >= 50)
                {
                    return alphabeticalGradesLower[4];
                }
                else if (percentage >= 40)
                {
                    return alphabeticalGradesLower[5];
                }
                else if (percentage >= 30)
                {
                    return alphabeticalGradesLower[6];
                }
                else
                {
                    return alphabeticalGradesLower[7];
                }
            }
            return "Unknown";
        }
        
        // determines points earned from a given subject object
        public static int DeterminePoints(SubjectResult subjectResult)
        {
            string level = subjectResult.Level;
            if (level == "higher")
            {
                double percentage = subjectResult.Percentage;
                if (percentage > 100 || percentage < 0)
                {
                    return -1;
                }
                else if (percentage >= 90)
                {
                    return higherPoints[0];
                }
                else if (percentage >= 80)
                {
                    return higherPoints[1];
                }
                else if (percentage >= 70)
                {
                    return higherPoints[2];
                }
                else if (percentage >= 60)
                {
                    return higherPoints[3];
                }
                else if (percentage >= 50)
                {
                    return higherPoints[4];
                }
                else if (percentage >= 40)
                {
                    return higherPoints[5];
                }
                else if (percentage >= 30)
                {
                    return higherPoints[6];
                }
                else
                {
                    return higherPoints[7];
                }
            }
            else if (level == "ordinary")
            {
                double percentage = subjectResult.Percentage;
                if (percentage > 100 || percentage < 0)
                {
                    return -1;
                }
                else if (percentage >= 90)
                {
                    return lowerPoints[0];
                }
                else if (percentage >= 80)
                {
                    return lowerPoints[1];
                }
                else if (percentage >= 70)
                {
                    return lowerPoints[2];
                }
                else if (percentage >= 60)
                {
                    return lowerPoints[3];
                }
                else if (percentage >= 50)
                {
                    return lowerPoints[4];
                }
                else if (percentage >= 40)
                {
                    return lowerPoints[5];
                }
                else if (percentage >= 30)
                {
                    return lowerPoints[6];
                }
                else
                {
                    return lowerPoints[7];
                }
            }
            return -1;
        }
    }
}