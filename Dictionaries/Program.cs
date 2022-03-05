using System;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();

            dictionary.Add("Fred ", 22);
            dictionary.Add("Erik ", 36);
            dictionary.Add("Elise ", 18);
            dictionary.Add("Beth ", 29);
            dictionary.Write();
            Console.ReadLine();
        }
    }
}