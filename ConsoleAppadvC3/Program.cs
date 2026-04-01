namespace ConsoleAppadvC3
{
    internal class Program
    {
        static void Main()
        {
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //foreach (var grade in grades)
            //{
            //    Console.WriteLine($"Grade: {grade}");

            //}
            //Console.WriteLine($"count: {grades.Count}");
            //Console.WriteLine($"first grade: {grades[0]}");
            //Console.WriteLine($"last grade: {grades[grades.Count - 1]}");
            //grades.Sort();
            //foreach (var grade in grades)
            //{
            //    Console.WriteLine($"Grade: {grade}");
            //}
            //var topGrades = grades.FirstOrDefault(g => g >= 90);
            //Console.WriteLine($"Top Grades:{topGrades}");
            //var below70Grades = grades.Where(g => g < 70).ToList();
            //Console.WriteLine("Grades below 70:");
            //foreach (var grade in below70Grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades after removing below 75:");
            //foreach (var grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //bool hasPerfectScore = grades.Any(g => g == 100);
            //Console.WriteLine($"Has perfect score: {hasPerfectScore}");
            //List<string> gradeinstring = grades.Select(g =>  $"Grade: {g}").ToList();
            //Console.WriteLine("Grades as strings:");
            //foreach (var grade in gradeinstring)
            //{
            //    Console.WriteLine(grade);

            //}
            //SortedList<int, string> leaderboard = new SortedList<int, string>() {{500, "Ahmed"},
            //{200, "Sara"},
            //{800, "Ali"},
            //{350, "Mona"} };
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Name: {entry.Value}");

            //}
            //Console.WriteLine(leaderboard.Keys[0]);
            //Console.WriteLine(leaderboard.Values[0]);
            //Console.WriteLine(leaderboard.ContainsKey(500));
            //if (leaderboard.TryGetValue(999, out string name))
            //{
            //    Console.WriteLine($"Name with score 999: {name}");
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found in leaderboard.");
            //}
            //leaderboard.Remove(200);
            //Console.WriteLine("Leaderboard after removing score 200:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Name: {entry.Value}");
            //}
            //Dictionary<string, string> phones = new Dictionary<string, string>() { {"ahmed","01002510624" },
            //    {"mina","01002420666" },
            //    {"omar","01254789630" },
            //    {"maro","01236547892" }};
            //phones["ahmed"] = "01000000000";
            //phones["mona"] = "01000000000";
            //foreach (var entry in phones)
            //{
            //    Console.WriteLine($"Name: {entry.Key}, Phone: {entry.Value}");
            //}
            //try
            //{
            //    phones.Add("sara", "01000110000");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error adding entry: {ex.Message}");
            //}
            //Console.WriteLine();
            //foreach (var entry in phones)
            //{
            //    Console.WriteLine($"Name: {entry.Key}, Phone: {entry.Value}");
            //}
            //Console.WriteLine();
            //bool addResult = phones.TryAdd("koko", "01000110000");
            //Console.WriteLine(addResult);
            //Console.WriteLine();
            //var name = "jojo";
            //if (!phones.ContainsKey(name))
            //{
            //    Console.WriteLine($"Name {name} not found in phones dictionary.");
            //}
            //Console.WriteLine();
            //foreach (var entry in phones.Keys)
            //{
            //    Console.WriteLine($"Name: {entry}");
            //}
            //Console.WriteLine();
            //foreach (var entry in phones.Values)
            //{
            //    Console.WriteLine($"phone: {entry}");
            //}
            //Console.WriteLine();
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");
            //Console.WriteLine("Emails count:" + emails.Count);//hashset does not allow duplicates and is case-insensitive due to StringComparer.OrdinalIgnoreCase
            //foreach (var email in emails)
            //{
            //    Console.WriteLine(email);

            //}
            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //var union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine("Union of setA and setB:");
            //foreach (var num in union)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();
            //var intersection = new HashSet<int>(setA);
            //intersection.IntersectWith(setB);
            //Console.WriteLine("Intersection of setA and setB:");
            //foreach (var num in intersection)
            //{
            //    Console.WriteLine(num);

            //}
            //Console.WriteLine();
            //var difference = new HashSet<int>(setA);
            //difference.ExceptWith(setB);
            //Console.WriteLine("Exception of setA and setB: ");
            //foreach (var num in difference)
            //{
            //    Console.WriteLine(num);

            //}
            //HashSet<int> smallSet = new HashSet<int> { 1, 2 };
            //Console.WriteLine( smallSet.IsSubsetOf(setA));
            //Queue<string> printer = new Queue<string>();
            //printer.Enqueue("Report.pdf");
            //printer.Enqueue("Invoice.pdf");
            //printer.Enqueue("Letter.docx");
            //printer.Enqueue("Resume.pdf");
            //printer.Enqueue("Photo.jpg");
            //foreach (var docs in printer)
            //{
            //    Console.WriteLine(docs);
            //}
            //Console.WriteLine( printer.Count);
            //Console.WriteLine();
            //Console.WriteLine( printer.Peek());
            //Console.WriteLine();
            //while (printer.Count > 0)
            //{
            //    string doc = printer.Dequeue();
            //    Console.WriteLine("Printing: " + doc);
            //}
            //if (printer.TryDequeue(out string result))
            //{
            //    Console.WriteLine("Dequeued: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty, nothing to dequeue");
            //}
        }
    }
}
