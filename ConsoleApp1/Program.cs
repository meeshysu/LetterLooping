using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in something");
            string s = Console.ReadLine().ToLower();
            string endResult = "";
                for (int i = 0; i < s.Length; i++)
            {
                endResult += char.ToUpper(s[i]);

                for (int repeat = 0; repeat < i; repeat++)
                {
                    endResult += (s[i]);
                }
                if (i != (s.Length - 1))
                {
                    endResult += "-";
                }
            }
            
            Console.WriteLine(endResult);
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}
