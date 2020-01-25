using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();

            string command = string.Empty;
            int countPassed = 0;

            while (command != "end")
            {
                command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < N && queue.Any(); i++)
                    {
                        Console.WriteLine($"{queue.Peek()} passed!");
                        queue.Dequeue();
                        countPassed++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
