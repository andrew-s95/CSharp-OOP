using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet lunch = new Buffet();
            Ninja andrew = new Ninja();
            while (andrew.IsFull == false)
            {
                andrew.Eat(lunch.Serve());
            }
            System.Console.WriteLine(andrew.IsFull);
        }
    }
}
