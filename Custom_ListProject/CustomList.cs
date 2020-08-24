using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Custom_ListProject
{
    public class CustomList <T>
    {
        T[] _items; // underscore because Microsoft naming conventions for private member variables

        int _capacity;
        int _count;

        public int Count // public read only property for CustomList. 
        {
            get
            {
                return _count;
            }
        }

        public int Capacity // public read and set property for CustomList
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public CustomList() // constructor sets initial count to 0, capacity to 4, and instantiates the array with size as default capacity
        {
            _count = 0;
            _capacity = 4;

            _items = new T[_capacity];
        }




        public void Add(T item) // generic item allows any data type to be passed in
        {
            _items[_count] = item;
            _count++;

            if (_count == _capacity)
            {
                Capacity = IncreaseArrayCapacity(ref _count, ref _capacity);
                
            }

        }

        private int IncreaseArrayCapacity(ref int count, ref int capacity)
        {
            //need to create a new array
            //three buckets
            //create a temporary array to transfer values
            //then a new array with the new capacity 

            int newCapacity = capacity * 2;
            T[] tempArray = new T[count];
            T[] newArray = new T[newCapacity];

            
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = _items[i];
                newArray[i] = tempArray[i];

            }
            _items = newArray;
            return newCapacity;
            
        }

        


    }
}
