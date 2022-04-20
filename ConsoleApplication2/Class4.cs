using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class4
    {
        public static void Main()
        {
            string str;
            int length = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (length >= 0)
            {
                Console.Write("{0} ", str[length]);
                length--;
            }
            Console.ReadLine();
        }
    }
}
