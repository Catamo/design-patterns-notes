using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.AbstractClassesAndInterfaces
{
    public class Monkey : ILiving
    {
        private string _name;
        private int _weight;
        private string _sound;

        public string getName()
        {
            return _name;
        }

        public string getSound()
        {
            return _sound;
        }

        public int getWeight()
        {
            return _weight;
        }

        public void setName(string newName)
        {
            _name = newName;
        }

        public void setSound(string newSound)
        {
            _sound = newSound;
        }

        public void setWeight(int newWeight)
        {
            _weight = newWeight;
        }
    }
}
