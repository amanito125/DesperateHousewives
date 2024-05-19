using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStuff
{
    internal abstract class Animal : IAnimal
    {
        public string Type { get; set; }

        private string name;


        public string Name

        {

            get { return name; }

            set

            {

                if (string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty");

                }

                else

                {

                    name = value;

                }

            }

        }


        public virtual string MakeNoise()

        {

            return "I am an animal";

        }


        public virtual string MakeTrick()

        {

            return "I make trick";

        }


        public void Perform()

        {

            Console.WriteLine(MakeNoise());

            Console.WriteLine(MakeTrick());

        }


        public override string ToString()

        {

            return $"{Type} {Name}";

        }

    }



}

