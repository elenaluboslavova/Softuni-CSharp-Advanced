using System;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Stack_and_Queue
{
    public class CustomStack
    {
        private const int INITIAL_CAPACITY = 4;
        private int[] items;
        private const string EMPTY_STACK_EXC_MSG = "Stack is empty";

        public CustomStack()
        {
            this.items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; }

        public void Push(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }
            int poppedItem = this.items[this.Count - 1];
            this.items[this.Count - 1] = default;
            this.Count--;
            return poppedItem;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }
            int lastItem = this.items[this.Count - 1];
            return lastItem;
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
