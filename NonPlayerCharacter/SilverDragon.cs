using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    class SilverDragon : Dragon
    {
        public SilverDragon(string name, int hp) : base(name, hp)
        {

        }

        public override string makeSound()
        {
            return "hisses";
        }
    }

}
