using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    class Human : Humanoid
    {
        public Human(string name, int hp) : base(name, hp)
        {

        }

        public override string makeSound()
        {
            return "talks";
        }
    }

}
