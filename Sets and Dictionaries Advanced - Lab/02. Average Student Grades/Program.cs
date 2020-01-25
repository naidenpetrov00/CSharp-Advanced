using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var StudentsResults = new Dictionary<string, List<decimal>>();
            var student = new string[] { };
            var name = string.Empty;
            decimal grade = 0;

            for (int i = 0; i < num; i++)
            {
                student = Console.ReadLine()
                    .Split()
                    .ToArray();

                name = student[0];
                grade = decimal.Parse(student[1]);

                if (!StudentsResults.ContainsKey(name))
                {
                    StudentsResults.Add(name, new List<decimal> { grade });
                }
                else
                {
                    StudentsResults[name].Add(grade);
                }
            }

            foreach (var item in StudentsResults)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grades in item.Value)
                {
                    Console.Write($"{grades:F2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average()})");
            }
        }
    }
}
