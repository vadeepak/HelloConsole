using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Class3
    {
        public static void Main()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (length <= str.Length - 1 )
            {
                Console.Write("{0} ", str[length]);
                length++;
            }
            Console.ReadLine();
        }
    }

}

