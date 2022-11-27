Console.WriteLine();
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
  CreationArray(array1);
}