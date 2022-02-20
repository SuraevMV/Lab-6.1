using System;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            bool t = true;
            startString = startString.Replace(" ", "");
            for (int i = 0, j = startString.Length - 1; i != startString.Length - 1; i++, j--)
            {
                if (startString[i] != startString[j])
                    t = false;
            }
            if (t == true)
                Console.WriteLine("Предложение является полиндромом");
        }
    }
}
