using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Basics.Inheritance
{
    public partial class Dog : Animal
    {
        partial void SetFieldValues();

        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }

        public Dog() : base()
        {
            Sound = "Bark";

            SetFieldValues();
        }

        public void ChangeVar(int randNum)
        {
            randNum = 12;

            Console.WriteLine("randNum in method: " + randNum);
        }
    }
}
