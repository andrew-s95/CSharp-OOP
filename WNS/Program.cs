using System;

namespace WNS
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Wizard("Jo", new Fireball());
            var player2 = new Samurai("John", new death_blow());
            System.Console.WriteLine(player1);
            System.Console.WriteLine(player2);
        }
    }
}
