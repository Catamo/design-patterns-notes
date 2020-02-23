using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.AbstractClassesAndInterfaces
{
    public abstract class Creature
    {
        //protected: Accessible to derived types (childs)
        //internal: Accessible to the assembly
        //public: Accessible everywhere
        //private: Accessible only in the body of the class which declared it

        protected string Name;
        protected int Weight;
        protected string Sound;

        public abstract void setName(string newName);
        public abstract string getName();

        public abstract void setWeight(int newWeight);
        public abstract int getWeight();

        public abstract void setSound(string newSound);
        public abstract string getSound();
    }
}
