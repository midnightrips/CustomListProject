﻿namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myList = new();

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList.Capacity);
            Console.WriteLine(myList.Items[2]);

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}