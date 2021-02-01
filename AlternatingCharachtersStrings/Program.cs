using System;

namespace AlternatingCharachtersStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string a = Console.ReadLine();
                Console.WriteLine(AlternatingCharacters(a));
            }
          
         }

        static int AlternatingCharacters(string s)
        {
            int count = 0;
            int i = 0;

            while (i != s.Length-1)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                   
                }

                i++;

            }   
           

            return count;

        }
    }
}
