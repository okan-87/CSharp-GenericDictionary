using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            myDictionary<string, int> myDictionary = new myDictionary<string, int>();
            myDictionary.Add("Python", 1991);
            myDictionary.Add("Java", 1995);
            myDictionary.Add("C#", 2000);

            Console.WriteLine(myDictionary.Length);

            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("{0} : {1}", myDictionary.Keys[i], myDictionary.Values[i]);
            }
        }
    }
}
