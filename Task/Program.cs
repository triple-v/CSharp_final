﻿Console.WriteLine();
Console.WriteLine("Введите размер массива (целое положительное число):");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (size <= 0)
{
  Console.WriteLine($"Введено недопустимое число.");
}
else
{
  string[] array1 = new string[size];
  void CreationArray(string[] array1)
  {
    int count = 0;
    for (int i = 0; i < size; i++)
    {
      if (array1[i] != " ")
      {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
      }
      array1[i] = Console.ReadLine()!;
      count++;
      Console.WriteLine();
    }
  }
  void PrintArray(string[] array2)
  {
    for (int i = 0; i < array2.Length; i++)
    {
      if (array2[i].Length <= 3)
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
  }
  CreationArray(array1);
  PrintArray(array1);
}