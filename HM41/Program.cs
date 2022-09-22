/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введите число, соответствующее кол-ву вводимых чисел: ");
int m = int.Parse(Console.ReadLine());
int[] arraynumb = new int[m];
void InputNum(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arraynumb[i] = int.Parse(Console.ReadLine());
    }
}
int Comparison(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0) count += 1;
    }
    return count;
}
InputNum(m);
Console.WriteLine($"Введено чисел больше 0: {Comparison(arraynumb)} ");