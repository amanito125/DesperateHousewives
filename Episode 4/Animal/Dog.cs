using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStuff
{
    internal class Dog: Animal
    {
        public override string MakeNoise()

        {

            return "Woof!";

        }


        public override string MakeTrick()

        {

            return "Hold my paw, human!";

        }
    }
}
