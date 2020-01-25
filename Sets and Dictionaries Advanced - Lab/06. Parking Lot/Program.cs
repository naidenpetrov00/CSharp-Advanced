using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new HashSet<string>();
            var Command = new string[] { };
            var command = string.Empty;
            var carNum = string.Empty;

            while (command != "END")
            {
                Command = Console.ReadLine().Split(',').ToArray();
                command = Command[0];
                if (command == "END")
                {
                    break;
                }
                carNum = Command[1];

                if (command == "IN")
                {
                    numbers.Add(carNum);
                }
                else if (command == "OUT") 
                {
                    numbers.Remove(carNum);
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
