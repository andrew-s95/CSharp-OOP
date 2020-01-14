using System;
using System.Linq;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            OddArray();
        }

        //Print 1-255
        public static void PrintNumbers()
        {
            for (var i = 0; i < 256; i++){
                System.Console.WriteLine(i);
            }
        }
        //Print odd numbers between 1-255
        public static void PrintOdds()
        {
            for (var i = 0; i < 256; i++){
                if (i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
        //Print Sum
        public static void PrintSum()
        {
            int sum = 0;
            for (var i = 0; i < 256; i++){
                sum += i;
            }
            System.Console.WriteLine(sum);
        }
        //Iterate through an array
        public static void LoopArr(int[] numbers){
            int[] arr = { 1, 2, 3 };
            foreach (int num in arr){
                System.Console.WriteLine(num);
            }
        }
        //Find Max
        public static int FindMax(int[] numbers){
            int[] arr = { 1, 2, 3 };
            int maxValue = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxValue);
        }
        //Get Average
        public static void GetAverage(int[] numbers){
            int result = 0;
            for(int i = 0; i < numbers.Length; i++){
                result += numbers[i];
            }
            System.Console.WriteLine(result);
        }
        //Array with Odd Numbers
        public static int[] OddArray(){
            int[] arr = new int[128];
            for(int i = 1; i < 256; i=i+2){
            }
            return arr;
        }
        //Greater Than Y
        public static int GreaterThanY(int[] numbers, int y){
            
        }
    }
}
