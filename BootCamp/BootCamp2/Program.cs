using ArrayClass;
using MatrixClass;

int[] array = 10.CreateInt().FillInt();
array.PrintInt();
Console.WriteLine();
double[] DoubleArray = 10.CreateDouble().FillDouble();
DoubleArray.PrintDouble();
Console.WriteLine();
IntMatrix.CreateIntMatrix(5, 5).FillIntMatrix().PrintIntMatrix();
