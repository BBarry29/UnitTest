using System.Collections.Generic;




namespace CustomListProject
{
    class MyCustomList<T> : IEnumerable<T>
    {
        T[] items;
        public int capacity;
        public int count;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public MyCustomList()
        {
            count = 0;
            capacity = 5;
            items = new T[capacity];
        }
        public void AddMethod(T item)
        {
            if (count > capacity / 2)
            {
                DoubleArraySize();
            }
            items[count] = item;
            count++;
        }
    }
}
        
