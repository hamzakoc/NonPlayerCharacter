using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{

    abstract class Humanoid : NonPlayerCharacter
    {
        public Humanoid(string name, int hp) : base(name, hp)
        {

        }

        public override string move()
        {
            return "walks";
        }
    }

}
