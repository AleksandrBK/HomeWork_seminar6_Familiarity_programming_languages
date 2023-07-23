// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] GetArray()
{
    Console.WriteLine("Введите числа, разделяя их пробелами:");
    string input = Console.ReadLine();
    string[] numbersAsStrings = input.Split(' ');
    int[] array = new int[numbersAsStrings.Length];

    for (int i = 0; i < numbersAsStrings.Length; i++)
    {
        array[i] = int.Parse(numbersAsStrings[i]);
    }

    return array;
}

int CheckArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int[] array = GetArray();
int count = CheckArray(array);
Console.WriteLine($"В массиве: [ {string.Join("; ", array)} ] количество чисел больше нуля равно: {count}");

