// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементами массива.

// Задаем размерность массива.
Console.Write("Задайте размерность массива: ");
int length = int.Parse (Console.ReadLine());

// Задаем min и max значения массива.
Console.Write("Задайте min значение массива: ");
int min = int.Parse (Console.ReadLine());
Console.Write("Задайте max значение массива: ");
int max = int.Parse (Console.ReadLine());

// Объявляем массив с именем array.
double[] array = new double [length];

// Заполняем(инициализируем) массив случайными вещественными числами в
// заданном диапазоне.
Random rand = new Random();
for(int i =0; i<array.Length; i++)
{
  // Вещественное число получаем посредством комбинации 
  // методов Next и NextDouble, т.е. суммы целого числа из заданного
  // диапазона и дробного из диапазона от 0 до 1. Округлим до целых.
  array[i] = rand.Next(min,max) + Math.Round(rand.NextDouble(), 0);
}

// 4. С помощю метода PrintArray формируем формат массива для вывода в терминал.
void PrintArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length-1; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.Write($"{array[array.Length-1]}");
  Console.Write("]");
}

// Выводим в терминал массив и разницу между max и min элементами массива.
PrintArray (array);
Console.WriteLine($" -> Разница между max и min элементами массива: {array.Max() - array.Min()}");