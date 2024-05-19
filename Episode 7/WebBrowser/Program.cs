List<string> pages = new List<string>();
string command = Console.ReadLine();
string previous = null;
while (!command.Equals("exit"))
{
    if (command.Equals("back"))
    {
        if (pages.Count != 1)
        {
            pages.Remove(previous);
            previous = pages.Last();
            Console.WriteLine(previous);
        }
    }
    else
    {
        previous = command;
        pages.Add(command);
    }

    command = Console.ReadLine();
}