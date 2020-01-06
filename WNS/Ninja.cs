using System;

namespace WNS
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            Dexterity = 175;
        }
        public void Steal(object obj)
        {
            Human target = obj as Human;
            {
                Attack(target);
                health += 5;
            }
        }
        public void run()
        {
            health -= 15;
        }
    }
}
