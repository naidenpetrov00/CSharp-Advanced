using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Directory.GetFiles("../../TestFolder");
            var size = 0.0;

            foreach (var item in file)
            {
                FileInfo info = new FileInfo(item);

                size += info.Length;
            }
            size = size / 1024 / 1024;

            File.WriteAllText("Output.txt", size.ToString());
        }
    }
}
