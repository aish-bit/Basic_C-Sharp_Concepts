using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        public string name;
        public int age;

        public Player(string name,int age)
        {
            Console.WriteLine("Inside constructor");
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Player {name} is now {age} years old");
        }
    }
}
