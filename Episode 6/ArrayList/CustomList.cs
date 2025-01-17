﻿using System.Collections;

namespace ArrayListImplement
{
    public class CustomList<T> : IEnumerable
    {
        private const int INITIAL_CAPACITY = 2;

        private T[] items;

        public int Length { get; set; }

        public int Capacity { get; set; }

        public CustomList()
        {
            this.Capacity = INITIAL_CAPACITY;
            this.items = new T[Capacity];
        }

        public T this[int index]
        {
            get
            {
                CheckIndexOutsideBounds(index);
                return this.items[index];
            }

            set
            {
                CheckIndexOutsideBounds(index);
                this.items[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Length >= this.Capacity)
            {
                this.Capacity *= 2;

                T[] temp = new T[this.Capacity];

                for (int i = 0; i < items.Length; i++)

                {
                    temp[i] = items[i];
                }

                temp[this.Length] = element;
                items = temp;
                this.Length++;
            }
            else
            {
                items[this.Length] = element;
                this.Length++;
            }
        }

        public T Get(int index)
        {
            CheckIndexOutsideBounds(index);

            return this.items[index];
        }

        public void Set(int index, T element)
        {
            CheckIndexOutsideBounds(index);

            this.items[index] = element;
        }

        public void RemoveAt(int index)
        {
            CheckIndexOutsideBounds(index);

            for (int i = index; i < items.Length - 1; i++)

            {
                items[i] = items[i + 1];
            }

            this.Length--;
        }

        private void CheckIndexOutsideBounds(int index)
        {
            if (index < 0 || index >= this.Length)

            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)

            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}