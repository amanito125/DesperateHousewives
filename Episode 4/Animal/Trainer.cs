using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStuff
{
    internal class Trainer
    {
        public IAnimal IAnimalEntity { get; set; }

        private string name;


        public string Name

        {

            get { return name; }

            set

            {

                if (string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty!");

                }

                else

                {

                    name = value;

                }

            }

        }

        public Trainer(string name, IAnimal animal)

        {

            Name = name;

            IAnimalEntity = animal;



        }

        public void Work(IAnimal entity)

        {

            IAnimalEntity = entity;

            Console.WriteLine($"Trainer {Name} works with {IAnimalEntity}");

        }

        public void Make()

        {

            IAnimalEntity.Perform();

        }



    }
}
