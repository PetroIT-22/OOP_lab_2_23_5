using System;

namespace OOP_lab_2_23_5
{
    class Program
    {
        private static int IndexMin(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] <= array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        private static int IndexMax(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= array[index])
                {
                    index = i;
                }
            }

            return index;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] elements = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(elements[0]);
            int m = int.Parse(elements[1]);

            int[][] array = new int[n][];
            int[] b = new int[m];

            var random = new Random();

            for (int i = 0; i < n; ++i)
            {
                b[i] = 1;
            }

            for (int i = 0; i < n; ++i)
            {
                array[i] = new int[m];

                for (int j = 0; j < m; ++j)
                {
                    array[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                int a = IndexMax(array[i]);
                int c = IndexMin(array[i]);

                for (int j = 0; j < m; ++j)
                {
                    b[i] *= array[j][a];
                    b[i] *= array[j][c];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0,-4} ", array[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < b.Length; ++i)
            {
                Console.WriteLine("b[{0}] = {1}", i, b[i]);
            }
        }
    }
}
