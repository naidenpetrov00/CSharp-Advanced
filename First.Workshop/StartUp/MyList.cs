namespace CustomDataStructures
{
    using System;

    public class MyList
    {
        private int[] data;
        private const int DefaultCapacity = 2;

        public MyList()
        {
            this.data = new int[DefaultCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.data[index];
            }
            set
            {
                if (index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.data[index] = value;
            }
        }

        public void Add(int element)
        {
            if (this.data.Length == this.Count)
            {
                Resize();
            }

            data[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int item = this.data[index];
            Shift(index);
            this.Count--;

            if (this.Count <= this.data.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public bool Contains(int element)
        {

            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex > this.Count - 1
                || secondIndex < 0 || secondIndex > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int firstNum = this.data[firstIndex];
            int secondNum = this.data[secondIndex];

            this.data[firstIndex] = secondNum;
            this.data[secondIndex] = firstNum;
        }

        private void Resize()
        {
            var resized = new int[this.data.Length * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                resized[i] = this.data[i];
            }

            data = resized;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }

        private void Shrink()
        {
            int[] shrinked = new int[this.data.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                shrinked[i] = this.data[i];
            }

            this.data = shrinked;
        }
    }
}
