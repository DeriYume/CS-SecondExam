namespace SecondExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many names do you want to input?");
            Console.Write("Answer: ");
            int n = int.Parse(Console.ReadLine());

            string[] Names = new string[n];

            Console.WriteLine("");
            FillNames(Names);
            Console.WriteLine("");

            Console.WriteLine("Names starting with C:");
            CheckForStartingLetter(Names);
            Console.WriteLine("");

            FindSubstring(Names);
            Console.WriteLine("");

            Console.WriteLine("AVG length of the names: {0}", CalculateAVGNameSize(Names));

            Console.WriteLine("");
            CheckForDubs(Names);
        }

        static void FillNames(string[] Names)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Console.Write("Input name: ");
                Names[i] = Console.ReadLine();
            }
        }

        static void CheckForStartingLetter(string[] names)
        {
            string startingLetter = "C";
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith(startingLetter))
                    Console.WriteLine(names[i]);
            }
        }

        static void FindSubstring(string[] names)
        {
            int counter = 0;
            string[] str = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                str[i] = names[i];
                counter += str[i].Length - str[i].Replace("a", "").Length;
            }

            Console.WriteLine("\"a\" is seen {0} times.", counter);
        }

        static double CalculateAVGNameSize(string[] names)
        {
            double sum = 0;

            for (int i = 0; i < names.Length; i++)
            {
                sum += names[i].Length;
            }

            return sum / names.Length;
        }

        static void CheckForDubs(string[] names)
        {
            string name;
            for (int i = 0; i < names.Length; i++)
            {
                name = names[i];

                for (int j = i + 1; j < names.Length; j++)
                {
                    if (name == names[j])
                    {
                        Console.WriteLine(name + " is repeated.");
                    }
                }
            }
        }
    }
}
