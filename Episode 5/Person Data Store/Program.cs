while (true)
{
    try
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        Person person = new Person(name, age);
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

public class Person
{
    private string firstName;
    private int age;

    public Person(string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value", "The first name cannot be null or empty");
            }
            firstName = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException("value", "Age should be in the range [0..120]");
            }
            age = value;
        }
    }
}