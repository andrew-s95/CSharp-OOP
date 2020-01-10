using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {   
            //int arr
            int[] arr;
            arr = new int[] {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(arr[1]);

            //string arr
            string[] name = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            //boolean arr
            bool[] boolarr = new bool[10];
            boolarr[0] = true;

            //list 5 ice cream flavors
            List<string> icecream = new List<string>(); 
            icecream.Add("Chocolate");
            icecream.Add("Vanila");
            icecream.Add("Rocky Road");
            icecream.Add("Coffee");
            icecream.Add("Pistachio");

            //display length of list
            Console.WriteLine(icecream.Count);

            //output 3rd flavor then remove
            Console.WriteLine(icecream[2]);
            icecream.RemoveAt(2);

            //output new length
            Console.WriteLine(icecream.Count);

            //Create a dictionary
            Dictionary<string,string> dict = new Dictionary<string, string>();

            //add name and flavor to dict
            dict.Add("Andrew", "Chocolate");
            dict.Add("Erik", "Rum & Raisin");

            //Loop through dict
            foreach (KeyValuePair<string,string> entry in dict)
            {
                System.Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
