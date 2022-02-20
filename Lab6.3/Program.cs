using System;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] a = new int[s.Length];
            int ind = 0;
            int i = 0;

            while (i < s.Length)
            {
                if (s[i] == '{')
                    a[ind++] = i;
                if (s[i] == '}' && ind > 0)
                {
                    int startIndex = a[ind - 1];
                    int count = i - a[ind - 1] + 1;
                    s = s.Remove(startIndex, count);
                    i = startIndex - 1;
                    ind--;
                }
                i++;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
