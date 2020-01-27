using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            var numOne = new List<int> ();
            var numTwo = new List<int>(); ;
            var output = new List<int>(); ;
            var line = string.Empty;
            using (var readingStreamOne = new StreamReader("FileOne.txt"))
            {
                using (var readingStreamTwo = new StreamReader("FileTwo.txt"))
                {
                    using (var writing = new StreamWriter("Output.txt"))
                    {
                        line = readingStreamOne.ReadLine();
                        while (line != null)
                        {
                            numOne.Add(int.Parse(line));
                            line = readingStreamOne.ReadLine();
                        }

                        line = readingStreamTwo.ReadLine();
                        while (line != null)
                        {
                            numTwo.Add(int.Parse(line));
                            line = readingStreamTwo.ReadLine();
                        }

                        output.AddRange(numOne);
                        output.AddRange(numTwo);
                        output.Sort();

                        foreach (var item in output)
                        {
                            writing.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}
