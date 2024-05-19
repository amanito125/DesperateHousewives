static void SayHello(string name)
{

    Console.WriteLine($"Hello, {name}!");

}

Thread thread = new Thread(() => SayHello("World"));
thread.Start();