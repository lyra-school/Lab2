/* Name: Lyra Karsaj
 * Date: 25/9/23
 * Desc: Method
 */
namespace Q4
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
        static void Main(string[] args)
        {
            int[] testValues = { 56, 74, 10, 56, 99, 45 };
            Console.WriteLine("Total points: " + PointCalculator(testValues));
        }

        public static int PointCalculator(int[] gradeArray)
        {
            int totalPoints = 0;
            foreach(int grade in gradeArray)
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