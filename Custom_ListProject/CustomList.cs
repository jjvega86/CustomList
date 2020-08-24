using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public CustomList()
        {
            _count = 0;
            _capacity = 4;

            _items = new T[_capacity];
        }




        public void Add(T item)
        {
            T[] tempArray = new T[];
            _items[_count] = item;
            _count++;

            if (_count == _capacity)
            {
                //need to create a new array
                //three buckets
                //create a temporary array to transfer values
                //then a new array with the new capacity    
            }

        }



    }
}
