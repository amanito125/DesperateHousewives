namespace AnimalStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var animals = new List<Animal>();

            for (int i = 0; i < number; i++)

            {

                string[] input = Console.ReadLine().Split();

                string type = input[0];

                string name = input[1];

                switch (type)

                {

                    case "Dog":

                        Dog dog = new Dog();

                        dog.Name = name;
                        dog.Type = type;

                        animals.Add(dog);

                        break;


                    case "Cat":

                        Cat cat = new Cat();

                        cat.Name = name;
                        cat.Type = type;

                        animals.Add(cat);

                        break;


                    default:

                        break;

                }

            }

            string trainerName = Console.ReadLine();

            Trainer trainer = null;

            string command = Console.ReadLine();

            while (command != "End")

            {

                Animal current = animals.FirstOrDefault(a => a.Name == command);

                if (current == null)

                {

                    Console.WriteLine("No such name in the Database!");

                }

                else

                {

                    if (trainer == null)

                    {

                        trainer = new Trainer(trainerName, current);

                    }

                    trainer.Work(current);

                    trainer.Make();

                }

                command = Console.ReadLine();

            }



        }
    }
}
