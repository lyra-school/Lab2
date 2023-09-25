/* Name: Lyra Karsaj
 * Date: 25/9/23
 * Desc: Read grades from file
 */
namespace Q1
{
    internal class Program
    {
        // LC HL points from H1 to H8
        static int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
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
                catch (Exception e)
                {
                    Console.WriteLine("Error reading file: lines are formatted incorrectly.");
                }
            }
            // write total at the end of file
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\n" + totalPoints);
            }
        }
    }
}