using System;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;

var matrix = DenseMatrix.OfArray(new double[,] { { 3, 2, -5 }, { 2, -1, 3 }, { 1, 2, -1 } });
Vector<double> solve = new DenseVector(new double[] { -1, 13, 9 });
var answer = matrix.Solve(solve);
Console.WriteLine(answer);





//short one

var matrix2 = DenseMatrix.OfArray(new double[,] { { 3, 2 }, { 4, -1 } });
Vector<double> solve2 = new DenseVector(new double[] { 22, 21 });
var answe2r = matrix2.Solve(solve2);
Console.WriteLine(answe2r);


var matrix3 = DenseMatrix.OfArray(new double[,] { { 1, 2, 5 }, { 1, -1, 2 }, { 3, -6, -1 } });
Vector<double> solve3 = new DenseVector(new double[] { -9, 3, 25 });
var answer3 = matrix3.Solve(solve3);
Console.WriteLine(answer3);
