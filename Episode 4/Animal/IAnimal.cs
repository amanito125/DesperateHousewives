using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStuff
{
    internal interface IAnimal : IMakeNoise, IMakeTrick
    {
        public string Type { get; }

        public string Name { get; }


        void Perform();

        public virtual string MakeNoise()

        {

            return "I am an animal";

        }

        public virtual string MakeTrick()

        {

            return "I make trick";

        }
    }
}
