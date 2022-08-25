// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество M чисел, подлежащих проверке(>0): ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int [] Array = new int[size];
int Count=0; //счетчик четных чисел
for (int i =0; i<size; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
    if (Array[i]>0) Count++;

}
Console.WriteLine($"Количество чисел больших нуля:  {Count} ");
