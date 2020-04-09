using System.Collections.Generic;
using System;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Burrito", 1000, true, true),
                new Food("Tacos", 500, false, true),
                new Food("Pizza", 2000, false, false),
                new Food("Pot Stickers", 250, true, true),
                new Food("Noodles", 650, true, false),

            };
        }

        public Food Serve()
        {
            int length = Menu.Count;
            Random rand = new Random();
            return Menu[rand.Next(0, length)];
            
        }
        
    }
}