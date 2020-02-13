namespace Stack
{
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private List<T> data;

        public Stack()
        {
            this.data = new List<T>();
        }

        public int Count { get { return this.data.Count; } }

        public void Push(params T[] elements)
        {
            this.data.AddRange(elements);
        }

        public T Pop()
        {
            var lastValue = this.data[this.Count - 1];

            this.data.RemoveAt(this.Count - 1);

            return lastValue;
        }
        public bool EmptyStackCheck()
        {
            return this.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = -1;

            for (int i = this.Count - 1; i >= 0; i--)
            {
                count++;

                yield return this.data[i];

                if (count == this.Count * 2 - 1)
                {
                    break;
                }
                if (i == 0)
                {
                    i = this.Count;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}