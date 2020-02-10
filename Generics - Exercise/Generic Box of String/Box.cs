namespace _01.GenericBoxofString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> data;

        public Box(List<T> element)
        {
            this.data = element;
        }

        public void ToString()
        {
            foreach (var item in data)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public void Swaper(int firstIndex, int secondIndex)
        {
            var firstValue = data[firstIndex];
            var secondValue = data[secondIndex];

            data[firstIndex] = secondValue;
            data[secondIndex] = firstValue;
        }
    }
}
