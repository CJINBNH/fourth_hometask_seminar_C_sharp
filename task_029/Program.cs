// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 10);
}

Console.WriteLine('[' + string.Join(", ", array) + ']');