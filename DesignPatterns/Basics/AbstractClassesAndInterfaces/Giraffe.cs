using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.AbstractClassesAndInterfaces
{
    public class Giraffe : Creature
    {
        public override string getName()
        {
            return Name;
        }

        public override string getSound()
        {
            return Sound;
        }

        public override int getWeight()
        {
            return Weight;
        }

        public override void setName(string newName)
        {
            Name = newName;
        }

        public override void setSound(string newSound)
        {
            Sound = newSound;
        }

        public override void setWeight(int newWeight)
        {
            Weight = newWeight;
        }
    }
}
