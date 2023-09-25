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
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.Write("Enter subject " + (i + 1) + ": ");
                subjects[i] = Console.ReadLine();
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Int32.Parse(Console.ReadLine());
            }
            int totalPoints = PointCalculator(grades);
            Console.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Grades",-30}");
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{name,-30}{studentNumber,-30}{subjects[i],-30}{grades[i],-30}");
            }
            Console.WriteLine("POINTS TOTAL = " + totalPoints);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"{"Name",-30}{"Student Number",-30}{"Subjects",-30}{"Grades",-30}");
                for (int i = 0; i < subjects.Length; i++)
                {
                    sw.WriteLine($"{name,-30}{studentNumber,-30}{subjects[i],-30}{grades[i],-30}");
                }
                sw.WriteLine("POINTS TOTAL = " + totalPoints);
            }
        }

        public static int PointCalculator(int[] gradeArray)
        {
            int totalPoints = 0;
            foreach (int grade in gradeArray)
            {
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
            }
            return totalPoints;
        }
    }
}