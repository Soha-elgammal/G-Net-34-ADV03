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

            // Exercise 2
            // Q1: Create leaderboard using SortedDictionary (auto sorted by score)
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            {
                {500, "Ahmed"},
                {200, "Sara"},
                {800, "Ali"},
                {350, "Mona"}
            };

            // Q2: Print all entries (sorted automatically)
            Console.WriteLine("Leaderboard:");
            foreach (var item in leaderboard)
            {
                Console.WriteLine($"Score: {item.Key}, Player: {item.Value}");
            }

            // Q3: Access first key and first value
            int firstKey = leaderboard.First().Key;
            string firstValue = leaderboard.First().Value;

            Console.WriteLine("\nFirst Score: " + firstKey);
            Console.WriteLine("First Player: " + firstValue);

            // Q4: Check if score 500 exists
            bool has500 = leaderboard.ContainsKey(500);
            Console.WriteLine("\nDoes score 500 exist? " + has500);

            // Q5: Safely get the player with score 999
            if (leaderboard.TryGetValue(999, out string player))
            {
                Console.WriteLine("\nPlayer with score 999: " + player);
            }
            else
            {
                Console.WriteLine("\nScore 999 not found.");
            }

            // Q6: Remove player with score 200 and print updated list
            leaderboard.Remove(200);

            Console.WriteLine("\nLeaderboard after removing score 200:");
            foreach (var item in leaderboard)
            {
                Console.WriteLine($"Score: {item.Key}, Player: {item.Value}");
            }

            Console.ReadLine();

            //Exercise 3
            // Q1: Create phone book with 4 contacts
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                {"Ahmed", "01012345678"},
                {"Sara", "01123456789"},
                {"Ali", "01234567890"},
                {"Mona", "01598765432"}
            };

            // Q2: Add new contact using [] (add or update)
            phoneBook["Omar"] = "01000000000";

            // Q3: Try adding duplicate using .Add()
            try
            {
                phoneBook.Add("Ahmed", "999999999");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error (Add duplicate): " + ex.Message);
            }

            // Q4: Try adding duplicate using .TryAdd()
            bool added = phoneBook.TryAdd("Sara", "888888888");
            Console.WriteLine("TryAdd Sara success? " + added);

            // Q5: Search for a contact that doesn’t exist
            if (phoneBook.ContainsKey("Yara"))
            {
                Console.WriteLine("Yara found");
            }
            else
            {
                Console.WriteLine("Yara not found");
            }

            // Q6: Get contact with fallback
            string result = phoneBook.ContainsKey("Yara") ? phoneBook["Yara"] : "Not Found";
            Console.WriteLine("Yara Phone: " + result);

            // Q7: Print all keys in one line
            Console.WriteLine("\nAll Names:");
            Console.WriteLine(string.Join(", ", phoneBook.Keys));

            // Print all values in one line
            Console.WriteLine("\nAll Numbers:");
            Console.WriteLine(string.Join(", ", phoneBook.Values));


            //Exercise 4
            // Q1: Create HashSet with case-insensitive comparer
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Q2: Add emails
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            // Q3: Print count
            Console.WriteLine("Emails Count: " + emails.Count);

            // Explanation
            Console.WriteLine("Duplicates ignored because HashSet is case-insensitive");

            // Q4: Create sets
            HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };

            // Union
            var union = new HashSet<int>(A);
            union.UnionWith(B);
            Console.WriteLine("\nUnion: " + string.Join(", ", union));

            // Intersection
            var intersect = new HashSet<int>(A);
            intersect.IntersectWith(B);
            Console.WriteLine("Intersection: " + string.Join(", ", intersect));

            // Except
            var except = new HashSet<int>(A);
            except.ExceptWith(B);
            Console.WriteLine("Except (A - B): " + string.Join(", ", except));

            // Q6: Subset
            HashSet<int> subset = new HashSet<int> { 1, 2 };
            Console.WriteLine("Is {1,2} subset of A? " + subset.IsSubsetOf(A));
        

    }
}
}
