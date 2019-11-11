using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_FAMILY
{
    class Member
    {
        public Member(string name, int age, int height, int weight, string health)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Health = health;

        }

        public string Name { get; }
        public int Age { get; }
        public int Height { get; }
        public int Weight { get; }
        public string Health { get; set; }
        public void Info()
        {
            if (Height >= 180 && Weight <= 50)
            {
                Health = "fat";
                Console.WriteLine($"His name is {Name}. He is {Age} years old. His height is {Height} and weight is {Weight}. He is {Health}.");
            }
            else if (Height <= 150 && Weight >= 70)
            {
                Health = "slim";
                Console.WriteLine($"His name is {Name}. He is {Age} years old. His height is {Height} and weight is {Weight}. He is {Health}.");
            }

            else
            {
                Health = "normal";
                Console.WriteLine($"His name is {Name}. He is {Age} years old. His height is {Height} and weight is {Weight}. He is {Health}.");
            }
                
        }


    }
}
