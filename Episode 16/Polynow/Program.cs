using MathNet.Numerics;

var coef = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).Reverse().ToList();
var p = new Polynomial(coef);
var answ = FindRoots.Polynomial(p);
Console.WriteLine(string.Join(" ", answ));