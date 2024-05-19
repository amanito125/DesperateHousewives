using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStuff
{
    internal class Cat: Animal
    {
        public override string MakeNoise()

        {

            return "Meow!";

        }


        public override string MakeTrick()

        {

            return "No trick for you! I'm toll lazy!";

        }
    }
}
