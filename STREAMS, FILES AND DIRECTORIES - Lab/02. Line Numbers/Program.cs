using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            int count = 1;
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    line = reader.ReadLine();
                    while (line != null || line == string.Empty)
                    {
                        writer.WriteLine($"{count}. {line}");
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
