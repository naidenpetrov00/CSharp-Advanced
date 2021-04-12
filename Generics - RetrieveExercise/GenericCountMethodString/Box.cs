namespace GenericCountMethodString
{
    using System;

    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.value; }
            private set { this.value = value; }
        }

        public void ToString()
        {
            Console.WriteLine($"{this.value.GetType()}: {this.value}");
        }
    }
}
