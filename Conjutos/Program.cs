using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("How many students for course A ?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int read = int.Parse(Console.ReadLine());
                A.Add(read);
            }

            Console.WriteLine("How many students for course B ?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int read = int.Parse(Console.ReadLine());
                B.Add(read);
            }

            Console.WriteLine("How many students for course C ?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int read = int.Parse(Console.ReadLine());
                C.Add(read);
            }

            HashSet<int> all = new HashSet<int>(A);

            all.Union(B);
            all.Union(C);
            Console.WriteLine("Total: " + all.Count);




        }
    }
}