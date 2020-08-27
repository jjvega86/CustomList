using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Custom_ListProject
{
    public class CustomList <T> : IEnumerable
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

      

        public IEnumerator GetEnumerator()
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

        public bool Remove(T item) // removes a single instance of the item. Pulls the other elements down an index
        {
            bool wasRemoved = false;

            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Equals(item)) 
                {
                    _items[i] = _items[i+1]; 
                    i++; 

                    for (int j = i; j < _count-1; j++) 
                    {
                        _items[j] = _items[j + 1];
                        
                    }

                    _items[_count] = default;
                    _count--;
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

        public CustomList<T> Zip(CustomList<T> listToZip)
        {
            // I want to zip two lists together
            // by taking the first value from the first list
            // then adding the first value from the second list
            // and going back and forth
            // adding the combined list to the result list and returning that result

            CustomList<T> result = new CustomList<T>();
            int counter = this.Count + listToZip.Count;
            int index = 0;

            while (counter > 0)
            {
                if (_count == 0)
                {
                    result.Add(listToZip[index]);
                    counter--;
                    index++;

                }
                else if (listToZip._count == 0)
                {
                    result.Add(_items[index]);
                    counter--;
                    index++;

                }
                else
                {
                    result.Add(_items[index]);
                    counter--;
                    result.Add(listToZip[index]);
                    counter--;
                    index++;
                }

            }
            return result;

        }






    }
}
