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
            T[] tempArray = new T[_count]; // temporary array allows old values to be passed into the doubled array
            T[] newArray = new T[newCapacity];

            
            for (int i = 0; i < _count; i++)
            {
                tempArray[i] = _items[i];
                newArray[i] = tempArray[i];

            }
            _items = newArray;
            return newCapacity;
            
        }

        public bool Remove(T item)
        {
            //I want to look through all of the items in an array
            //if found, I want to remove that item
            //then assign all items ahead of it one index down in the array
            //if the count shrinks to half 
            
            bool wasRemoved = false;

            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {

                    _count--;

                }

            }

            return wasRemoved;

        }

        


    }
}
