using System.Numerics;

var input1 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToList();
Vector3 A = new Vector3(input1[0], input1[1], input1[2]);
var input2 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToList();
Vector3 B = new Vector3(input2[0], input2[1], input1[2]);

Vector3 answer = A - B;
Console.WriteLine(answer);