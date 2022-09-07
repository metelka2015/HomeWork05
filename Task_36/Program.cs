// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
void CreateArray(int[] array)
{
    var random = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
        Console.Write(array[i] + " ");
    }
}

void SummNotEvenArray(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int j = 0; j < length; j++)
    {
        if (j % 2 != 0)
        {
            result += array[j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов на нечетных позициях =  " + result);
}

int[] array = new int[4];
CreateArray(array);
SummNotEvenArray(array);