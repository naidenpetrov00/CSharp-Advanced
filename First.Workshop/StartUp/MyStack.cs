namespace CustomDataStructures
{
    using System;

    class MyStack
    {
        private const int DefaultCapacity = 4;
        private int[] data;
        private int count;

        public MyStack()
        {
            this.data = new int[DefaultCapacity];
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void Push(int element)
        {
            if (this.Count == this.data.Length)
            {
                Resize();
            }

            this.data[this.Count] = element;
            this.Count++;
        }

        public int Pop()
        {
            var cleared = new int[this.data.Length - 1];

            for (int i = 0; i < this.data.Length - 1; i++)
            {
                cleared[i] = this.data[i];
            }

            int lastNum = this.data[this.Count - 1];
            this.data = cleared;
            this.Count--;

            if (this.Count <= this.data.Length / 4)
            {
                Shrink();
            }

            return lastNum;
        }

        public int Peek()
        {
            return this.data[this.Count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }

        private void Resize()
        {
            int[] resized = new int[this.data.Length * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                resized[i] = this.data[i];
            }

            this.data = resized;
        }

        private void Shrink()
        {
            var shrinked = new int[this.data.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                shrinked[i] = this.data[i];
            }

            this.data = shrinked;
        }
    }
}
