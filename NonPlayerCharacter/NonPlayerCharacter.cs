using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    abstract class NonPlayerCharacter
    {
        protected string name;
        protected int hitPoints;

        public NonPlayerCharacter(string name, int hp)
        {
            this.name = name;
            this.hitPoints = hp;
        }
        public abstract string move();
        public abstract string makeSound();
    }

}
