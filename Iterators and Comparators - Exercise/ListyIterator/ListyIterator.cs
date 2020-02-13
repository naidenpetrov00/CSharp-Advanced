namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index = 0;

        public ListyIterator()
        {
            this.data = new List<T>();
        }

        public ListyIterator(params T[] elements)
        {
            this.data = new List<T>(elements);
            this.data.RemoveAt(0);
        }

        public bool Move()
        {
            if (LastIndexChecker())
            {
                this.index++;

                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return LastIndexChecker();
        }

        public void Print()
        {
            if (this.data.Count == 0 || this.data == null)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine($"{this.data[this.index]}");

        }

        public bool LastIndexChecker()
        {
            return this.index != this.data.Count - 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
