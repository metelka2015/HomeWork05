// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
void CreateArray(int[] array)
{
    var random = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}

void EvenInteger(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int j = 0; j < length; j++)
    {
        if (array[j] % 2 == 0)
        {
            result += 1;
        }
    }
    Console.WriteLine();
    Console.Write("Количество четных чисел в массиве " + result);
}




int[] array = new int[4];
CreateArray(array);
EvenInteger(array);