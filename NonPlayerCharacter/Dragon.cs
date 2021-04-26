using System;
using System.Collections.Generic;
using System.Text;

namespace NonPlayerCharacter
{
    abstract class Dragon : NonPlayerCharacter
    {
        public Dragon(string name, int hp) : base(name, hp)
        {

        }

        public override string move()
        {
            return "flies";
        }
    }


}
