using System;

namespace Lab_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string stringResult = "";
            int bigWord = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > bigWord)
                {
                    stringResult = stringArray[i];
                    bigWord = stringArray[i].Length;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении \"{0}\"", stringResult);
            Console.ReadKey();
           
        }
    }
}
