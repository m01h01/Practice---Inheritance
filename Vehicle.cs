using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Vehicle
    {
        string _color;

        public Vehicle(string color)
        {
            Color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public override string ToString() 
        {
            return this.GetType() + $" - Color: {_color}"; 
        }
    }//class
}//namespace
