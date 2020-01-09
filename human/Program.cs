using System;

namespace human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human op = new Human("Andrew", 100, 100, 100, 1000);
        }
    }
    class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
        private int health { get; set; } = 100;
        
        // add a public "getter" property to access health
        public int Health{
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
        }
        // Add a constructor to assign custom values to all fields :this(name)
        public Human(string name, int strength, int intelligence, int dexterity, int health) 
        {
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = Health;
        }
        // Build Attack method
        public void Attack(Human opponent)
        {
            var Opponent = (Human) opponent;
            Opponent.health -= 5 * Strength;
            System.Console.WriteLine($"Attack! {Opponent.Name}");
            System.Console.WriteLine($"Remaining health of opponent: {Opponent.health}");
        }
    }
}
           