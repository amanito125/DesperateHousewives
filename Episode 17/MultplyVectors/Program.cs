using System.Numerics;

var input1 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToList();
Vector3 v1 = new Vector3(input1[0], input1[1], input1[2]); ;
var input2 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToList(); ;
Vector3 v2 = new Vector3(input2[0], input2[1], input2[2]);
Vector3 answer = v2 * v1;
Console.WriteLine(answer);