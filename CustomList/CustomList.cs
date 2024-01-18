using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items; 
        public T[] Items 
        {
            get
            {
                return items;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity]; //array matching the capacity
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            items[count] = item;
            count++;

            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            if (count > capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    tempArray[i] = items[i];
                }

                items = tempArray;
            }
            
        }

        public bool Remove(T item)
        {
            //still need to remove an item if this method is called even if there isn't another instance of it...
            List<T> initialItems = new();
            //If 'item' exists in the 'items' array, remove its first instance
            for(int i=0; i < items.Length; i++)
            {
                initialItems[i] = items[i];

                if(initialItems[i] == item) 
                {
                    initialItems.RemoveAt(i);
                    count--;
                    items[i] = initialItems[i];
                    return true;
                }
            }

 
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString() //returns a single string that contains all items from array
        {
            string myString = "";
            List<T> initialItems = new();

            //convert each item into a string
  
            for (int i = 0; i <items.Length; i++)
            {
                initialItems[i] = items[i];
                //if int convert int to string here
                myString = myString + initialItems[i];
            }

            return myString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
