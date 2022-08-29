// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Ввод массива с клавиатуры

int count = 0;
for (int i =0; i<array.Length; i++ )
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел в массиве больше 0 = "+ count);



// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
