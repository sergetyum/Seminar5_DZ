// Задайте массив, заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел
// в массиве.

// 1. Задаем размерность массива.
Console.Write("Задайте размерность массива: ");
int length = int.Parse (Console.ReadLine());

// 2. Объявляем массив с именем array.
int[] array = new int [length];

// 3. Вариант 1. С помощью метода FillArray заполняем(инициализируем) массив
// случайными положительными трехзначными числами с помощью цикла for.
void FillArray(int[] array)
{
   Random rand = new Random();
   for(int i =0; i<array.Length; i++)
   {
      array[i] = rand.Next(100,999); //Заполняем массив случайными трехзначными числами.
   }
}

// 3. Вариант 2. С помощью метода FillArray заполняем (инициализируем
// массив случайными положительными трехзначными числами с помощью цикла while.
//void FillArray(int[] array)
//{
  //int length = array.Length;
  //int i = 0;
  //while (i < length)
  //{
    //array[i] = new Random(). Next(100, 999);
    //i++;
  //}
//}

// 4. С помощью метода PrintArray формируем формат массива для вывода в терминал.
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

// 5. Определяем количество четных чисел в сформированном массиве.
int count=0;
for (int i = 0; i < array.Length; i++)
{
if ((array[i] % 2) == 0)
count++;
}

// 6. Вызываем методы, которые применяли для инициализации 
// и формирования формата распечатки массива array.
FillArray (array);
PrintArray (array);


// 7. Выводим массив и количество в нем четных чисел в терминал.
Console.Write($" -> количество четных чисел: {count}");