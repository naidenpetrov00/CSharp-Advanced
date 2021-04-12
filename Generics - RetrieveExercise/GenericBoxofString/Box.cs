namespace GenericBoxofString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public void ToString()
        {
            Console.WriteLine($"{this.value.GetType()}: {this.value}");
        }
    }
}
