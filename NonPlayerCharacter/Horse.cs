using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    class Horse : NonPlayerCharacter
    {
        public Horse(string name, int hp) : base(name, hp)
        {

        }

        public override string move()
        {
            return "canters";
        }

        public override string makeSound()
        {
            return "neighs";
        }
    }

}
