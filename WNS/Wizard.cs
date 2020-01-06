using System;
using System.Collections.Generic;

namespace WNS
{
    public class Wizard : Human
    {
        public Wizard(string n) : base(n)
        {
            Name = n;
            Intelligence = 25;
            health = 50;
        }
        public void Heal()
        {
            health += 5 * Intelligence;
        }
        public void Fireball(object obj)
        {
            Random rand = new Random();
            Human target = obj as Human;
            target.health -= rand.Next(20,52);
        }
    }

}
   