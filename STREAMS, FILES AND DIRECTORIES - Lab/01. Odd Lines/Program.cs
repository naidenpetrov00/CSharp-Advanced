using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Input.txt");
            var counter = 0;
            string line = string.Empty;
            using (reader)
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        line = reader.ReadLine();

                        if (counter % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
