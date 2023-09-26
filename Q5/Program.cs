/* Name: Lyra Karsaj
 * Date: 25/9/2023
 * Desc: Tabulated report
 */

namespace Q5
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
        // LC OL points from O1 to O8
        static int[] lowerPoints = { 56, 46, 37, 28, 20, 12, 0, 0 };
        static void Main(string[] args)
        {
            // hardcoded path
            string path = @"C:\test\file.txt";

            // get inputs from user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your student number: ");
            string studentNumber = Console.ReadLine();
            string[] subjects = new string[7];
            int[] grades = new int[subjects.Length];
            string[] levels = new string[subjects.Length];
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.Write("Enter subject " + (i + 1) + ": ");
                subjects[i] = Console.ReadLine();
                Console.Write("Enter level of subject " + (i + 1) + ": ");
                levels[i] = Console.ReadLine();
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Int32.Parse(Console.ReadLine());
            }

            // gets and prints out calculations/statistics to console
            int totalPoints = PointCalculator(grades, levels);
            Console.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Level",-30}{"Grades",-30}");
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{name,-30}{studentNumber,-30}{subjects[i],-30}{levels[i],-30}{grades[i],-30}");
            }
            Console.WriteLine("POINTS TOTAL = " + totalPoints);

            // adds those calculations/statistics to a file
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Level",-30}{"Grades",-30}");
                for (int i = 0; i < subjects.Length; i++)
                {
                    sw.WriteLine($"{name,-30}{studentNumber,-30}{subjects[i],-30}{levels[i],-30}{grades[i],-30}");
                }
                sw.WriteLine("POINTS TOTAL = " + totalPoints);
            }
        }

        // calculates points based on an array of grades and a matching level array
        public static int PointCalculator(int[] gradeArray, string[] levelArray)
        {
            int totalPoints = 0;
            for(int i = 0; i < gradeArray.Length; i++)
            {
                int grade = gradeArray[i];
                switch(levelArray[i])
                {
                    case "higher":
                        if (grade > 100 || grade < 0)
                        {

                        }
                        else if (grade >= 90)
                        {
                            totalPoints = totalPoints + higherPoints[0];
                        }
                        else if (grade >= 80)
                        {
                            totalPoints = totalPoints + higherPoints[1];
                        }
                        else if (grade >= 70)
                        {
                            totalPoints = totalPoints + higherPoints[2];
                        }
                        else if (grade >= 60)
                        {
                            totalPoints = totalPoints + higherPoints[3];
                        }
                        else if (grade >= 50)
                        {
                            totalPoints = totalPoints + higherPoints[4];
                        }
                        else if (grade >= 40)
                        {
                            totalPoints = totalPoints + higherPoints[5];
                        }
                        else if (grade >= 30)
                        {
                            totalPoints = totalPoints + higherPoints[6];
                        }
                        else if (grade <= 0)
                        {
                            totalPoints = totalPoints + higherPoints[7];
                        }
                        break;
                    case "ordinary":
                        if (grade > 100 || grade < 0)
                        {

                        }
                        else if (grade >= 90)
                        {
                            totalPoints = totalPoints + lowerPoints[0];
                        }
                        else if (grade >= 80)
                        {
                            totalPoints = totalPoints + lowerPoints[1];
                        }
                        else if (grade >= 70)
                        {
                            totalPoints = totalPoints + lowerPoints[2];
                        }
                        else if (grade >= 60)
                        {
                            totalPoints = totalPoints + lowerPoints[3];
                        }
                        else if (grade >= 50)
                        {
                            totalPoints = totalPoints + lowerPoints[4];
                        }
                        else if (grade >= 40)
                        {
                            totalPoints = totalPoints + lowerPoints[5];
                        }
                        else if (grade >= 30)
                        {
                            totalPoints = totalPoints + lowerPoints[6];
                        }
                        else if (grade <= 0)
                        {
                            totalPoints = totalPoints + lowerPoints[7];
                        }
                        break;
                }
            }
            return totalPoints;
        }
    }
}