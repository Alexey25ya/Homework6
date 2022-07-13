// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите желаемое количество чисел:");
int size = Convert.ToInt32(Console.ReadLine());

int[] getArray(int size)
{
    Console.WriteLine("Введите числа в интервале:");
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToInt32(Console.ReadLine());
    }
    return res;
}

int CountPositive(int[] intArray)
{
    int count = 0;
    for (int j = 0; j < size; j++)
    {
        if (intArray[j] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Количество положительных чисел равно "
 + CountPositive(getArray(size)));

