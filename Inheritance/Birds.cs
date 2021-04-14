using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {

        public int Wings { get; set; }

        public string Type { get; set; }

        public bool IsWarmBlooded { get; set; }

        public bool HasFeathers { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool hasBackbone, bool isWarmBlooded, bool hasFeathers, int wings, string type)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
            Wings = wings;
            Type = type;
        }
    }
}
