using System;
using System.Collections;
using System.Collections.Generic;




namespace CustomListProject

{
    [TestMethod]
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

        [TestMethod]
        public void AddMethod(T item)
        {
            if (count > capacity)
            {

            }
            
               
          
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}
        