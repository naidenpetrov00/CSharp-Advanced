using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var command = string.Empty;
            Func<string, List<int>, List<int>> commandApplyer = (w, n) => Plaser(w, n);

            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end") break;

                nums = commandApplyer(command, nums);

            }
        }
        static List<int> Plaser(string command, List<int> nums)
        {
            switch (command)
            {
                case "add": return Add(nums);
                case "multiply": return Multiply(nums);
                case "subtract": return Subtract(nums);
                case "print": return Print(nums);
                default:return null;
            }
        }
        static List<int> Add(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i]++;
            }
            return nums;
        }
        static List<int> Multiply(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i]*=2;
            }
            return nums;
        }
        static List<int> Subtract(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i]--;
            }
            return nums;
        }
        static List<int> Print(List<int> nums)
        {
            Console.WriteLine(string.Join(" ", nums));
            return nums;
        }
    }
}
