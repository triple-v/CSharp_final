Console.WriteLine();
Console.WriteLine("Введите размер массива (целое положительное число):");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (size <= 0)
{
  Console.WriteLine($"Введено недопустимое число.");
}