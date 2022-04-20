using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class2
    {
        class ReplaceXWithYTask
        {
            public static string ReplaceXWithY(string word)
            {
                string[] words = word.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains("y"))
                    {
                        words[i] = words[i].Replace("y", "x");
                    }
                }

                return String.Join(" ", words);
            }

            public static void Main()
            {
                Console.WriteLine(ReplaceXWithY("yyy"));                                   // xxx
                Console.WriteLine(ReplaceXWithY("strawberry youghurt"));                   // strawberrx xoughurt
                Console.WriteLine(ReplaceXWithY("tym ryhosx oifg 6 t6 ypeg ergh"));        // txm rxhosx oifg 6 t6 xpeg ergh
                Console.WriteLine(ReplaceXWithY(""));                                      // /empty string/
                Console.ReadLine();
            }
        }
    }
}
