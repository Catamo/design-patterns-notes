using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.Inheritance
{
    public partial class Animal
    { 
        private int _weight;

        public string Name { get; set; }
        public string Sound { get; set; }
        public int Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new Exception("Weight must be greater than 0");
            }
        }
    }
}
