namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count 
        {
            get => this.data.Count;
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var element = this.data[this.Count - 1];
            
            this.data.Remove(element);

            return element;
        } 
    }
}
