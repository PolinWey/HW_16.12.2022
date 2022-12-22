/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] N()
{
    Console.Write("Выберите длину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(" " + array[i] + " ");
    }
    return array;
}
int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество значений больше 0: " + count);
    return count;
}
int[] array = N();
CountNumbers(array);