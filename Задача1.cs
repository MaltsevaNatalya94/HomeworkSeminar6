// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите количество элементов");

int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа с клавиатуры");

int [] array = new int [count];
 
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int result=0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
 
Console.WriteLine($"Количество элементов больше 0: {result}");






