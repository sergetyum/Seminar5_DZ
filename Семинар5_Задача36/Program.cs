// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// Задаем размерность массива.
Console.Write("Задайте размерность массива: ");
int length = int.Parse (Console.ReadLine());

// Задаем min и max значения массива.
Console.Write("Задайте min значение массива: ");
int min = int.Parse (Console.ReadLine());
Console.Write("Задайте max значение массива: ");
int max = int.Parse (Console.ReadLine());

// Объявляем массив с именем array.
int[] array = new int [length];

// С помощью метода FillArray заполняем(инициализируем) массив
// случайными числами в заданном диапазоне.
void FillArray(int[] array)
{
   Random rand = new Random();
   for(int i =0; i<array.Length; i++)
   {
      array[i] = rand.Next(min,max); //Заполняем массив случайными числами.
   }
}

// 4. С помощю метода PrintArray формируем формат массива для вывода в терминал.
void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length-1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length-1]}");
  Console.Write("]");
}

// Вызываем метод FillArray для массива array.
FillArray (array);

// Находим сумму нечетных элементов массива array.
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
        sum += array[i];
}

// Вызываем метод PrintArray и выводим в терминал массив и сумму элементов,
// стоящих на нечетных позициях.
PrintArray (array);
Console.WriteLine($" -> сумма элементов, стоящих на нечетных позициях: {sum}");