namespace Wek70.Exercise9
{
    public static class AscendingLINQ
    {
        public static void Run()
        {
            AscendLINQ();
        }

        private static void AscendLINQ()
        {
            List<Student> students = new List<Student>
            {
            new Student { Name = "Alice", Grade = "A" },
            new Student { Name = "Bob", Grade = "B" },
            new Student { Name = "Charlie", Grade = "A" },
            new Student { Name = "Dave", Grade = "C" }
            };
            List<string> namesWithA = students.Where(x => x.Grade == "A")
                                             .OrderByDescending(x => x.Name)
                                             .Select(x => x.Name)
                                             .ToList();

            Console.WriteLine("Names of students with grade A in descending order are :");
            foreach (string student in namesWithA)
            {
                Console.WriteLine(student);
            }

        }

    }
}
