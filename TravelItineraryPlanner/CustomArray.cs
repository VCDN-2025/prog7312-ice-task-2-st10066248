using System;

namespace TravelItineraryPlanner
{
    public class CustomArray<T>
    {
        private T[] items;
        private int count;

        public CustomArray(int capacity = 4)
        {
            items = new T[capacity];
            count = 0;
        }

        public int Count => count;
        public int Capacity => items.Length;

        public void Add(T item)
        {
            if (count == items.Length) Resize();
            items[count++] = item;
        }

        private void Resize()
        {
            int newCapacity = items.Length * 2;
            T[] newItems = new T[newCapacity];
            Array.Copy(items, newItems, items.Length);
            items = newItems;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index < 0) return false;
            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
            for (int i = index; i < count - 1; i++)
                items[i] = items[i + 1];
            items[--count] = default;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
                if (Equals(items[i], item)) return i;
            return -1;
        }

        public bool Contains(T item) => IndexOf(item) >= 0;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
                items[index] = value;
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }
}

