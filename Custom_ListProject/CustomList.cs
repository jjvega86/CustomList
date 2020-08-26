using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Custom_ListProject
{
    public class CustomList <T> : IEnumerable<T>
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

        

        public T this [int i] // indexer allows use of index when returning value at an index or setting value at an index
        {
            get { return _items[i];}
            set { _items[i] = value; }
          
        }

        public CustomList() // constructor sets initial count to 0, capacity to 4, and instantiates the array with size as default capacity
        {
            _count = 0;
            _capacity = 4;

            _items = new T[_capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];

            }
        }




        public void Add(T item) // generic item allows any data type to be passed in
        {                   
            _items[_count] = item; //sets value passed in equal to the array location at the current count
            _count++; // count is then increased to make sure previous data isn't overwritten

            if (_count == _capacity) // if equal, size of array needs to be doubled to allow more values to be passed in
            {
                Capacity = IncreaseArrayCapacity(); //private method returns new double capacity and sets the Capacity property equal to it
                
            }

        }

        private int IncreaseArrayCapacity() // private method doubles capacity property
        {
            

            int newCapacity = _capacity * 2; // creates new property value as double the previous capacity
            T[] tempArray = new T[newCapacity];// temporary array allows old values to be passed into the doubled array


            for (int i = 0; i < _count; i++)
            {
                tempArray[i] = _items[i];
            }

            _items = tempArray;
            return newCapacity;

        }

        public bool Remove(T item)
        {
            // I want to look through all of the items in an array
            // if found, I want to remove that item
            // then assign all items ahead of it one index down in the array
            // if the count shrinks to half of the capacity, I want to decrease the array capacity by half
            
            //example
            // array has elements 1,2,3,4 
            // remove 1 at (located at 0 index)
            // count == 4
            // capacity == 8
            bool wasRemoved = false;

            for (int i = 0; i < _count; i++) // looks through index 0-3
            {
                if (_items[i].Equals(item)) // 1 is found at index 0!
                {
                    _items[i] = _items[i+1]; //items[0] = items[0+1 = 1]. items[0] = 2
                    i++; // equals 1

                    for (int j = i; j < _count-1; j++) // looks through index 1 - 2
                    {
                        _items[j] = _items[j + 1]; // items[1] = items[2], items[2] = items[3]
                        // loop ends at index 2
                    }

                    _items[_count] = default; //items[3] = 0
                    _count--;// count = 3
                    wasRemoved = true;
                    break;
                }
            }

            if (_count == (_capacity / 2))
            {
               Capacity =  DecreaseArrayCapacity();
            }

            return wasRemoved;

        }

        private int DecreaseArrayCapacity() // shrinks array when count is half of capacity; more efficient memory usage
        {
            int newCapacity = _capacity/2;

            T[] tempArray = new T[newCapacity]; 

            for (int i = 0; i < _count; i++)
            {
                tempArray[i] = _items[i];
            }

            _items = tempArray;
            return newCapacity;

        }

        public override string ToString() // overrides standard ToString method to allow for empty list case and looping through the custom list
        {
            string builtString = "";
            if (_count == 0)
            {
                builtString = null;
            }
            else
            {
                for (int i = 0; i < _count; i++)
                {
                    builtString += _items[i];

                }

            }
            return builtString;
        }

        public static CustomList<T> operator+ (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i]);

            }

            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list2[i]);

            }

            return result;
        }

        public static CustomList<T> operator- (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < list1.Count; i++)
            {
                for (int k = 0; k < list2.Count; k++)
                {
                    if (list1[i].Equals(list2[k]))
                    {
                        list1.Remove(list1[i]);

                    }

                }

            }

            result += list1;

            return result;
        }






    }
}
