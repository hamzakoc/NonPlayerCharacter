using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    class Kobold : Humanoid
    {
        public Kobold(string name, int hp) : base(name, hp)
        {

        }

        public override string makeSound()
        {
            return "clicks";
        }
    }

}
