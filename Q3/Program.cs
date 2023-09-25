/* Name: Lyra Karsaj
 * Date: 25/9/23
 * Desc: Arrays
 */
namespace Q3
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };

        // boundaries between grades
        static int[] boundaries = { 100, 90, 80, 70, 60, 50, 40, 30, 0 };
        static void Main(string[] args)
        {
            // hardcoded path
            string path = @"C:\test\results.txt";

            // loads all lines into an array, checks for an IOException related to reading the file
            string[] lines;
            try
            {
                lines = File.ReadAllLines(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file. It may not exist in specified path or otherwise cannot be opened.");
                return;
            }
            int totalPoints = 0;
            // loops through all values in the file, appends point value
            foreach (string line in lines)
            {
                try
                {
                    int grade = Int32.Parse(line);
                    if (grade > boundaries[0] || grade < boundaries[8])
                    {

                    }
                    else if (grade >= boundaries[1])
                    {
                        totalPoints = totalPoints + higherPoints[0];
                    }
                    else if (grade >= boundaries[2])
                    {
                        totalPoints = totalPoints + higherPoints[1];
                    }
                    else if (grade >= boundaries[3])
                    {
                        totalPoints = totalPoints + higherPoints[2];
                    }
                    else if (grade >= boundaries[4])
                    {
                        totalPoints = totalPoints + higherPoints[3];
                    }
                    else if (grade >= boundaries[5])
                    {
                        totalPoints = totalPoints + higherPoints[4];
                    }
                    else if (grade >= boundaries[6])
                    {
                        totalPoints = totalPoints + higherPoints[5];
                    }
                    else if (grade >= boundaries[7])
                    {
                        totalPoints = totalPoints + higherPoints[6];
                    }
                    else if (grade <= boundaries[8])
                    {
                        totalPoints = totalPoints + higherPoints[7];
                    }
                } catch(Exception e)
                {
                    Console.WriteLine("Error reading file: lines are formatted incorrectly.");
                }
            }
            // prints out the total points
            Console.WriteLine("Total points: " + totalPoints);
        }
    }
}