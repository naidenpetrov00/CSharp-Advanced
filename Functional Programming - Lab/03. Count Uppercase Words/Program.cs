using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(word => word[0] == word.ToUpper()[0])
                .ToList()
                .ForEach(word => Console.WriteLine(word));
        }
    }
}
