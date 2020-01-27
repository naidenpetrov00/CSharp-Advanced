using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = new Dictionary<string, int>();
            var text = new string[] { };
            var Input = new string[] { };

            using (var reader = new StreamReader("words.txt"))
            {
                text = reader.ReadToEnd().Split().Select(a => a.ToLower()).ToArray();
                foreach (var item in text)
                {
                    word.Add(item, 1);
                }
                using (var input = new StreamReader("text.txt"))
                {
                    Input = input.ReadToEnd().Split().Select(a => a.ToLower()).ToArray();
                    foreach (var item in Input)
                    {
                        if (word.ContainsKey(item))
                        {
                            word[item]++;
                        }
                    }
                }
                using (var writer = new StreamWriter("Output.txt"))
                {
                    foreach (var item in word.OrderByDescending(a=>a.Value))
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
