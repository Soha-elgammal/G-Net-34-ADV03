namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Q1: Create a Collection with these grades
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            // Q2: Print the collection, Count, first and last grade
            Console.WriteLine("All Grades:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First Grade: " + grades.First());
            Console.WriteLine("Last Grade: " + grades.Last());

            // Q3: Sort the grades ascending, then print
            grades.Sort();
            Console.WriteLine("\nSorted Grades (Ascending):");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            // Q4: Get the first grade above 90
            int firstAbove90 = grades.FirstOrDefault(g => g > 90);
            Console.WriteLine("\nFirst Grade Above 90: " + firstAbove90);

            // Q5: Get all grades below 75 (failing grades)
            List<int> failingGrades = grades.Where(g => g < 75).ToList();
            Console.WriteLine("\nFailing Grades (<75):");
            foreach (int grade in failingGrades)
            {
                Console.WriteLine(grade);
            }

            // Q6: Remove all failing grades (below 75)
            grades.RemoveAll(g => g < 75);
            Console.WriteLine("\nGrades After Removing Failing:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            // Q7: Check if any grade equals 100
            bool hasFullMark = grades.Any(g => g == 100);
            Console.WriteLine("\nIs there a grade = 100? " + hasFullMark);

            // Q8: Create a List<string> where each grade becomes "Grade: X"
            List<string> gradeStrings = grades.Select(g => "Grade: " + g).ToList();
            Console.WriteLine("\nFormatted Grades:");
            foreach (string str in gradeStrings)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
