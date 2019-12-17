using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull{
            get { 
                if (calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }
        }

        public void Eat(Food item){
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
            }
            else
            {
                Console.Error.Write("Ninja is full");
                System.Console.WriteLine($"{item.Name} is {item.IsSpicy}/{item.IsSweet}");
            }
        }
        
    }
}