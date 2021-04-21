namespace Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MyTuple<T,K>
    {
        private T item1;
        private K item2;

        public MyTuple(T item1, K item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T Item1
        {
            get { return this.item1; }
            private set { this.item1 = value; }
        }

        public K Item2
        {
            get { return this.item2; }
            private set { this.item2 = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(string.Format($"{0} > {1}", this.Item1, this.Item2));

            return sb.ToString().Trim();
        }
    }
}
