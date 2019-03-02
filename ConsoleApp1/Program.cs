using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in something");
            string s = Console.ReadLine().ToLower();
            string output = "";
                for (int i = 0; i < s.Length; i++)
            {
                output += char.ToUpper(s[i]);

                for (int repeat = 0; repeat < i; repeat++)
                {
                    output += (s[i]);
                }
                output += "-";
            }
            string remove = output.Remove(output.Length - 1);
            Console.WriteLine(remove);
            Console.ReadLine();
        }
    }
}
