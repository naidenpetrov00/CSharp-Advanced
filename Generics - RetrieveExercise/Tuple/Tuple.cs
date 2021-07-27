namespace Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tuple<T, K, L>
    {
        private T item1;
        private K item2;
        private L item3;

        public Tuple(T item1, K item2, L item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
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

        public L Item3
        {
            get { return this.item3; }
            private set { this.item3 = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(string.Format("{0} -> {1} -> {2}", this.Item1, this.Item2, this.Item3));

            return sb.ToString().Trim();
        }
    }
}
