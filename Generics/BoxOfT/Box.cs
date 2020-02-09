namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> data = new List<T>();

        public int Count { get { return this.data.Count; } }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var element = this.data[Count - 1];

            this.data.RemoveAt(this.Count - 1);

            return element;
        }
    }

}
