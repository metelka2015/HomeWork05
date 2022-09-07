// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
void CreateArray(int[] array)
{
    var random = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}

int Max(int[] array)
{
    int length = array.Length;
    int max = array[0];
    for (int j = 1; j < length; j++)
    {
        if (array[j] > max) max = array[j];        
    }
    Console.WriteLine($"{"\nМаксимальный число"} = {max}");
    return max;
}

int Min(int[] massive)
{
    int length = massive.Length;
    int min = massive[0];
    for (int i = 1; i < length; i++)
    {
        if (massive[i] < min) min = massive[i];
        
    }
    Console.WriteLine($"{"Минимальное число "} = { min}");
    return min;

}

int[] array = new int[5];
CreateArray(array);

Console.WriteLine($"{"Разница между максимальным и минимальным значением "} = {Max(array) - Min(array)}");