using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.AbstractClassesAndInterfaces
{
    public interface ILiving
    {
        void setName(string newName);
        string getName();

        void setWeight(int newWeight);
        int getWeight();

        void setSound(string newSound);
        string getSound();
    }
}
