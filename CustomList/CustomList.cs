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
            if (count == capacity)
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
            T[] tempArray = new T[capacity];
            int j = 0;
            bool itemRemoved = false;

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) && !itemRemoved)
                {
                    itemRemoved = true;
                }
                else
                {
                    tempArray[j] = items[i];
                    j++;
                }

            }
            if (itemRemoved)
            {
                count--;
            }

            for (int i = 0; i < count; i++) // is there a better way to do this rather than create another for loop?
            {
                items[i] = tempArray[i];
            }

            ////Any items coming after the removed item should be shifted down so there is no empty index.
            ////If 'item' was removed, return true. If no item was removed, return false.
            return itemRemoved;
        }

        public override string ToString()
        {
            string myString = "";
            List<string> tempArray = new List<string>();

            for (int i = 0; i < count; i++)
            {
                tempArray.Add(items[i].ToString());
            }

            myString = string.Join(" ", tempArray);

            return myString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //create an empty list for ints
            //T[] tempArray = new T[firstList.capacity];
            CustomList<T> newList = new();


            for (int i = 0; i < firstList.count; i++)
            {
                newList.Add(firstList.Items[i]);
            }

            for (int i = 0; i < secondList.count; i++)
            {
                newList.Add(secondList.Items[i]);
            }

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return newList;

        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> newList = new();

            T[] tempArray = new T[firstList.capacity];
            int j = 0;
            bool itemRemoved = false;
            int maxItems;

            if (firstList.count > secondList.count)
            {
                maxItems = firstList.count;
            }
            else if (firstList.count < secondList.count)
            {
                maxItems = secondList.count;
            }
            else
            {
                maxItems = firstList.count;
            }

            for (int i = 0; i < maxItems; i++)
            {
                if (secondList.items.Contains(firstList.items[i]) && !itemRemoved)
                {
                    itemRemoved = true;
                    firstList.count--;
                }
                else
                {
                    tempArray[j] = firstList.items[i];
                    j++;
                }
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                firstList.items[i] = tempArray[i];
            }
            newList = firstList;

            return newList;
        }
    }
}