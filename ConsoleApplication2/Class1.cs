using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<List<int>> myTable = new List<List<int>>();
            myTable.Add(new List<int> { 1, 3, 5 });
            myTable.Add(new List<int> { 4, 5 });
            myTable.Add(new List<int> { 5, 6, 8 });

            foreach(var list in myTable)
            {
                Console.WriteLine("*************");

                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();

        }
    }
}
