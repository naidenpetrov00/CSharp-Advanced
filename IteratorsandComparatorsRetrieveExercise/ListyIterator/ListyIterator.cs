namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListyIterator<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(params T[] data)
        {
            this.data = new List<T>(data);
            this.Index = 0;
        }

        public IReadOnlyList<T> Data
        {
            get { return this.data; }
        }

        public int Count
        {
            get { return this.data.Count; }
        }

        public int Index
        {
            get { return this.index; }
            private set { this.index = value; }
        }

        public bool Move()
        {
            if (this.Index >= this.Count - 1)
            {
                return false;
            }

            this.Index++;

            return true;
        }

        public bool HasNext()
        {
            if (this.Index >= this.Count - 1)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Invalid Operation!");
            }

            Console.WriteLine(this.Data[this.Index]);
        }


    }
}
