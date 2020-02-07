namespace CustomDoublyLinkedList
{
    using System;

    public class MyDoublyLinkedList
    {

        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode(int value)
            {
                this.Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int item)
        {
            if (this.Count == 0)
            {
                EmptyListAddProblem(item);
            }
            else
            {
                var newHead = new ListNode(item);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(int item)
        {
            if (this.Count == 0)
            {
                EmptyListAddProblem(item);
            }
            else
            {
                var newTail = new ListNode(item);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                EmptyListRemoveProblem();
            }

            int firstItem = this.head.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.NextNode;
                this.head.PreviousNode = null;
            }

            this.Count--;
            return firstItem;
        }

        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                EmptyListRemoveProblem();
            }

            int lastItem = this.tail.Value;

            if (this.Count == 1)
            {
                this.tail = this.head = null;
            }
            else
            {
                this.tail = this.tail.PreviousNode;
                this.tail.NextNode = null;
            }

            this.Count--;
            return lastItem;
        }

        public void ForEach(Action<int> action)
        {
            var currentItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                action(currentItem.Value);

                if (currentItem.NextNode == null)
                {
                    break;
                }

                currentItem = currentItem.NextNode;
            }
        }

        public int[] ToArray()
        {
            var array = new int[this.Count];
            var currItem = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currItem.Value;
                currItem = currItem.NextNode;
            }

            return array;
        }

        private void EmptyListAddProblem(int item)
        {
            this.head = this.tail = new ListNode(item);
        }

        private void EmptyListRemoveProblem()
        {
            throw new Exception("The list is empty");
        }
    }
}
