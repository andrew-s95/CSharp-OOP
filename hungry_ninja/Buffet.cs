using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
            new Food("Pie", 100, false, true),
            new Food("Ribs", 120, true, true),
            new Food("Burger", 80, false, true),
            new Food("Ice Tea", 20, false, true),
            new Food("Hot Dog", 70, true, false),
            new Food("Rice", 50, false, false),
            new Food("Wings", 60, true, true),
            };
        }
        public Food Serve()
        {
            Random randFood = new Random();
            int randInt = randFood.Next(Menu.Count);
            return Menu[randInt];
        }
    }
}
